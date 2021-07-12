using Core.DependencyInversionPrinciple.SOLIDSolution.Domain;
using NUnit.Framework;
using System;

namespace Tests.DependencyInversionPrinciple.SOLIDSolution
{
    public class TestSendNotificationEmail
    {
        [Test]
        public void sendNotificationSMS()
        {
            Console.WriteLine("===");
            Console.WriteLine("Dependency Inversion Principle - SOLID Solution");
            Console.WriteLine("===");
            Console.WriteLine();
            Console.WriteLine();
            IMessenger sms = new SMS();
            new Notification(sms).sendPromotion();
            Console.WriteLine();
            Console.WriteLine("===");
            Assert.Pass();
        }

        [Test]
        public void sendNotificationEmail()
        {
            Console.WriteLine("===");
            Console.WriteLine("Dependency Inversion Principle - SOLID Solution");
            Console.WriteLine("===");
            Console.WriteLine();
            Console.WriteLine();
            IMessenger email = new Email();
            new Notification(email).sendPromotion();
            Console.WriteLine();
            Console.WriteLine("===");
            Assert.Pass();
        }
    }
}

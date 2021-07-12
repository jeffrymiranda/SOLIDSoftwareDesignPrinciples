using Core.DependencyInversionPrinciple.CommonSolution.Domain;
using NUnit.Framework;
using System;

namespace Tests.DependencyInversionPrinciple.CommonSolution
{
    public class TestSendNotification
    {
        [Test]
        public void sendNotification()
        {
            Console.WriteLine("===");
            Console.WriteLine("Dependency Inversion Principle - Common Solution");
            Console.WriteLine("===");
            Console.WriteLine();
            Console.WriteLine();
            new Notification().sendPromotion();
            Console.WriteLine();
            Console.WriteLine("===");
            Assert.Pass();
        }
    }
}

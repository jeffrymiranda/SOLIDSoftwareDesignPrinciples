using System;

namespace Core.DependencyInversionPrinciple.CommonSolution.Domain
{
    public class Email
    {
        public void sendEmail()
        {
            Console.WriteLine("============================");
            Console.WriteLine(">>>>>>>SENDING EMAIL>>>>>>>>>");
            Console.WriteLine("============================");
        }
    }
}

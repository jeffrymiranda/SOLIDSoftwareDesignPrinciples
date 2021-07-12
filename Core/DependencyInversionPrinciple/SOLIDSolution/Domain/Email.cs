using System;

namespace Core.DependencyInversionPrinciple.SOLIDSolution.Domain
{
    public class Email : IMessenger
    {
        public void sendMessage()
        {
            Console.WriteLine("============================");
            Console.WriteLine(">>>>>>>SENDING EMAIL>>>>>>>>>");
            Console.WriteLine("============================");
        }
    }
}

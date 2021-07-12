using System;

namespace Core.DependencyInversionPrinciple.SOLIDSolution.Domain
{
    public class SMS : IMessenger
    {
        public void sendMessage()
        {
            Console.WriteLine("============================");
            Console.WriteLine(">>>>>>>SENDING SMS>>>>>>>>>");
            Console.WriteLine("============================");
        }
    }
}

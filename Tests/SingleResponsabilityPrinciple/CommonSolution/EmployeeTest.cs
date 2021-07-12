using System;
using Core.SingleResponsabilityPrinciple.CommonSolution.Service;
using NUnit.Framework;

namespace Tests.SingleResponsabilityPrinciple.CommonSolution
{
    public class EmployeeTest
    {
        [Test]
        public void InsertEmployees()
        {
            Console.WriteLine("===");
            Console.WriteLine("Single Responsability - Common Solution");
            Console.WriteLine("===");
            Console.WriteLine();
            Console.WriteLine();
            EmployeeProcessor processor = new EmployeeProcessor();
            for (int i = 0; i < 10; i++) {
                processor.insertEmployee(i, i.ToString() + " Employee");
            }
            processor.printReport();
            Console.WriteLine();
            Console.WriteLine("===");
            Assert.Pass();
        }
    }
}

using System;
using Core.SingleResponsabilityPrinciple.SOLIDSolution.Domain;
using Core.SingleResponsabilityPrinciple.SOLIDSolution.Service;
using NUnit.Framework;

namespace Tests.SingleResponsabilityPrinciple.SOLIDSolution
{
    public class EmployeeTest
    {
        EmployeeList list = new EmployeeList();

        [Test]
        public void InsertEmployees()
        {
            Console.WriteLine("===");
            Console.WriteLine("Single Responsability - SOLID Solution");
            Console.WriteLine("===");
            Console.WriteLine();
            Console.WriteLine();
            EmployeeCRUD employee = new EmployeeCRUD(list);
            for (int i = 0; i < 10; i++) {
                employee.InsertEmployee(new Employee { EmployeeID = i, EmployeeName = i.ToString() + " Employee" });
            }
            Console.WriteLine();
            Console.WriteLine("===");
            Assert.Pass();
        }

        [Test]
        public void PrintEmployees()
        {
            Console.WriteLine("===");
            Console.WriteLine("Single Responsability - SOLID Solution");
            Console.WriteLine("===");
            Console.WriteLine();
            Console.WriteLine();
            EmployeeReporter reporter = new EmployeeReporter(list);
            reporter.GenerateReport();
            Console.WriteLine();
            Console.WriteLine("===");
            Assert.Pass();
        }
    }
}

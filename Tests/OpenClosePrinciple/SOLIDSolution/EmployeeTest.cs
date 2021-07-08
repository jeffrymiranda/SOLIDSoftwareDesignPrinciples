using NUnit.Framework;
using System.Collections.Generic;
using Core.OpenClosePrinciple.SOLIDSolution;
using System;

namespace Tests.OpenClosePrinciple.SOLIDSolution
{
    public class EmployeeTest
    {
        [Test]
        public void GetSalary_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("OpenClosePrinciple - SOLID Solution");

            List<Employee> employees = new()
            {
                new Support("Svetlana Isakova", 15.25, 48),
                new Regular("Dmitry Jemerov", 17.50, 42),
                new Contractor("Aleksei Sedunov", 19.50, 45)
            };

            employees.ForEach(delegate (Employee employee)
            {
                Console.WriteLine(employee.GetFullName() + " salary: $" + employee.CalculateWeeklySalary());
            });
            Console.WriteLine("===");
            Assert.Pass();
        }

        [Test]
        public void GetSalaryForContractor_HappyPath()
        {
            // arrange
            var contractor = new Contractor("Aleksei Sedunov", 19.50, 42);

            // act
            var weeklySalary = contractor.CalculateWeeklySalary();

            // assert
            Assert.AreEqual(819, weeklySalary);
        }
    }
}

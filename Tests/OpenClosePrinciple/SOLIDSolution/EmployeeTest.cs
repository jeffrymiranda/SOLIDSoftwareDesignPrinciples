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
            const int hoursReported = 42;

            List<Employee> employees = new()
            {
                new Support("Svetlana Isakova", 15.25),
                new Regular("Dmitry Jemerov", 17.50),
                new Contractor("Aleksei Sedunov", 19.50)
            };

            employees.ForEach(delegate (Employee employee)
            {
                Console.WriteLine(employee.GetFullName() + " salary: $" + employee.CalculateWeeklySalary(hoursReported));
            });
            Console.WriteLine("===");
            Assert.Pass();
        }

        [Test]
        public void GetSalaryForContractor_HappyPath()
        {
            // arrange
            var contractor = new Contractor("Aleksei Sedunov", 19.50);

            // act
            var weeklySalary = contractor.CalculateWeeklySalary(42);

            // assert
            Assert.AreEqual(819, weeklySalary);
        }
    }
}

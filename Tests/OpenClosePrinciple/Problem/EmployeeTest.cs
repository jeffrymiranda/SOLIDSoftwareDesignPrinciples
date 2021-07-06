using NUnit.Framework;
using System.Collections.Generic;
using Core.OpenClosePrinciple.Problem;
using System;

namespace Tests.OpenClosePrinciple.Problem
{
    public class EmployeeTest
    {
        [Test]
        public void PrintSalaries_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("OpenClosePrinciple - Problem");
            const int hoursReported = 42;

            List<Employee> employees = new()
            {
                new Employee("Svetlana Isakova", "Support", 15.25),
                new Employee("Dmitry Jemerov", "Developer", 17.50),
                new Employee("Aleksei Sedunov", "Contractor", 19.50)
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
            var contractor = new Employee("Aleksei Sedunov", "Contractor", 19.50);

            // act
            var weeklySalary = contractor.CalculateWeeklySalary(42);

            // assert
            Assert.AreEqual(819, weeklySalary);
        }
    }
}

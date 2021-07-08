using NUnit.Framework;
using System.Collections.Generic;
using Core.OpenClosePrinciple.CommonSolution;
using System;

namespace Test.OpenClosePrinciple.CommonSolution
{
    public class EmployeeTest
    {
        [Test]
        public void GetSalary_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("OpenClosePrinciple - Common Solution");

            List<Employee> employees = new()
            {
                new Employee("Svetlana Isakova", "Support", 15.25, 48),
                new Employee("Dmitry Jemerov", "Developer", 17.50, 42),
                new Employee("Aleksei Sedunov", "Contractor", 19.50, 45)
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
            var contractor = new Employee("Aleksei Sedunov", "Contractor", 19.50, 42);

            // act
            var weeklySalary = contractor.CalculateWeeklySalary();

            // assert
            Assert.AreEqual(819, weeklySalary);
        }
    }
}

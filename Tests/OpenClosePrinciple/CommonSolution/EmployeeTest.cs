using System;
using NUnit.Framework;
using System.Collections.Generic;
using Core.OpenClosePrinciple.CommonSolution.Domain;
using Core.OpenClosePrinciple.CommonSolution.Service;

namespace Test.OpenClosePrinciple.CommonSolution
{
    public class EmployeeTest
    {
        [Test]
        public void PrintPayroll_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("Open Close Principle - Common Solution");
            Console.WriteLine("===");
            Console.WriteLine("");

            List<Employee> employees = new()
            {
                new Employee("Robert C Martin", 18.15, 36),
                new Employee("Svetlana Isakova", 15.25, 44),
                new Support("Dmitry Jemerov", 13.8, 38),
                new Support("Aleksei Sedunov", 14.6, 47)
            };

            Payroll.PrintPayroll(employees);
            Console.WriteLine("===");
            Assert.Pass();
        }

        [Test]
        public void GetSalaryForRegular_HappyPath()
        {
            // arrange
            var regular = new Employee("Svetlana Isakova", 15.25, 44);

            // act
            var weeklySalary = Payroll.CalculateWeeklyExtraHoursSalary(regular);

            // assert
            Assert.AreEqual(79.3d, weeklySalary);
        }

        [Test]
        public void GetSalaryForSupport_HappyPath()
        {
            // arrange
            var support = new Support("Aleksei Sedunov", 15.25, 44);

            // act
            var weeklySalary = Payroll.CalculateWeeklyExtraHoursSalary(support);

            // assert
            Assert.AreEqual(91.5d, weeklySalary);
        }
    }
}

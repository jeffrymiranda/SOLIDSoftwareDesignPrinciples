using NUnit.Framework;
using System.Collections.Generic;
using Core.OpenClosePrinciple.SOLIDSolution.Domain;
using Core.OpenClosePrinciple.SOLIDSolution.Service;
using System;

namespace Tests.OpenClosePrinciple.SOLIDSolution
{
    public class EmployeeTest
    {
        [Test]
        public void PrintPayroll_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("Open Close Principle - SOLID Solution");
            Console.WriteLine("===");
            Console.WriteLine("");

            List<Employee> employees = new()
            {
                new Regular("Robert C Martin", 18.15, 36),
                new Regular("Svetlana Isakova", 15.25, 44),
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
            var regular = new Regular("Svetlana Isakova", 15.25, 44);

            // act
            var weeklySalary = regular.CalculateWeeklyExtraHoursSalary();

            // assert
            Assert.AreEqual(79.3d, weeklySalary);
        }

        [Test]
        public void GetSalaryForSupport_HappyPath()
        {
            // arrange
            var support = new Support("Aleksei Sedunov", 15.25, 44);

            // act
            var weeklySalary = support.CalculateWeeklyExtraHoursSalary();

            // assert
            Assert.AreEqual(91.5d, weeklySalary);
        }
    }
}

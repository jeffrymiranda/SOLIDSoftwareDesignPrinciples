using NUnit.Framework;
using System.Collections.Generic;
using Core.LiskovSubstitutionPrinciple.CommonSolution.Domain;
using Core.LiskovSubstitutionPrinciple.CommonSolution.Service;
using System;

namespace Tests.LiskovSubstitutionPrinciple.CommonSolution
{
    public class EmployeeTest
    {
        [Test]
        public void PrintPayroll_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("LiskovSubstitutionPrinciple - Common Solution");
            Console.WriteLine("===");
            Console.WriteLine("");

            List<Employee> employees = new()
            {
                new Regular("Svetlana Isakova", 15.25, 44),
                new Support("Aleksei Sedunov", 14.6, 47),
                new Contractor("Dmitry Jemerov", 13.8, 45)
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


        [Test]
        public void GetSalaryForContractor_HappyPath()
        {
            // arrange
            var support = new Contractor("Dmitry Jemerov", 13.8, 45);

            // act
            var weeklySalary = support.CalculateWeeklyExtraHoursSalary();

            // assert
            Assert.AreEqual(0d, weeklySalary);
        }
    }
}

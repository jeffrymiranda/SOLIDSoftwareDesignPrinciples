using NUnit.Framework;
using System.Collections.Generic;
using Core.LiskovSubstitutionPrinciple.SOLIDSolution.Domain;
using Core.LiskovSubstitutionPrinciple.SOLIDSolution.Service;
using System;

namespace Tests.LiskovSubstitutionPrinciple.SOLIDSolution
{
    public class EmployeeTest
    {
        [Test]
        public void PrintPayrollForInternalEmployees_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("Liskov Substitution Principle - SOLID Solution");
            Console.WriteLine("===");
            Console.WriteLine("");

            List<Employee> employees = new()
            {
                new Regular("Svetlana Isakova", 15.25, 44),
                new Support("Aleksei Sedunov", 14.6, 47)
            };

            Payroll.PrintPayrollForInternals(employees);
            Console.WriteLine("===");
            Assert.Pass();
        }

        [Test]
        public void PrintPayrollContractorsEmployees_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("Liskov Substitution Principle - SOLID Solution");
            Console.WriteLine("===");
            Console.WriteLine("");

            List<Employee> employees = new()
            {
                new Contractor("Robert C Martin", 14.6, 47),
                new Contractor("Dmitry Jemerov", 13.8, 45)
            };

            Payroll.PrintPayrollForContractors(employees);
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
            var weeklySalary = support.CalculateWeeklyOrdinarySalary();

            // assert
            Assert.AreEqual(621d, weeklySalary);
        }
    }
}

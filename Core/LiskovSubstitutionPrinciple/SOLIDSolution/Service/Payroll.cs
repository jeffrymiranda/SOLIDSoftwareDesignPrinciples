using System;
using System.Collections.Generic;
using Core.LiskovSubstitutionPrinciple.SOLIDSolution.Domain;

namespace Core.LiskovSubstitutionPrinciple.SOLIDSolution.Service
{
    public class Payroll
    {
        /// <summary>
        /// Weekly payroll report for internal employees
        /// </summary>
        /// <param name="employees"></param>
        public static void PrintPayrollForInternals(List<Employee> employees)
        {
            Console.WriteLine("Weekly payroll report for internal employees");
            Console.WriteLine("");
            employees.ForEach(delegate (Employee employee)
            {
                double ordinaryWeeklySalary = employee.CalculateWeeklyOrdinarySalary();
                double extraHoursWeeklySalary = ((Internal) employee).CalculateWeeklyExtraHoursSalary();
                int ordinaryHoursReported = employee.HoursReported - ((Internal)employee).GetExtraHours();
                Console.WriteLine($"Employee name: {employee.FullName}");
                Console.WriteLine($"Ordinary salary amount ({ordinaryHoursReported}h): ${ordinaryWeeklySalary}");
                Console.WriteLine($"Extra hours salary amount ({((Internal)employee).GetExtraHours()}h): ${extraHoursWeeklySalary}");
                Console.WriteLine($"Weekly salary (total): ${ordinaryWeeklySalary + extraHoursWeeklySalary }");
                Console.WriteLine("===");
                Console.WriteLine("");
            });
        }

        /// <summary>
        /// Weekly payroll report for internal employees
        /// </summary>
        /// <param name="contractors"></param>
        public static void PrintPayrollForContractors(List<Employee> contractors)
        {
            Console.WriteLine("Weekly payroll report for contractors employees");
            Console.WriteLine("");
            contractors.ForEach(delegate (Employee contractor)
            {
                double ordinaryWeeklySalary = contractor.CalculateWeeklyOrdinarySalary();
                Console.WriteLine($"Employee name: {contractor.FullName}");
                Console.WriteLine($"Ordinary salary amount ({contractor.HoursReported}h): ${ordinaryWeeklySalary}");
                Console.WriteLine($"Weekly salary (total): ${ordinaryWeeklySalary}");
                Console.WriteLine("===");
                Console.WriteLine("");
            });
        }
    }
}
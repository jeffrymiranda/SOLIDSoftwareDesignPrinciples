using System;
using System.Collections.Generic;
using Core.LiskovSubstitutionPrinciple.CommonSolution.Domain;

namespace Core.LiskovSubstitutionPrinciple.CommonSolution.Service
{
    public class Payroll
    {
        /// <summary>
        /// Weekly payroll report
        /// </summary>
        /// <param name="employees"></param>
        public static void PrintWeeklyPayroll(List<Employee> employees)
        {
            Console.WriteLine("Weekly payroll report for employees");
            Console.WriteLine("");
            employees.ForEach(delegate (Employee employee)
            {
                double ordinaryWeeklySalary = employee.CalculateWeeklyOrdinarySalary();
                double extraHoursWeeklySalary = employee.CalculateWeeklyExtraHoursSalary();
                int ordinaryHoursReported = employee.HoursReported - employee.GetExtraHours();
                Console.WriteLine($"Employee name: {employee.FullName}");
                Console.WriteLine($"Ordinary salary amount ({ordinaryHoursReported}h): ${ordinaryWeeklySalary}");
                Console.WriteLine($"Extra hours salary amount ({employee.GetExtraHours()}h): ${extraHoursWeeklySalary}");
                Console.WriteLine($"Weekly salary (total): ${ordinaryWeeklySalary + extraHoursWeeklySalary }");
                Console.WriteLine("===");
                Console.WriteLine("");
            });
        }
    }
}
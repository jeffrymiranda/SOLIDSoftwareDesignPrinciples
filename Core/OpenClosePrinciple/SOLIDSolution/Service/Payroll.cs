using System;
using System.Collections.Generic;
using Core.OpenClosePrinciple.SOLIDSolution.Domain;

namespace Core.OpenClosePrinciple.SOLIDSolution.Service
{
    public class Payroll
    {
        /// <summary>
        /// Weekly payroll report
        /// </summary>
        /// <param name="employees"></param>
        public static void PrintPayroll(List<Employee> employees)
        {
            employees.ForEach(delegate (Employee employee)
            {
                double ordinaryWeeklySalary = employee.CalculateWeeklyOrdinarySalary();
                double extraHoursWeeklySalary = employee.CalculateWeeklyExtraHoursSalary();
                Console.WriteLine($"Employee name: {employee.FullName}");
                Console.WriteLine($"Weekly salary (ordinary): {ordinaryWeeklySalary}");
                Console.WriteLine($"Weekly salary (extra hours): {extraHoursWeeklySalary}");
                Console.WriteLine($"Weekly salary (total): {ordinaryWeeklySalary + extraHoursWeeklySalary }");
                Console.WriteLine("===");
                Console.WriteLine("");
            });
        }
    }
}
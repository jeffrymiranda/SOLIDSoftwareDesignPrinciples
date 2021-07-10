using System;
using System.Collections.Generic;
using Core.OpenClosePrinciple.CommonSolution.Domain;

namespace Core.OpenClosePrinciple.CommonSolution.Service
{
    public class Payroll
    {
        #region Weekly salary (ordinary hours) calculation

        /// <summary>
        /// This method is intelligent enough to calculate the weekly salary (ordinary hours) for support and regular employees.
        /// </summary>
        /// <returns></returns>
        private static double CalculateWeeklyOrdinarySalary(Employee employee) =>
            (employee.HoursReported - employee.GetExtraHours()) * employee.CostPerHour;

        #endregion

        #region Weekly salary (extra hours) calculation

        /// <summary>
        /// This method is intelligent enough to calculate the weekly salary (extra hours) for support and regular employees.
        /// </summary>
        /// <returns></returns>
        public static double CalculateWeeklyExtraHoursSalary(Employee employee)
        {
            // Salary calculation based on the role.
            if (typeof(Support).IsInstanceOfType(employee))
            {
                return employee.GetExtraHours() * (employee.CostPerHour * 1.5);
            }
            return employee.GetExtraHours() * (employee.CostPerHour * 1.3);
        }

        #endregion

        #region Print weekly payroll

        /// <summary>
        /// Weekly payroll report
        /// </summary>
        /// <param name="employees"></param>
        public static void PrintPayroll(List<Employee> employees)
        {
            employees.ForEach(delegate (Employee employee)
            {
                double ordinaryWeeklySalary = CalculateWeeklyOrdinarySalary(employee);
                double extraHoursWeeklySalary = CalculateWeeklyExtraHoursSalary(employee);
                int ordinaryHoursReported = employee.HoursReported - employee.GetExtraHours();
                Console.WriteLine($"Employee name: {employee.FullName}");
                Console.WriteLine($"Ordinary salary amount ({ordinaryHoursReported}h): ${ordinaryWeeklySalary}");
                Console.WriteLine($"Extra hours salary amount ({employee.GetExtraHours()}h): ${extraHoursWeeklySalary}");
                Console.WriteLine($"Weekly salary (total): ${ordinaryWeeklySalary + extraHoursWeeklySalary }");
                Console.WriteLine("===");
                Console.WriteLine("");
            });
        }

        #endregion
    }
}
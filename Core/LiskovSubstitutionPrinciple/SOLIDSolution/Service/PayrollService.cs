using System;
using System.Collections.Generic;
using Core.LiskovSubstitutionPrinciple.SOLIDSolution.Domain;

namespace Core.LiskovSubstitutionPrinciple.SOLIDSolution.Service
{
    public class PayrollService
    {
        public static void PrintWeeklyPayroll(Dictionary<Employee, IPayroll> payrollDictionary)
        {
            Console.WriteLine("Weekly payroll report for employees");
            Console.WriteLine("");
            foreach (var dictionary in payrollDictionary)
            {
                var employee = dictionary.Key;
                var payroll = dictionary.Value;
                payroll.PrintWeeklyPayroll(employee);
                Console.WriteLine("===");
                Console.WriteLine("");
            }
        }
    }
}

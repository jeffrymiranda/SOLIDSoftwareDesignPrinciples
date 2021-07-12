using System;
using Core.LiskovSubstitutionPrinciple.SOLIDSolution.Domain;

namespace Core.LiskovSubstitutionPrinciple.SOLIDSolution.Service
{
    public class ContractorPayroll : IPayroll
    {
        public void PrintWeeklyPayroll(Employee employee)
        {
            double ordinaryWeeklySalary = employee.CalculateWeeklyOrdinarySalary();
            Console.WriteLine($"Employee name: {employee.FullName}");
            Console.WriteLine($"Ordinary salary amount ({employee.HoursReported}h): ${ordinaryWeeklySalary}");
            Console.WriteLine($"Weekly salary (total): ${ordinaryWeeklySalary}");
        }
    }
}

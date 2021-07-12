using System;
using Core.LiskovSubstitutionPrinciple.SOLIDSolution.Domain;

namespace Core.LiskovSubstitutionPrinciple.SOLIDSolution.Service
{
    public class InternalPayroll : IPayroll
    {
        public void PrintWeeklyPayroll(Employee employee)
        {
            double ordinaryWeeklySalary = employee.CalculateWeeklyOrdinarySalary();
            double extraHoursWeeklySalary = ((Internal)employee).CalculateWeeklyExtraHoursSalary();
            int ordinaryHoursReported = employee.HoursReported - ((Internal)employee).GetExtraHours();
            Console.WriteLine($"Employee name: {employee.FullName}");
            Console.WriteLine($"Ordinary salary amount ({ordinaryHoursReported}h): ${ordinaryWeeklySalary}");
            Console.WriteLine($"Extra hours salary amount ({((Internal)employee).GetExtraHours()}h): ${extraHoursWeeklySalary}");
            Console.WriteLine($"Weekly salary (total): ${ordinaryWeeklySalary + extraHoursWeeklySalary }");
        }
    }
}

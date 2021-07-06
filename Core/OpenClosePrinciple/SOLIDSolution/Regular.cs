using System;
namespace Core.OpenClosePrinciple.SOLIDSolution
{
    public class Regular : Employee
    {
        public Regular(string fullName, double costPerHour) : base(fullName, costPerHour)
        {

        }

        public override double CalculateWeeklySalary(int hoursReported)
        {
            int extraHours = (hoursReported > WeeklyHours) ? hoursReported - WeeklyHours : 0;
            return hoursReported * costPerHour + extraHours * (costPerHour * 1.3);
        }
    }
}

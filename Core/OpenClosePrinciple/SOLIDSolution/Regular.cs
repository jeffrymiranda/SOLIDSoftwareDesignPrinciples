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
            int extraHours = GetExtraHours(hoursReported);
            return hoursReported * costPerHour + extraHours * (costPerHour * 1.3);
        }
    }
}

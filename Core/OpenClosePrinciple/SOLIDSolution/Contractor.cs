using System;
namespace Core.OpenClosePrinciple.SOLIDSolution
{
    public class Contractor : Employee
    {
        public Contractor(string fullName, double costPerHour) : base(fullName, costPerHour)
        {

        }

        public override double CalculateWeeklySalary(int hoursReported) => hoursReported * costPerHour;
    }
}

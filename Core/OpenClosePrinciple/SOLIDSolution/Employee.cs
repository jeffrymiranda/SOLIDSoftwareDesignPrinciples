using System;
namespace Core.OpenClosePrinciple.SOLIDSolution
{
    public abstract class Employee
    {
        protected const int WeeklyHours = 40;
        private readonly string fullName;
        protected readonly double costPerHour;

        protected Employee(string fullName, double costPerHour)
        {
            this.fullName = fullName;
            this.costPerHour = costPerHour;
        }

        public string GetFullName()
        {
            return this.fullName;
        }

        protected static int GetExtraHours(int hoursReported)
        {
            return (hoursReported > WeeklyHours) ? hoursReported - WeeklyHours : 0;
        }
        public abstract double CalculateWeeklySalary(int hoursReported);
    }
}

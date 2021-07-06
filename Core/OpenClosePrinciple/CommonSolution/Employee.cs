using System;
namespace Core.OpenClosePrinciple.CommonSolution
{
    public class Employee
    {
        private const int WeeklyHours = 40;
        private readonly string fullName;
        private readonly string role;
        private readonly double costPerHour;

        public Employee(string fullName, string role, double costPerHour)
        {
            this.fullName = fullName;
            this.role = role;
            this.costPerHour = costPerHour;
        }

        public string GetFullName()
        {
            return this.fullName;
        }

        /// <summary>
        /// This method calculates the weekly salary taking into consideration the extra uour reported.
        /// Notice that this method is intelligent enough to calculate the extra hour of the support workers.
        /// </summary>
        /// <param name="hoursReported"></param>
        /// <returns></returns>
        public double CalculateWeeklySalary(int hoursReported)
        {
            int extraHours = (hoursReported > WeeklyHours) ? hoursReported - WeeklyHours : 0;
            return this.role switch
            {
                "Contractor" => hoursReported * this.costPerHour,
                "Support" => hoursReported * this.costPerHour + extraHours * (this.costPerHour * 1.5),
                _ => hoursReported * this.costPerHour + extraHours * (this.costPerHour * 1.3),
            };
        }
    }
}

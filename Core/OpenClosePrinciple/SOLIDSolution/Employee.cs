﻿namespace Core.OpenClosePrinciple.SOLIDSolution
{
    public abstract class Employee
    {
        #region miscellaneous
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
        #endregion

        /// <summary>
        /// To calculate the weekly salary
        /// </summary>
        /// <param name="hoursReported"></param>
        /// <returns></returns>
        public abstract double CalculateWeeklySalary(int hoursReported);
    }
}

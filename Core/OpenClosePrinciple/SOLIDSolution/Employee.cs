namespace Core.OpenClosePrinciple.SOLIDSolution
{
    public abstract class Employee
    {
        #region miscellaneous
        protected const int WeeklyHours = 40;
        private readonly string fullName;
        protected readonly double costPerHour;
        protected readonly int hoursReported;

        protected Employee(string fullName, double costPerHour, int hoursReported)
        {
            this.fullName = fullName;
            this.costPerHour = costPerHour;
            this.hoursReported = hoursReported;
        }

        public string GetFullName()
        {
            return this.fullName;
        }
        #endregion

        /// <summary>
        /// To calculate the weekly salary
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateWeeklySalary();
    }
}
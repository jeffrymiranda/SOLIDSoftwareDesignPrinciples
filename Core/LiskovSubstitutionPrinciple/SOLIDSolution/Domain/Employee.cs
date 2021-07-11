namespace Core.LiskovSubstitutionPrinciple.SOLIDSolution.Domain
{
    public abstract class Employee
    {
        #region Fileds

        protected const int WeeklyHours = 40;
        private readonly string fullName;
        private readonly double costPerHour;
        private readonly int hoursReported;

        #endregion

        #region Constructor

        protected Employee(string fullName, double costPerHour, int hoursReported)
        {
            this.fullName = fullName;
            this.costPerHour = costPerHour;
            this.hoursReported = hoursReported;
        }
        #endregion

        #region Accessor and Mutators

        public string FullName => fullName;

        protected double CostPerHour => costPerHour;

        public int HoursReported => hoursReported;

        #endregion

        #region Abstract Methods

        /// <summary>
        /// This method is intelligent enough to calculate the weekly salary (ordinary hours) for support and regular employees.
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateWeeklyOrdinarySalary();

        #endregion
    }
}
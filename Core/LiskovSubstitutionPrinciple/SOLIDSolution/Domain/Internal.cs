namespace Core.LiskovSubstitutionPrinciple.SOLIDSolution.Domain
{
    public abstract class Internal : Employee
    {
        #region Constructor

        protected Internal(string fullName, double costPerHour, int hoursReported)
            : base(fullName, costPerHour, hoursReported) { }

        #endregion

        #region Methods

        public int GetExtraHours() => (HoursReported > WeeklyHours) ? HoursReported - WeeklyHours : 0;

        public override double CalculateWeeklyOrdinarySalary() => (HoursReported - GetExtraHours()) * CostPerHour;

        #endregion

        #region Abstract Methods

        /// <summary>
        /// This method is implementing to calculate the weekly salary (extra hours) for any employee.
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateWeeklyExtraHoursSalary();

        #endregion
    }
}

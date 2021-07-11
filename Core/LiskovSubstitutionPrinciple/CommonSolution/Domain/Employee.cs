namespace Core.LiskovSubstitutionPrinciple.CommonSolution.Domain
{
    public abstract class Employee
    {
        #region Fileds

        public const int WeeklyHours = 40;
        private readonly string fullName;
        private readonly double costPerHour;
        private readonly int hoursReported;

        #endregion

        #region Constructor

        public Employee(string fullName, double costPerHour, int hoursReported)
        {
            this.fullName = fullName;
            this.costPerHour = costPerHour;
            this.hoursReported = hoursReported;
        }
        #endregion

        #region Accessor and Mutators

        public string FullName => fullName;

        public double CostPerHour => costPerHour;

        public int HoursReported => hoursReported;

        #endregion

        #region Methods

        public int GetExtraHours() => (HoursReported > WeeklyHours) ? HoursReported - WeeklyHours : 0;

        /// <summary>
        /// This method is intelligent enough to calculate the weekly salary (ordinary hours) for support and regular employees.
        /// </summary>
        /// <returns></returns>
        public double CalculateWeeklyOrdinarySalary() => (HoursReported - GetExtraHours()) * CostPerHour;

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
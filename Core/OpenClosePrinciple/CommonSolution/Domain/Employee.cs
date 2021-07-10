namespace Core.OpenClosePrinciple.CommonSolution.Domain
{
    public class Employee
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

        #endregion
    }
}
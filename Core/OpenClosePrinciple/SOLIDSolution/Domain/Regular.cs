namespace Core.OpenClosePrinciple.SOLIDSolution.Domain
{
    public class Regular : Employee
    {
        #region Constructor

        public Regular(string fullName, double costPerHour, int hoursReported)
            : base(fullName, costPerHour, hoursReported) { }

        #endregion

        #region Methods

        public override double CalculateWeeklyExtraHoursSalary() => GetExtraHours() * (CostPerHour * 1.3);

        #endregion
    }
}
namespace Core.LiskovSubstitutionPrinciple.SOLIDSolution.Domain
{
    public class Support : Internal
    {
        #region Constructor

        public Support(string fullName, double costPerHour, int hoursReported)
            : base(fullName, costPerHour, hoursReported) { }

        #endregion

        #region Methods

        public override double CalculateWeeklyExtraHoursSalary() => GetExtraHours() * (CostPerHour * 1.5);

        #endregion
    }
}
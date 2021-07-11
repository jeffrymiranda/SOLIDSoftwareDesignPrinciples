namespace Core.LiskovSubstitutionPrinciple.CommonSolution.Domain
{
    public class Contractor : Employee
    {
        #region Constructor

        public Contractor(string fullName, double costPerHour, int hoursReported)
            : base(fullName, costPerHour, hoursReported) { }

        #endregion

        #region Methods

        public override double CalculateWeeklyExtraHoursSalary() => 0.0d;

        #endregion
    }
}

namespace Core.LiskovSubstitutionPrinciple.SOLIDSolution.Domain
{
    public class Contractor : Employee
    {
        #region Constructor

        public Contractor(string fullName, double costPerHour, int hoursReported)
            : base(fullName, costPerHour, hoursReported) { }

        #endregion

        #region Methods

        public override double CalculateWeeklyOrdinarySalary() => HoursReported * CostPerHour;

        #endregion
    }
}

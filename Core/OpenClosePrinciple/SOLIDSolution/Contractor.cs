namespace Core.OpenClosePrinciple.SOLIDSolution
{
    public class Contractor : Employee
    {
        #region miscellaneous
        public Contractor(string fullName, double costPerHour, int hoursReported)
            : base(fullName, costPerHour, hoursReported) { }
        #endregion

        public override double CalculateWeeklySalary() => hoursReported * costPerHour;
    }
}
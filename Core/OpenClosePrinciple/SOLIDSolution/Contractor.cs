namespace Core.OpenClosePrinciple.SOLIDSolution
{
    public class Contractor : Employee
    {
        #region miscellaneous
        public Contractor(string fullName, double costPerHour) : base(fullName, costPerHour)
        {

        }
        #endregion

        public override double CalculateWeeklySalary(int hoursReported) => hoursReported * costPerHour;
    }
}

namespace Core.OpenClosePrinciple.SOLIDSolution
{
    public class Support : Employee
    {
        #region miscellaneous
        public Support(string fullName, double costPerHour, int hoursReported)
            : base(fullName, costPerHour, hoursReported) { }
        #endregion

        public override double CalculateWeeklySalary()
        {
            int extraHours = (hoursReported > WeeklyHours) ? hoursReported - WeeklyHours : 0;
            return hoursReported * costPerHour + extraHours * (costPerHour * 1.5);
        }
    }
}
namespace Core.OpenClosePrinciple.SOLIDSolution
{
    public class Regular : Employee
    {
        #region miscellaneous
        public Regular(string fullName, double costPerHour, int hoursReported)
            : base(fullName, costPerHour, hoursReported) { }
        #endregion

        public override double CalculateWeeklySalary()
        {
            int extraHours = (hoursReported > WeeklyHours) ? hoursReported - WeeklyHours : 0;
            return hoursReported * costPerHour + extraHours * (costPerHour * 1.3);
        }
    }
}
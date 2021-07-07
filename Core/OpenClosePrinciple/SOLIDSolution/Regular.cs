namespace Core.OpenClosePrinciple.SOLIDSolution
{
    public class Regular : Employee
    {
        #region miscellaneous
        public Regular(string fullName, double costPerHour) : base(fullName, costPerHour)
        {

        }
        #endregion

        public override double CalculateWeeklySalary(int hoursReported)
        {
            int extraHours = (hoursReported > WeeklyHours) ? hoursReported - WeeklyHours : 0;
            return hoursReported * costPerHour + extraHours * (costPerHour * 1.3);
        }
    }
}

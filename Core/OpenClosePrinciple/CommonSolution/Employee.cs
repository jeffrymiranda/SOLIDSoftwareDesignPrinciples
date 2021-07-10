namespace Core.OpenClosePrinciple.CommonSolution
{
    public class Employee
    {
        #region miscellaneous
        private const int WeeklyHours = 40;
        private readonly string fullName;
        private readonly string role;
        private readonly double costPerHour;
        private readonly int hoursReported;

        public Employee(string fullName, string role, double costPerHour, int hoursReported)
        {
            this.fullName = fullName;
            this.role = role;
            this.costPerHour = costPerHour;
            this.hoursReported = hoursReported;
        }

        public string GetFullName()
        {
            return fullName;
        }
        #endregion 

        /// <summary>
        /// This method is intelligent enough to calculate the weekly salary for the contractor, support and regular employees.
        /// Notice that the extra hour(s) for contractors have the same cost.
        /// </summary>
        /// <returns></returns>
        public double CalculateWeeklySalary()
        {
            int extraHours = (hoursReported > WeeklyHours) ? hoursReported - WeeklyHours : 0;
            return role switch
            {
                "Contractor" => hoursReported * costPerHour,
                "Support" => hoursReported * costPerHour + extraHours * (costPerHour * 1.5),
                _ => hoursReported * costPerHour + extraHours * (costPerHour * 1.3),
            };
        }
    }
}
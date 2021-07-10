namespace Core.OpenClosePrinciple.CommonSolution.Domain
{
    public class Support : Employee
    {
        #region Constructor

        public Support(string fullName, double costPerHour, int hoursReported)
            : base(fullName, costPerHour, hoursReported) { }

        #endregion
    }
}
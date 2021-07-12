using Core.LiskovSubstitutionPrinciple.SOLIDSolution.Domain;

namespace Core.LiskovSubstitutionPrinciple.SOLIDSolution.Service
{
    public interface IPayroll
    {
        public void PrintWeeklyPayroll(Employee employee);
    }
}

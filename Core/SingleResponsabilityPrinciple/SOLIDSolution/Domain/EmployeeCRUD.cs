namespace Core.SingleResponsabilityPrinciple.SOLIDSolution.Domain
{
    public class EmployeeCRUD
    {
        EmployeeList _list;
        public EmployeeCRUD(EmployeeList list)
        {
            _list = list;
        }

        public bool InsertEmployee(Employee employee)
        {
            _list.employeeList.Add(employee);
            return true;
        }
    }
}

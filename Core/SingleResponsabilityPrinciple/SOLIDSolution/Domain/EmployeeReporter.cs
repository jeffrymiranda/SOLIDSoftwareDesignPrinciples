using System;

namespace Core.SingleResponsabilityPrinciple.SOLIDSolution.Domain
{
    public class EmployeeReporter
    {
        EmployeeList _list;
        public EmployeeReporter(EmployeeList list)
        {
            _list = list;
        }

        public void GenerateReport()
        {
            foreach (Employee e in _list.employeeList)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("=     Employee Report     =");
                Console.WriteLine("===========================");
                Console.WriteLine("Employee ID: " + e.EmployeeID);
                Console.WriteLine("Employee Name: " + e.EmployeeName);
                Console.WriteLine("===========================");
            }
        }
    }
}

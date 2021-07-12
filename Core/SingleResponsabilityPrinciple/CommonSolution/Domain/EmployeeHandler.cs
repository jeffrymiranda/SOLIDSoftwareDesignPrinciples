using System;
using System.Collections.Generic;

namespace Core.SingleResponsabilityPrinciple.CommonSolution.Domain
{
    public class EmployeeHandler
    {
        private List<Employee> EmployeeList;

        public EmployeeHandler()
        {
            EmployeeList = new List<Employee>();
        }
        public bool InsertEmployee(Employee employee)
        {
            EmployeeList.Add(employee);
            return true;
        }
        public void GenerateReport()
        {
            foreach (Employee e in EmployeeList)
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

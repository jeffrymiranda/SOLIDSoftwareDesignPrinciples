using Core.SingleResponsabilityPrinciple.CommonSolution.Domain;
using System;

namespace Core.SingleResponsabilityPrinciple.CommonSolution.Service
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class EmployeeProcessor
    {
        private EmployeeHandler employeeHandler = new EmployeeHandler();


        public bool insertEmployee(int ID, string Name)
        {
            bool inserted = false;
            try
            {
                Employee employee = new Employee { EmployeeID = ID, EmployeeName = Name };
                employeeHandler.InsertEmployee(employee);
                inserted = true;
            }
            catch (Exception e)
            {
                inserted = false;
            }

            return inserted;
        }

        public void printReport()
        {
            employeeHandler.GenerateReport();
        }
    }
}


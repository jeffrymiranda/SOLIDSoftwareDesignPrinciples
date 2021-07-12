using Core.SingleResponsabilityPrinciple.CommonSolution.Domain;
using System;

namespace Core.SingleResponsabilityPrinciple.SOLIDSolution.Service
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class EmployeeProcessor
    {
        private EmployeeHandler EmployeeHandler = new EmployeeHandler();


        public bool insertEmployee(int ID, string Name)
        {
            bool inserted = false;
            try
            {
                var employee = new Employee { EmployeeID = ID, EmployeeName = Name };
                EmployeeHandler.InsertEmployee(employee);
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
            EmployeeHandler.GenerateReport();
        }
    }
}


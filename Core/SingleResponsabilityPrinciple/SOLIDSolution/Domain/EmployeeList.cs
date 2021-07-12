using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SingleResponsabilityPrinciple.SOLIDSolution.Domain
{
    public class EmployeeList
    {
        public List<Employee> employeeList;

        public EmployeeList()
        {
            employeeList = new List<Employee>();
        }
    }
}

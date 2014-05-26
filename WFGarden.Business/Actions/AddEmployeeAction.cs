using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFGarden.Data;

namespace WFGarden.Business.Actions
{
    public static class AddEmployeeAction
    {
        public static void Execute(Employee employee)
        {
            employee.EmployeId = 500;
            EmployeeManager.Employees.Add(employee);
        }
    }
}

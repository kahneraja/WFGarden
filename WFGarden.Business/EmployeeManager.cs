using System;
using System.Activities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFGarden.Data;

namespace WFGarden.Business
{
    public static class EmployeeManager
    {
        public static List<Employee> Employees { get; set; }

        public static void AddEmployee(Employee employee)
        {
            var result = WorkflowInvoker.Invoke(new Workflows.AddNewEmployee(), new Dictionary<string, object> { { "Employee", employee } });

            Trace.WriteLine(employee.EmployeId);

        }
    }
}

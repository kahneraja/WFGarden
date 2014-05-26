using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WFGarden.Business;
using WFGarden.Data;
using System.Collections.Generic;

namespace WFGarden.Testing
{
    [TestClass]
    public class EmployeeTests
    {
        [TestInitialize]
        public void Init()
        {
            EmployeeManager.Employees = new List<Employee>();
        }

        [TestMethod]
        public void TestAddEmployee()
        {
            var employee = new Employee(){ EmployeId = 1, Name = "John"};
            EmployeeManager.AddEmployee(employee);
        }
    }
}

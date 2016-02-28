using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ntier_demo
{

    
    public class EmployeeHandler
    {
        EmployeeDBAccess emp_DB_Access = null;


        public EmployeeHandler()
        {
            emp_DB_Access = new EmployeeDBAccess();
        }

        public List<Employee> GetEmployeeList()
        {
            return emp_DB_Access.GetEmployeeList();
        }

        public bool UpdateEmployee(Employee emp)
        {
            return emp_DB_Access.UpdateEmployee(emp);
        }

        public Employee GetEmployeeDetails(Employee emp)
        {
            return emp_DB_Access.GetEmployeeDetails(emp.EmployeeID);
        }


        public bool DeleteEmployee(int empID)
        {
            return emp_DB_Access.DeleteEmployee(empID);
        }

        public bool AddNewEmployee(Employee emp)
        {
            return emp_DB_Access.AddNewEmployee(emp);
        }
    }
}
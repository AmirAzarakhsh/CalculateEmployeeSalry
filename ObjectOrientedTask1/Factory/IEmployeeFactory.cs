using ObjectOrientedTask1.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ObjectOrientedTask1.Employees.Employee;

namespace ObjectOrientedTask1.Factory
{
    interface IEmployeeFactory
    {
        Employee CreateEmployee(EmployeeType type  , string fname
            , string lname
            , string nationalId
            , int level, decimal baseSalary, decimal totalHours, decimal extraHours = 0 );
    }
}

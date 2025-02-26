using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedTask1.Employees;

public class DepartmentManager : Employee
{
        public DepartmentManager(string fname, string lname, string nationalId, decimal basesalary) : base(fname, lname, nationalId)
        {
        }
        internal override decimal CalculateSalary(int level, decimal baseSalary, decimal totalHours, decimal extraHours, decimal employeeRatio =2)
        {
                return base.CalculateSalary(level, baseSalary, totalHours, extraHours, employeeRatio);
        }
}

using ObjectOrientedTask1.Employees;
using ObjectOrientedTask1.Validators;
using static ObjectOrientedTask1.Employees.Employee;

namespace ObjectOrientedTask1.Factory
{
    class EmployeeFactory : IEmployeeFactory
    {

        public Employee CreateEmployee(EmployeeType type, string fname, string lname, string nationalId, int level, decimal baseSalary, decimal totalHours, decimal extraHours = 0 )
        {
            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(fname))
                throw new ArgumentException("First or Lastname cannot be null");

            if (!NationalCodeValidator.validate(nationalId))
                throw new ArgumentException("National Code isn't valid ,\nPlease enter correct national code");

            BaseSalaryValidator.BaseSalaryValid(baseSalary, type);
                
            
            
            return type switch
            {
                EmployeeType.SimpleEmployee => new SimpleEmployee(fname, lname, nationalId, level, baseSalary, totalHours, extraHours),
                EmployeeType.SeniorEmployee => new SeniorEmployee(fname, lname, nationalId, level, baseSalary, totalHours, extraHours),
                EmployeeType.Deputy => new SectionManager(fname, lname, nationalId, level, baseSalary, totalHours, extraHours),
                EmployeeType.DepartmentManager => new DepartmentManager(fname, lname, nationalId, level, baseSalary, totalHours, extraHours),
                EmployeeType.SectionManager => new SectionManager(fname, lname, nationalId, level, baseSalary, totalHours, extraHours),
                EmployeeType.CEO => new CEO(fname, lname, nationalId, level, baseSalary, totalHours, extraHours),

                _ => throw new ArgumentException("type of Employee is invalid.")
            };
        }
    }
}

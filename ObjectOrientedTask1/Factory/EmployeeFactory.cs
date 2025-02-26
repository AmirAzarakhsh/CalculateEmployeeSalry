using ObjectOrientedTask1.Employees;
using ObjectOrientedTask1.Validators;
using static ObjectOrientedTask1.Employees.Employee;

namespace ObjectOrientedTask1.Factory;


class EmployeeFactory : IEmployeeFactory
{
    public Employee CreateEmployee(EmployeeType type, string fname, string lname, string nationalId, decimal baseSalary)
    {
        if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname))
            throw new ArgumentException("First or Lastname cannot be null");

        if (!NationalCodeValidator.validate(nationalId))
            throw new ArgumentException("National Id Isn't Valid");

        BaseSalaryValidator.BaseSalaryValid(baseSalary, type);

        return type switch
        {
            EmployeeType.SimpleEmployee => new SimpleEmployee(fname, lname, nationalId, baseSalary)
            {
                FullName = $"{fname} {lname}",
                NationalCode = nationalId,
            },
            EmployeeType.SeniorEmployee => new SeniorEmployee(fname,lname, nationalId, baseSalary)
            {
                FullName = $"{fname} {lname}",
                NationalCode = nationalId
            },
            EmployeeType.Deputy => new Deputy(fname, lname, nationalId, baseSalary)
            {
                FullName = $"{fname} {lname}",
                NationalCode = nationalId
            },
            EmployeeType.DepartmentManager => new DepartmentManager(fname, lname, nationalId, baseSalary)
            {
                FullName = $"{fname} {lname}",
                NationalCode = nationalId
            },
            EmployeeType.SectionManager => new SectionManager(fname, lname, nationalId, baseSalary)
            {
                FullName = $"{fname} {lname}",
                NationalCode = nationalId
            },
            EmployeeType.CEO => new CEO(fname, lname, nationalId, baseSalary)
            {
                FullName = $"{fname} {lname}",
                NationalCode = nationalId
            },
            _ => throw new ArgumentException("type of Employee is invalid.")
        };
    }
}

using ObjectOrientedTask1.Emplyees;
using static ObjectOrientedTask1.Emplyees.Employee;

namespace ConsoleApp1.Factory;

interface IEmployeeFactory
{
    Employee CreateEmployee(EmployeeType type, string fname
        , string lname
        , string nationalId
        , decimal baseSalary);
}


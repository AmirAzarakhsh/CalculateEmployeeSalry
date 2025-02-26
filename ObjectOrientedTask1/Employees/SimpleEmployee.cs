namespace ObjectOrientedTask1.Employees;

public class SimpleEmployee : Employee
{
    public SimpleEmployee(string fname, string lname, string nationalId,decimal basesalary) : base(fname, lname, nationalId)
    {
    }
    internal override decimal CalculateSalary(int level, decimal baseSalary, decimal totalHours, decimal extraHours, decimal employeeRatio = 1)
    {
        return base.CalculateSalary(level, baseSalary, totalHours, extraHours, employeeRatio );
    }
}

namespace ObjectOrientedTask1.Employees;

public class SectionManager : Employee
{
    public SectionManager(string fname, string lname, string nationalId, decimal basesalary) : base(fname, lname, nationalId)
    {
    }
    internal override decimal CalculateSalary(int level, decimal baseSalary, decimal totalHours, decimal extraHours, decimal employeeRatio = 1.5m)
    {
        return base.CalculateSalary(level, baseSalary, totalHours, extraHours, employeeRatio);
    }
}


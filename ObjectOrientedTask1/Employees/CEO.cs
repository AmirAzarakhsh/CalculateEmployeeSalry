namespace ObjectOrientedTask1.Employees;


 class CEO : Employee
{
    public CEO(string fname, string lname, string nationalId , decimal baseSalary) : base(fname, lname, nationalId)
    {
    }
        
    internal override decimal CalculateSalary(int level, decimal baseSalary, decimal totalHours, decimal extraHours, decimal employeeRatio = 3)
    {
        return base.CalculateSalary(level, baseSalary, totalHours, extraHours, employeeRatio);
    }
}


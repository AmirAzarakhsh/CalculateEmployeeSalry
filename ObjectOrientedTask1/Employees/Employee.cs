
namespace ObjectOrientedTask1.Employees
{
    public abstract class Employee
{
    protected Employee(string fname
       , string lname
       , string nationalId
       )
    {
        FullName = $"{fname} {lname}";

        NationalCode = nationalId;
        
    }


    public string FullName { get; set; }
    public required string NationalCode { get; set; }
    public decimal ExtraTimePerHours { get; set; }
    public decimal TotalHourInMonth { get; set; }
    public decimal BaseSalary { get; set; }
    public int Level { get; set; }
    protected decimal EmployeeRatio { get; set; }

    public enum EmployeeType
    {
        SimpleEmployee,
        SeniorEmployee,
        Deputy,
        DepartmentManager,
        CEO,
        SectionManager
    }

    internal virtual decimal CalculateSalary(int level
        , decimal baseSalary, decimal totalHours, decimal extraHours, decimal employeeRatio = 1)
    {
        decimal salary = baseSalary * (1 + level / 10) * employeeRatio * totalHours;
        decimal Extra = baseSalary * extraHours * (1 + level / 10) * employeeRatio * 1.2m;
        return salary + Extra;
    }
    public override string ToString()
    {
        return $"FullName : {FullName}\nNationalId : {NationalCode}";
    }
}

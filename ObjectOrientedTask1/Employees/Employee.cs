
namespace ObjectOrientedTask1.Employees
{
    public abstract class Employee
    {
        protected Employee(string fname
            , string lname
            , string nationalId
            , int level, decimal baseSalary, decimal totalHours, decimal extraHours, decimal employeeRatio)
        {
            FullName = $"{fname} {lname}";
            NationalCode = nationalId;
            Level = level;
            BaseSalary = baseSalary;
            TotalHourInMonth = totalHours;
            ExtraTimePerHours = extraHours;
            EmployeeRatio = employeeRatio;
        }


        public string FullName { get; }
        public  string NationalCode { get; init; }
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

        internal abstract decimal CalculateSalary();
    }
}

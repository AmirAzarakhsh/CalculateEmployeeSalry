using static ObjectOrientedTask1.Employees.Employee;

namespace ObjectOrientedTask1.Validators
{
    public static class BaseSalaryValidator
    {

        public static void BaseSalaryValid(decimal BaseSalary, EmployeeType type)
        {
            decimal minSalary = GetMinSalary(type);
            decimal maxSalary = GetMaxSalary(type);
            if (BaseSalary < minSalary)
            {
                throw new OverflowException("Base Salary Is Less than Minimum Range");

            }
            if (BaseSalary > maxSalary)
            {
                throw new OverflowException("Base Salary is more than Maximum Range");
            }

        }

        private static decimal GetMaxSalary(EmployeeType type)
        {
            return type switch
            {
                EmployeeType.SimpleEmployee => 1000,
                EmployeeType.SeniorEmployee => 1300,
                EmployeeType.SectionManager => 1500,
                EmployeeType.DepartmentManager => 1800,
                EmployeeType.Deputy => 2200,
                EmployeeType.CEO => 3000,
                _ => throw new ArgumentException("Your employee type Is Not valid")
            };
        }

        private static decimal GetMinSalary(EmployeeType type)
        {
            return type switch
            {
                EmployeeType.SimpleEmployee => 100,
                EmployeeType.SeniorEmployee => 130,
                EmployeeType.SectionManager => 150,
                EmployeeType.DepartmentManager => 180,
                EmployeeType.Deputy => 220,
                EmployeeType.CEO => 300,
                _ => throw new ArgumentException("Your employee type Is Not valid")
            };
        }
    }
}

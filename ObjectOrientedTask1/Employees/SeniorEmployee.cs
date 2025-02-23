﻿namespace ObjectOrientedTask1.Employees
{
    public class SeniorEmployee : Employee
    {
        public SeniorEmployee(string fname, string lname, string nationalId, int level, decimal baseSalary, 
            decimal totalHours, decimal extraHours, decimal employeeRatio = 1.2m) : base(fname, lname, nationalId, level, baseSalary, totalHours, extraHours, employeeRatio)
        {
            this.BaseSalary = baseSalary;
            this.Level = level;
            this.EmployeeRatio = employeeRatio;
            this.TotalHourInMonth = totalHours;
            this.ExtraTimePerHours = extraHours;
        }


        internal override decimal CalculateSalary()
        {
            decimal salary = BaseSalary * Level * EmployeeRatio * TotalHourInMonth;
            decimal Extra = BaseSalary * ExtraTimePerHours * Level * EmployeeRatio * 1.2m;

            return salary + Extra;
        }
    }
}

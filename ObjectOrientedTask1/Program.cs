
using ObjectOrientedTask1.Employees;
using ObjectOrientedTask1.Factory;
using static ObjectOrientedTask1.Employees.Employee;

try
{
    IEmployeeFactory employeeFactory = new EmployeeFactory();


    var employee = employeeFactory.CreateEmployee(EmployeeType.CEO
        , "Amirhossein", "Azarakhsh"
        , nationalId: "0200468529"
        , level: 1, baseSalary: 300, totalHours: 160,
          extraHours: 6);


    decimal salary = employee.CalculateSalary();


    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"FullName: {employee.FullName} ");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"National code:{employee.NationalCode} ");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Salary: {salary:C0}");
    Console.ResetColor();

}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Exception :{ex.Message}");
    Console.ResetColor();

}

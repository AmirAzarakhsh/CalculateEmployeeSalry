
using ObjectOrientedTask1.Factory;
using static ObjectOrientedTask1.Emplyees.Employee;

try
{
    IEmployeeFactory employeeFactory = new EmployeeFactory();


    var employee = employeeFactory.CreateEmployee(EmployeeType.SimpleEmployee
        , "Amirhossein", "Azarakhsh"
        , nationalId: "0200468529"
        ,  baseSalary: 30);


    decimal salary = employee.CalculateSalary( level: 1,baseSalary: 30,totalHours: 160,extraHours: 6 );


    
    Console.WriteLine(employee);

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Salary: {salary:C0}");
    Console.ResetColor();
    Console.ReadKey();

}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Exception :{ex.Message}");
    Console.ResetColor();

}

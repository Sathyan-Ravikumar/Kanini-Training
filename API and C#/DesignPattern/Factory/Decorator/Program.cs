using Decorator;

class Program
{
    static void Main(string[] args)
    {
        IEmployeeDetails employee = new BasicEmployeeDetails("John Doe");

        employee = new PositionDecorator(employee, "Manager");
        employee = new SalaryDecorator(employee, 5000);

        Console.WriteLine(employee.GetDetails());
    }
}

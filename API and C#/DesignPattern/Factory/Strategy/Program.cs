using Strategy;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee
        {
            Name = "John Doe",
            Department = "Sales",
            Position = "Manager",
            Salary = 5000
        };

        employee.SetDetailsStrategy(new BasicDetailsStrategy());
        employee.DisplayDetails();

        Console.WriteLine();

        employee.SetDetailsStrategy(new FullDetailsStrategy());
        employee.DisplayDetails();
    }
}

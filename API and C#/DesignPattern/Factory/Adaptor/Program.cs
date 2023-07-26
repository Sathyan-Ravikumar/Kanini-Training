using Adaptor;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee
        {
            Name = "John Doe",
            JobTitle = "Manager",
            Salary = 5000
        };

        EmployeeAdapter adapter = new EmployeeAdapter(employee);

        EmployeeInfoPrinter infoPrinter = new EmployeeInfoPrinter();
        infoPrinter.PrintEmployeeDetails(adapter);
    }
}

using Command;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee { Name = "John Doe", Department = "Sales" };
        Employee employee2 = new Employee { Name = "Jane Smith", Department = "Marketing" };

        EmployeeManager manager = new EmployeeManager();

        // Change department commands
        ICommand command1 = new ChangedDepartmentCommand(employee1, "IT");
        ICommand command2 = new ChangedDepartmentCommand(employee2, "Finance");

        manager.AddCommand(command1);
        manager.AddCommand(command2);

        // Process commands
        manager.ProcessCommands();

        // Undo commands
        manager.UndoCommands();
    }
}

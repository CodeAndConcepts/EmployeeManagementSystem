using EmployeeManagementSystem.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> employess = new List<Employee>();
        
        Developer developer = new Developer();
        developer.Name = "Alice (Developer)";
        developer.ProgrammingLanguage = "C#";
        
        employess.Add(developer);

        Manager manager = new Manager();
        manager.Name = "Bob (Manager)";
        manager.TeamSize = 5;

        employess.Add(manager);

        Intern intern = new Intern();
        intern.Name = "Carol (Intern)";
        intern.MentorName = "Bob";

        employess.Add(intern);

        Console.WriteLine("Employee List:");
        Console.WriteLine("--------------");
        foreach (Employee employee in employess)
        {
            employee.CalculateSalary();
            employee.DisplayInfo();
            Console.WriteLine();
        }

    }
}
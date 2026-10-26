class Program
{
    static void Main(string[] args)
    {
        Employee[] employees =
        {
            new Manager(1, "John", "Rogers", "CEO", new DateTime(2026, 10, 26), 10000, 12, 0.33m),
            new Developer(2, "Serenity", "Rune", "Music", new DateTime(2026, 10, 26), 7500, "C#", 6, "mid"),
            new SalesPerson(3, "Sofia", "Martinez", "Promotional", new DateTime(2026, 10, 26), 5000, 250000, 100000, 0.66m),
        };
        Console.WriteLine("++++++++++++++++++++++++++");
        Console.WriteLine("Rune Industries Employee Management System");
        Console.WriteLine("++++++++++++++++++++++++++");
        foreach(Employee employee in employees)
        {
            ProcessEmployee(employee);
        }
        Console.WriteLine($"Total Payroll: {CalculateTotalPayroll(employees):C}");
    }
    static void ProcessEmployee(Employee emp)
    {
        Console.WriteLine(emp.GenerateReport());
        Console.WriteLine($"Annual salary: {emp.CalculateAnnualSalary():C}");
        Console.WriteLine($"Performance: {emp.EvaluatePerformance()}");
        Console.WriteLine("++++++++++++++++++++++++++");
    }
    static double CalculateTotalPayroll(Employee[] employees)
    {
        double total = 0;
        foreach(Employee employee in employees)
        {
            total += employee.CalculateAnnualSalary();
        }
        return total;
    }
}

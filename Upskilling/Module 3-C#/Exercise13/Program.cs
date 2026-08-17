using System;

Employee emp1 = new Employee { Name = "Alice", Role = "Developer" };
Console.WriteLine("Original: " + emp1.Name + " - " + emp1.Role);

Employee emp2 = emp1 with { Role = "Manager" };
Console.WriteLine("Modified copy: " + emp2.Name + " - " + emp2.Role);

Console.WriteLine("Original after: " + emp1.Name + " - " + emp1.Role);

record Employee
{
    public string Name { get; init; }
    public string Role { get; init; }
}
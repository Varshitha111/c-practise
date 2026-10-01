using System;

class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public virtual void ShowDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
    }
}

class Manager : Employee
{
    public int TeamSize { get; set; }

    public override void ShowDetails()
    {
        base.ShowDetails();

        Console.WriteLine($"Team size: {TeamSize}");
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager
        {
            Name = "Priya",
            Salary = 90000,
            TeamSize = 6
        };

        manager.ShowDetails();
    }
}
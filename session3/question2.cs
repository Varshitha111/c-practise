using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{Name}, {Age}");
    }
}

class Student : Person
{
    public string RollNumber { get; set; }

    public Student(string name, int age, string rollNumber)
        : base(name, age)
    {
        RollNumber = rollNumber;
    }
}

class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Amit", 20, "S101");
        Teacher teacher = new Teacher("Priya", 35, "C#");

        student.ShowDetails();
        teacher.ShowDetails();
    }
}
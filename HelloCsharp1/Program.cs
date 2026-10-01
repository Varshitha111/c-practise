// Console.WriteLine("Hello, World!");
using System;
public class Person
{
    public string Name {get;set;}
    public int Age{get;set;}
    public void ShowDetails()
    {
        Console.WriteLine($"{Name},{Age}");
    }

} 
public class Student:Person
{
    public string RollNumber {get;set;}
}
public class Teacher : Person
{
    public string Subject{get;set;}
}
class Program
{
    static void Main()
    {
        Student s1 = new Student();

        s1.Name = "Varshitha";
        s1.Age = 22;
        s1.RollNumber = "S101";

        s1.ShowDetails();
        Console.WriteLine(s1.RollNumber);


        Teacher t1 = new Teacher();

        t1.Name = "John";
        t1.Age = 35;
        t1.Subject = "C#";

        t1.ShowDetails();
        Console.WriteLine(t1.Subject);
    }
}
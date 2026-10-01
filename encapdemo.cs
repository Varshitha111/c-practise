using System;

class Student
{
    private int _marks;

    public int Marks
    {
        get
        {
            return _marks;
        }

        set
        {
            if (value >= 0 && value <= 100)
            {
                _marks = value;
            }
            else
            {
                Console.WriteLine("Invalid marks");
            }
        }
    }

    public void Display()
    {
        Console.WriteLine($"Marks: {Marks}");
    }

    static void Main()
    {
        Student s1 = new Student();

        s1.Marks = 85;
        s1.Display();

        s1.Marks = 120;
        s1.Display();
    }
}
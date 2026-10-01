using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Some sound");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow");
    }
}

class Cow : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Moo");
    }
}

class Program
{
    static void MakeItSpeak(Animal animal)
    {
        animal.Speak();
    }

    static void Main()
    {
        MakeItSpeak(new Dog());
        MakeItSpeak(new Cat());
        MakeItSpeak(new Cow());
    }
}
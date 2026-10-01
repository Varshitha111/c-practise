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

    public void Fetch()
    {
        Console.WriteLine("Rex is fetching");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main()
    {
        Animal[] animals =
        {
            new Dog(),
            new Cat(),
            new Animal()
        };

        foreach (Animal animal in animals)
        {
            animal.Speak();

            if (animal is Dog dog)
            {
                dog.Fetch();
            }
        }
    }
}
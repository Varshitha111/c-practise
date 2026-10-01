using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Price}";
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 55000 },
            new Product { Name = "Mouse", Price = 700 },
            new Product { Name = "Monitor", Price = 12000 }
        };

        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
}
using System;
namespace ClassName
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1=new Employee("varshini");
            Console.WriteLine(e1.Name);
            Console.WriteLine(e1.Salary);//if salary is decimal then default value is 0
            Console.WriteLine();
 
            Employee e2=new Employee("varshini",10000);
            Console.WriteLine(e2.Name);
            Console.WriteLine(e2.Salary);
 
        }
    public class Employee
    {
        public string Name;
        public decimal Salary;
        public Employee(string name)
        {
            Name=name;
        }
        public Employee(string name, decimal salary)
            {
                Name=name;
                Salary=salary;
            }
    }
    }
}
 
 
 
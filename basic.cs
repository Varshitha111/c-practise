// Console.WriteLine("Hello, World!");
// Name: Amit Sharma
// Age: 20
// CGPA: 8.75
// Enrolled: True
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net.Mail;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Enter your name, age, CGPA and enrolled status (true/false):");
        // string name=Console.ReadLine();
        // int age=int.Parse(Console.ReadLine());
        // float cgpa=float.Parse(Console.ReadLine());
        // bool enrolled=bool.Parse(Console.ReadLine());
        // Console.WriteLine("Name: "+name);
        // Console.WriteLine("Age: "+age);
        // Console.WriteLine("CGPA: "+cgpa);
        // Console.WriteLine("Enrolled: "+enrolled);
        // int l=int.Parse(Console.ReadLine());
        // int b=int.Parse(Console.ReadLine());
        // Console.WriteLine($"{2*(l+b)}");
        // int a=2,b=3,temp;
        // temp=a;
        // a=b;
        // b=temp;
        // Console.WriteLine($"a={a} b={b}");
        // int s1=100,s2=50,s3=70;
        // Console.WriteLine($"{(s1+s2+s3)/3}");
        // Console.Write("Enter seconds: ");
        // int num=int.Parse(Console.ReadLine());
        // int rem,hrs,min,secs;
        // hrs=num/3600;
        // num%=3600;
        // min=num/60;
        // num%=60;
        // secs=num;
        // Console.WriteLine($"{hrs}:{min}:{secs}");
        // Console.Write("Enter a number: ");
        //         try
        //         {
        //             int num=int.Parse(Console.ReadLine());
        //         }
        //         catch(FormatException e)
        //         {
        //             Console.WriteLine("Invalid input. Please enter a valid integer.");
        //         }
        // Console.Write("Enter a number: ");
        // int num=int.Parse(Console.ReadLine());
        // if(num%2==0) Console.WriteLine("Even");
        // else Console.WriteLine("Odd");
        // int rem,i=0;
        // Console.Write("enter 3 numbers");
        // string[] numbers = Console.ReadLine().Split();

        // int a = int.Parse(numbers[0]);
        // int b = int.Parse(numbers[1]);
        // int c = int.Parse(numbers[2]);
        // if (a>b && a>c){
        //     Console.WriteLine(a);
        // }
        // else if(b>c) {
        //     Console.WriteLine(b);
        // }
        // else{
        //     Console.WriteLine(c);
        // }
        // int marks=int.Parse(Console.ReadLine());
        // if (marks>90) Console.WriteLine("A");
        // else if(marks<=89 && marks>=75) Console.WriteLine("B");
        // else if(marks<=74 && marks>=60) Console.WriteLine("c");
        // else if(marks<=59 && marks>=40) Console.WriteLine("d");
        // else Console.WriteLine("Fail");

        // int year=int.Parse(Console.ReadLine());
        // if(year%4==0 && year%100!=0 || year%400==0) Console.WriteLine("Leap Year");
        // int number=int.Parse(Console.ReadLine());
        // string op=Console.ReadLine();
        //         switch (op)
        //         {
        //             case "+":
        //                 Console.WriteLine(number+number);
        //                 break;
        //             case "-":
        //                 Console.WriteLine(number-number);
        //                 break;
        //             case "*":
        //                 Console.WriteLine(number*number);
        //                 break;
        //             case "/":
        //                 Console.WriteLine(number/number);
        //                 break;
        //             default:
        //                 Console.WriteLine("Invalid operator");
        //                 break;
        //         }
        // int units=int.Parse(Console.ReadLine());
        // double bill=0;
        //         while (units > 0)
        //         {
        //             if(units>200)
        //             {
        //                 bill+=100*5;
        //                 units-=100;
        //                 bill+=100*7;
        //                 units-=100;
        //                 bill+=units*10;
        //             }
        //             else if(units>100)
        //             {
        //                 bill+=100*5;
        //                 units-=100;
        //                 bill+=units*7;
        //             }
        //             else
        //             {
        //                 bill+=units*5;
        //                 units=0;
        //             }
        //         }
        // int num=int.Parse(Console.ReadLine());
        // int fact=1;
        // while (num > 0)
        //         {
        //             fact*=num;
        //             num--;
        //         }
        //         Console.WriteLine(fact);
        // int revnum=0,rem,num=1234,count=0;
        //         while (num > 0)
        //         {
        //             // rem=num%10;
        //             // revnum=revnum*10+rem;
        //             num/=10;
        //             count++;
        //         }
        //         Console.WriteLine(count);
        // int choice;
        // do
        // {
        //     Console.WriteLine("1.deposit\n2.withdraw\n3.balance\n4.exit");
        //     choice=int.Parse(Console.ReadLine());
        //     if (choice==4) Console.WriteLine("goodbye");
        // } while(choice!=4);
        // for(int i = 0; i < 5; i++)
        // {
        //     for(int j = 0; j <= i; j++)
        //     {
        //         Console.Write("*");
        //     }
        //     Console.WriteLine();
        // }
        
        // int[] arr=[1,2,3,4];
        // int max=arr[0];
        // for(int i = 0; i < 4; i++)
        // {
        //     if (arr[i] > max)
        //     {
        //         max=arr[i];
        //     }   
        // }
        // Console.WriteLine(max);
        // int count=0;
        // // string vow="aeiouAEIOU";
        // string word="varshitha";
        // foreach(char ch in word)
        // {
        //     if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        //     {
        //         count++;
        //     }
        // }
        // Console.WriteLine(count);
        // int Sum=0;
        // int[] nums=[1,2,3,4];
        // for(int i = 0; i <= nums.Length-1; i++)
        // {
        //     if (i<0) break;
        //     Sum+=nums[i];
        //     // else Console.WriteLine(i);
        // }
        //             Console.WriteLine(Sum);
        // int num=14,count=0;
        // for(int i = 1; i < num; i++)
        // {
        //     if (num%i==0) count++;

        // }
        //             if (count==2) Console.WriteLine("Prime");
        //     else Console.WriteLine("not Prime");
        // string password="Hi",guess;
        // for(int i = 0; i <=3; i++)
        // {
        //     if (i>=3) {
        //         Console.WriteLine("number of attempts exceeded");
        //         break;
        //     }
        //     Console.WriteLine($"attempt {i}");
        //     guess=Console.ReadLine();
        //     if (guess!=password) Console.WriteLine("wrong password");
        //     else break;
        // }
        // int[] nums=[1,2,3,4];
        // int sum=0,skipped=0;
        // foreach(int num in nums)
        // {
        //     if(num>0) sum+=num;
        //     else {
        //         skipped++;
        //         continue;
        // }
        // }
        // Console.WriteLine(sum);
        // Console.WriteLine(skipped);
        for(int i = 2; i <= 100; i++)
        {
            if(i%5==0 && i%7==0) {
                Console.WriteLine(i);
                break;
            }
        }
    }
}

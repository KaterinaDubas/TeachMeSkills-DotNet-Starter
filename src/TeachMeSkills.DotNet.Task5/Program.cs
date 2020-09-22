using System;

namespace TeachMeSkills.DotNet.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of variable a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of variable b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"a + b =  {a+b}");
            Console.WriteLine($"a - b =  {a-b}");
            Console.WriteLine($"a * b =  {a*b}");
            Console.WriteLine($"a / b =  {a/b}");
            Console.ReadKey();
        }
    }
}

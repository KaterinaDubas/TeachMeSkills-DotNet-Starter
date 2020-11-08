using System;

namespace TeachMeSkills.DotNet.Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three integers");
            Console.Write("First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            double result = Calculate(num1, num2, num3);
            Console.WriteLine($"Average = {result}");

        }

        static double Calculate(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }
    }
}

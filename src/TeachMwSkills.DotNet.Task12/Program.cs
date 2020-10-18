using System;

namespace TeachMwSkills.DotNet.Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B (shoud be bigger than A): ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.Write("Odd numbers: ");
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write($"{i},");
                }
                sum += i;
            }
            Console.WriteLine($"\nSum of numbers between A and B = {sum}");
            Console.ReadKey();
        }
    }
}

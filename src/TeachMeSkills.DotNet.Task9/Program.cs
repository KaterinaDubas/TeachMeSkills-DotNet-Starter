using System;

namespace TeachMeSkills.DotNet.Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string a = Console.ReadLine();
            int number = int.Parse(a);
            int result;
            int resedue = Math.DivRem(number, 2, out result);
            if (result == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }

            Console.Write("Enter a number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}

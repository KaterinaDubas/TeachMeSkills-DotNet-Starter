using System;

namespace TeachMeSkills.DotNet.Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some number: ");
            int x = int.Parse(Console.ReadLine());
            NumbersCheker(x);
            Console.ReadKey();
        }

        public static void NumbersCheker(int x)
        {
            bool prime = true;
            if (x >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

            for(int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    prime = false;
                    Console.WriteLine("The number is not prime");
                    break;
                }
                else
                {
                    Console.WriteLine("The number is prime");
                    break;
                }
            }

            if (x % 2 == 0 && x % 3 == 0 && x % 5 == 0 && x % 6 == 0 && x % 9 == 0)
            {
                Console.WriteLine("The number is divided without remainder by 2, 3, 5, 6 and 9.");
            }
            else
            {
                Console.WriteLine("The number isn't divisible by 2, 3, 5, 6, 9 without remainder.");
            }
        }
    }
}

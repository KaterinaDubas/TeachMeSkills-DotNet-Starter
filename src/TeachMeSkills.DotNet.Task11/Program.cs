using System;

namespace TeachMeSkills.DotNet.Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool degree = result(number);
            if (degree == true)
            {
                Console.WriteLine("degree of 2");
            }
            else
            {
                Console.WriteLine("not degree of 2");
            }
        }

        static bool result(int number)
        {
            if (number == 2) return true;
            else if (number % 2 == 0) return result(number / 2);
            else return false;
        }
    }
}

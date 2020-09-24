using System;

namespace TeachMeSkills.DotNet.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the nuber: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0 && number <= 14)
            {
                Console.WriteLine("the entered number falls within this interval [0;14]");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine("the entered number falls within this interval [15;35]");
            }
            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine("the entered number falls within this interval [36;50]");
            }
            else if (number >= 51 && number <= 100)
            {
                Console.WriteLine("the entered number falls within this interval [51;100]");
            }
            else
            {
                Console.WriteLine("the entered number does not fall within the interval [0;100]");
            }
        }
    }
}

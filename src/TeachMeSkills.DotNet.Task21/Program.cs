using System;

namespace TeachMeSkills.DotNet.Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            var tuple = Calculate(num1, num2, num3);
            Console.WriteLine(tuple.res1);
            Console.WriteLine(tuple.res2);
            Console.WriteLine(tuple.res3);
            ;
        }

        static (double res1, double res2, double res3) Calculate(int num1, int num2, int num3)
        {
            var result = (res1: num1 / 5, res2: num2 / 5, res3: num3 / 5);
            return result;
        }
    }
}

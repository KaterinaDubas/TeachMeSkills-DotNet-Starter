using System;

namespace TeachMeSkills.DotNet.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var operand1 = 25;
            var operand2 = 5;
            Console.Write("Enter operator: ");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine($"Sum = {operand1+operand2}");
                    break;
                case "-":
                    Console.WriteLine($"Sub = {operand1-operand2}");
                    break;
                case "/":
                    if (operand2!=0)
                    {
                        Console.WriteLine($"Dev = {operand1/operand2}");
                    }
                    else
                    {
                        Console.WriteLine("Operand2 = 0");
                    }
                    break;
                case "*":
                    Console.WriteLine($"Mul = {operand1*operand2}");
                    break;
                default:
                    Console.WriteLine("Entered wrong operator!");
                    break;
            }
            Console.ReadKey();
        }
    }
}

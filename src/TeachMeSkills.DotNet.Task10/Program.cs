using System;
// Доработать. Посмотреть как сделать исключение, чтобы при неверном вводе(например буквы, а не числа) выдавало некорректный ввод
namespace TeachMeSkills.DotNet.Task10
{
    class Program  
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! If you want to know the amount of your bonus, you need to enter some information.");
            Console.Write("Salary amount: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Work experience (in years): ");
            int WorkExp = Convert.ToInt32(Console.ReadLine());

            if (WorkExp < 5)
            {
                var bonus = salary * 0.1;
                Console.WriteLine($"Your bonus = {bonus}");
            }
            else if (WorkExp >=5 && WorkExp < 10)
            {
                var bonus = salary * 0.15;
                Console.WriteLine($"Your bonus = {bonus}");
            }
            else if (WorkExp >= 10 && WorkExp < 15)
            {
                var bonus = salary * 0.25;
                Console.WriteLine($"Your bonus = {bonus}");
            }
            else if (WorkExp >= 15 && WorkExp < 20)
            {
                var bonus = salary * 0.35;
                Console.WriteLine($"Your bonus = {bonus}");
            }
            else if (WorkExp >= 20 && WorkExp < 25)
            {
                var bonus = salary * 0.45;
                Console.WriteLine($"Your bonus = {bonus}");
            }
            else if (WorkExp >= 25)
            {
                var bonus = salary * 0.50;
                Console.WriteLine($"Your bonus = {bonus}");
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
        }
    }
}

using System;

namespace TeachMeSkills.DotNet.Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose currency: 1. USD; 2. EURO; 3. RUB; 4. BEL.");
            int currency = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ammount of money: ");
            double money = Convert.ToDouble(Console.ReadLine());

            switch (currency)
            {
                case 1:
                    {
                        Console.Write($"Exchange rates: from $ to euro = ");
                        double euro = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"from $ to rub = ");
                        double rub = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"from $ to Br = ");
                        double bel = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Your sum = {money} USD = {money*euro} EUR = {money*rub} RUB = {money*bel} BEL");
                    }
                    break;
                case 2:
                    {
                        Console.Write($"Exchange rates: from euro to dollar = ");
                        double dollar = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"from euro to rub = ");
                        double rub = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"from euro to Br = ");
                        double bel = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Your sum = {money} EUR = {money * dollar} DOLLAR = {money * rub} RUB = {money * bel} BEL");
                    }
                    break;
                case 3:
                    {
                        Console.Write($"Exchange rates: from rub to dollar = ");
                        double dollar = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"from rub to euro = ");
                        double euro = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"from rub to Br = ");
                        double bel = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Your sum = {money} RUB = {money * dollar} DOLLAR = {money * euro} EURO = {money * bel} BEL");
                    }
                    break;
                case 4:
                    {
                        Console.Write($"Exchange rates: from bel to dollar = ");
                        double dollar = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"from bel to euro = ");
                        double euro = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"from bel to rub = ");
                        double rub = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Your sum = {money} BEL = {money * dollar} DOLLAR = {money * euro} EURO = {money * rub} RUB");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Incorrect input. Try one more time.");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
using System;

namespace TeachMeSkills.DotNet.Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! I can translate some words connected with weather for you.");
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            if (word == "солнце")
            {
                Console.WriteLine($"{word} - sun");
            }
            else if (word == "снег")
            {
                Console.WriteLine($"{word} - snow");
            }
            else if (word == "дождь")
            {
                Console.WriteLine($"{word} - rain");
            }
            else if (word == "ветер")
            {
                Console.WriteLine($"{word} - wind");
            }
            else if (word == "шторм")
            {
                Console.WriteLine($"{word} - storm");
            }
            else if (word == "засуха")
            {
                Console.WriteLine($"{word} - drought");
            }
            else if (word == "влажность")
            {
                Console.WriteLine($"{word} - humidity");
            }
            else if (word == "осадки")
            {
                Console.WriteLine($"{word} - precipitation");
            }
            else if (word == "жара")
            {
                Console.WriteLine($"{word} - heat");
            }
            else if (word == "облачно")
            {
                Console.WriteLine($"{word} - cloudy");
            }
            else
            {
                Console.WriteLine("Unknown word");
            }
        }
    }
}

using System;

namespace TeachMeSkills.DotNet.Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 7;
            for (int i = 0; i < y; i++)
            {
                for (int t = 0; t < x; t++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }

            int lenght = 20;
            int height = 7;
            int q = 0;
            int w = 10;
            Console.SetCursorPosition(q, w);
            for (int t = 0; t < height; t++)
            {
                for (int i = 0; i < lenght; i++)
                {
                    if (t == 0 || t == height - 1)
                    {
                        Console.Write("*");
                    }
                    else if (i == 0 || i == lenght - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

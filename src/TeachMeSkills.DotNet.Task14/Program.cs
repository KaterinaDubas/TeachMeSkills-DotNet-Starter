using System;

namespace TeachMeSkills.DotNet.Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("*");
            }
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("*");
            }
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.WriteLine("*");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(19, i);
                Console.WriteLine("*");
            }
            Console.Write("\n");

            for (int t = 0; t < 10; t++)
            {
                Console.WriteLine("*");
            }
            for (int t = 0; t < 10; t++)
            {
                Console.SetCursorPosition(t, 15);
                Console.WriteLine("*");
            }
            int x = 0;
            int y = 6;
            for (int i = 0; i < 9; i++)
            {
                x += 1;
                y += 1;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("*");
            }
            Console.Write("\n");
            int q = 6;
            int w= 16;
            for (int i = 0; i < 6; i++)
            {
                q -= 1;
                w += 1;
                Console.SetCursorPosition(q, w);
                Console.WriteLine("*");
            }
            for (int i = 0; i < 10; i++)
            {
                q += 1;
                Console.SetCursorPosition(q, w);
                Console.WriteLine("*");
            }
            for (int i = 0; i < 5; i++)
            {
                q -= 1;
                w -= 1;
                Console.SetCursorPosition(q, w);
                Console.WriteLine("*");
            }
            Console.Write("\n");
            int a = 5;
            int s = 23;
            for (int i = 0; i < 6; i++)
            {
                a += 1;
                s += 1;
                Console.SetCursorPosition(a, s);
                Console.WriteLine("*");
            }
            for (int i = 0; i < 5; i++)
            {
                a -= 1;
                s += 1;
                Console.SetCursorPosition(a, s);
                Console.WriteLine("*");
            }
            for (int i = 0; i < 5; i++)
            {
                a -= 1;
                s -= 1;
                Console.SetCursorPosition(a, s);
                Console.WriteLine("*");
            }
            for (int i = 0; i < 5; i++)
            {
                a += 1;
                s -= 1;
                Console.SetCursorPosition(a, s);
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}

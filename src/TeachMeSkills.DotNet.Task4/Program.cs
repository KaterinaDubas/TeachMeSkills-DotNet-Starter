using System;

namespace TeachMeSkills.DotNet.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal R = 7.14M;
            decimal h = 3.84M;
            decimal pi = 3.141592653M;
            Console.WriteLine("V = " + (pi*R*R*h));
            Console.WriteLine("S = " + (2*pi*R*R*h+2*pi*R*R));
            Console.ReadKey();
        }
    }
}

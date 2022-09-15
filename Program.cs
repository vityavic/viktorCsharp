using System;

namespace ConsoleApp1
{
    class szamol
    {
        public static int darab = 0;
        public static int maxdarab = 0;
        public szamol()
        {
            darab++;
            Console.WriteLine(darab);
        }
        ~szamol()
        {
            darab--;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 500000; i++)
            {
                new szamol();
            }
        }
    }
}
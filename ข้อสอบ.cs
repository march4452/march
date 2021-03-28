using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x;
            int y;
            
            x= a;
            y= b;

            if (x == y)
            {
                Console.WriteLine("x");
            }
            else
            {
                if (x < y)
                { x = x + a; }
                else
                { y = y + b; }
            }

        }
    }
}


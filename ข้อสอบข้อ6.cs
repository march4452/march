using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();

            int T = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= T; ++i)
            {
                for (int j = 1; j <= T; ++j)
                {
                    if (j <= T - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(A);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
        










    }
        
}


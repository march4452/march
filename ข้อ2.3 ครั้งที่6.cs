using System;

public class MyProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("pls enter '0' to exit  ");
        Console.WriteLine("-----------------------");
        int input;
        do
        {
            Console.WriteLine("");
            Console.Write("yak ru sud kun mae a ri? : ");
            input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                if (input != 0)
                {
                    int R = (input * i);
                    Console.WriteLine("{0} * {1} = {2}", input, i, R);
                }
            }
        } while (input != 0);
    }
}


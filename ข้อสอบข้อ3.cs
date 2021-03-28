using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            double box1, box2, box3, Fix, Remove;

            Console.Write("input box in bucket 1 :");
            box1 = double.Parse(Console.ReadLine());
            Console.Write("input box in bucket 2 :");
            box2 = double.Parse(Console.ReadLine());
            Console.Write("input box in bucket 3 :");
            box3 = double.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("bucket1 = {0} || bucket2 = {1} || bucket 3 = {2}", box1, box2, box3);
                Console.Write("A choose number of Boxed bucket :");
                Fix = double.Parse(Console.ReadLine());
                switch (Fix)
                {
                    case 1:
                        Console.Write("Valux to remove :");
                        Remove = double.Parse(Console.ReadLine());
                        if ((Remove>= 1 && Remove < 3))
                        { box1 = box1 - Remove; }
                        break;

                    case 2:
                        Console.Write("Value to remove :");
                        Remove = double.Parse(Console.ReadLine());
                        if ((Remove >= 1 && Remove < 3))
                        { box2 = box2 - Remove; }
                        break;

                    case 3:
                        Console.Write("Value to remove :");
                        Remove = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((Remove >= 1 && Remove < 3))
                        { box3 = box3 - Remove; }
                        break;
                }
                if (box1 == 0 && box2 == 0 && box3 == 0)
                {
                    Console.WriteLine("B win love you");
                }
                else
                {
                    Console.WriteLine("bucket1 = {0}  ||  bucket2 = {1}  ||  bucket 3 = {2}", box1, box2, box3);
                    Console.Write("B choose number of Boxed bucket :");
                    Fix = double.Parse(Console.ReadLine());
                    switch (Fix)
                    {
                        case 1:
                            Console.Write("Value to remove :");
                            Remove = double.Parse(Console.ReadLine());
                            if ((Remove >= 1 && Remove < 3))
                            { box1 = box1 - Remove; }
                            break;

                        case 2:
                            Console.Write("Value to remove :");
                           Remove = double.Parse(Console.ReadLine());
                            if ((Remove >= 1 && Remove < 3))
                            { box2 = box2 - Remove; }
                            break;

                        case 3:
                            Console.Write("Valux to remove :");
                            Remove = double.Parse(Console.ReadLine());
                            if ((Remove >= 1 && Remove < 3))
                            { box3 = box3 - Remove; }
                            break;
                    }
                    if (box1 == 0 && box2 == 0 && box3 == 0)
                    {
                        Console.WriteLine("A win ice ");
                    }
                }
            } while (box1 != 0 || box2 != 0 || box3 != 0);
            Console.ReadLine();
        }
    }
}

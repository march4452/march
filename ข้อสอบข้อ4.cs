using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            float x; float y; float dx; float dy; float step; float x1; float y1; float x2; float y2;
            Console.Write("x1 :");
            x1 = float.Parse(Console.ReadLine());
            Console.Write("y1 :");
            y1 = float.Parse(Console.ReadLine());
            Console.Write("x2 :");
            x2 = float.Parse(Console.ReadLine());
            Console.Write("y2 :");
            y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;
            Math.Abs(dx); Math.Abs(dy);

            if (dx >= dy)
            {
                step = dx;
            }
            else
            {
                step = dy;
            }

            dx /= step; dy /= step;
            x = x1; y = y1;
            int i = 1;
            while (i <= step)
            {

            
            
            }


            
        }
    }
}


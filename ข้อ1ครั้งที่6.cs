using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        { 
        
            enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }

        struct Problem
        {
            public string Message;
            public int Answer;


            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }

        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];
            
            Random rnd = new Random();
            int x, y;


            for (int i = 0; i < numProblem; i++)
            {

                x = rnd.Next(50);

                y = rnd.Next(50);

                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                   
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
               
                else

                    randomProblems[i] =
                   
                    new Problem(String.Format("{0} + {1} = ?", x, y), x - y);
            }

            return randomProblems;
        }


    }
}

using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var tool = new FibonacciTool();

            Console.WriteLine("*****   FIBONACCI   *****");
            Console.WriteLine("***** Loop Solution *****");
            Console.WriteLine(tool.ForLoopSolution(15));

            Console.WriteLine();
            Console.WriteLine("*****     FIBONACCI      *****");
            Console.WriteLine("***** Recursive Solution *****");
            Console.WriteLine("0");
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine(tool.RecursiveSolution(i));
            }
        }        
    }
}

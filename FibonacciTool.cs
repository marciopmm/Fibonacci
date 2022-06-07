using System.Text;

namespace Fibonacci
{
    public class FibonacciTool
    {
        public string ForLoopSolution(int endNumber)
        {
            var number1 = 0;
            var number2 = 1;
            var result = new StringBuilder();

            Console.WriteLine(number1);
            Console.WriteLine(number2);

            for (int i = 0; i <= endNumber; i++)
            {
                var next = number1 + number2;
                number1 = number2;
                number2 = next;

                result.AppendLine(next.ToString());
            }

            return result.ToString();
        }

        public int RecursiveSolution(int n)
        {
            if (n <= 1)
                return 1;

            return RecursiveSolution(n - 2) + RecursiveSolution(n - 1);
        }
    }
}
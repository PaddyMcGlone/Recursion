using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        // My first recursive program
        static int CalculateRecursively(int n, int m)
        {
            int sum = n;

            if(n < m)
            {
                n++;
                // Add on the result of calling recursively.
                return sum += CalculateRecursively(n, m);
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N:");
            var N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number M:");
            var M = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateRecursively(N, M);

            Console.WriteLine($"Sum: {sum}");
            Console.ReadLine();
        }
    }
}

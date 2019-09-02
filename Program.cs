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
            if(n < m)
            {
                n++;
                CalculateRecursively(n, m);
            }

            return n;
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

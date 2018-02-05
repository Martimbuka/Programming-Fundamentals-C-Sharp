using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondOfStars
{
    class DiamondOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N ; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(i == 0 || j == 0 || i == N-1 || j == N-1)
                        Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}

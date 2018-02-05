using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses
{
    class SunGlasses
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            //Top Layer
            Console.Write($"{new string('*', size * 2)}" + $"{new string(' ', size)}" + $"{new string('*', size * 2)}");
            Console.WriteLine();
            //Middle Layer
            var middleRows = size - 2;
            var specialRow = (middleRows - 1) / 2;
            for (int row = 0; row < middleRows; row++)
            {

                if (specialRow == row)
                {
                    Console.Write($"*{new string('/', size * 2 - 2)}*" + $"{new string('|', size)}" + $"*{new string('/', size * 2 - 2)}*");
                }
                else
                {
                    Console.Write($"*{new string('/', size * 2 - 2)}*" + $"{new string(' ', size)}" + $"*{new string('/', size * 2 - 2)}*");
                }
                Console.WriteLine();
            }
            //Lower Layer
            Console.Write($"{new string('*', size * 2)}" + $"{new string(' ', size)}" + $"{new string('*', size * 2)}");
            Console.WriteLine();
        }
    }
}

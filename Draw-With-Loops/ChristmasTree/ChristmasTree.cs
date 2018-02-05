using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            for (int row = 0; row < size; row++)
            {
                var numberOfStars = row;
                var numberOfStartingSpaces = size - numberOfStars;
                Console.WriteLine($"{new string(' ', numberOfStartingSpaces)}" + $"{new string('*',numberOfStars)}" + $" | " + $"{new string('*', numberOfStars)}");
            }
        }
    }
}

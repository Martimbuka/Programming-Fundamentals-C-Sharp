using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var roof = (size + 1) / 2;
            var ground = size / 2 - 1;
            for (int row = 0; row < roof; row++)
            {
                if (size % 2 == 0)
                {
                    Console.Write($"{new string('')}");
                }
                Console.WriteLine();
            }
        }
    }
}

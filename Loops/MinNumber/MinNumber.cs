using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            var min = 1000000000000000000.0;
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (min > number)
                    min = number;
            }
            Console.WriteLine(min);
        }
    }
}

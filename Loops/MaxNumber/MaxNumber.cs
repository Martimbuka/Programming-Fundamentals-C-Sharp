using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var max = -1000000000000000000.0;
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (max < number)
                    max = number;
            }
            Console.WriteLine(max);
        }
    }
}

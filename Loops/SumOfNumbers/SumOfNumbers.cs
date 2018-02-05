using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}

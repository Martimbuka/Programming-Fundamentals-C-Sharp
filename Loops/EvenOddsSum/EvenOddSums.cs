using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddsSum
{
    class EvenOddSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenSum = 0.0;
            var oddSum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                if (i%2==0)
                {
                    var evenNumber = double.Parse(Console.ReadLine());
                    evenSum += evenNumber;
                }
                else
                {
                    var oddNumber = double.Parse(Console.ReadLine());
                    oddSum += oddNumber;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes\nSum = {evenSum}");
            }
            else Console.WriteLine("No\nDiff = {0}", Math.Abs(oddSum-evenSum));
        }
    }
}

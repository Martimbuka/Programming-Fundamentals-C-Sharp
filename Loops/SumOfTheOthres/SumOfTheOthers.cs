using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTheOthres
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sumOfAllElements = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var inputNumber = int.Parse(Console.ReadLine());
                sumOfAllElements += inputNumber;
                if (max < inputNumber)
                    max = inputNumber;
            }
            var check = sumOfAllElements - max;
            if (check == max)
            {
                Console.WriteLine("Yes\nSum = {0}", check);
            }
            else
            {
                var result = Math.Abs(check - max);
                Console.WriteLine("No\nDiff = {0}", result);
            }
        }
    }
}

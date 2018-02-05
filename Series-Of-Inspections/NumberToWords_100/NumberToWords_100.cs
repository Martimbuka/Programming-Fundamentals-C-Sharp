using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords_100
{
    class NumberToWords_100
    {
        static void Main(string[] args)
        {
            string[] zeroNine = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sxiteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { null, null, "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            var inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber < 10 && inputNumber >=0)
            { Console.WriteLine(zeroNine[inputNumber]); }
            else if (inputNumber >= 10 && inputNumber < 20)
            {
                Console.WriteLine(teens[inputNumber % 10]);
            }
            else if (inputNumber >= 20 && inputNumber < 100)
            {
                if (inputNumber % 10 == 0)
                {
                    Console.WriteLine(tens[inputNumber/10]);
                }
                else
                {
                    Console.WriteLine(tens[inputNumber/10] + " " + zeroNine[inputNumber%10]);
                }
            }
            else if (inputNumber == 100 )Console.WriteLine("one hundred");
            else Console.WriteLine("invalid number");
        }
    }
}

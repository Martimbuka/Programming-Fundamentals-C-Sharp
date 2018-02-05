using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    class NumberToWords
    {
        static void Main(string[] args)
        {
            string[] oneNine ={ null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var digit = int.Parse(Console.ReadLine());
            if(digit > 0 && digit < 10)
                Console.WriteLine(oneNine[digit]);
            else Console.WriteLine("number too big");
        }
    }
}

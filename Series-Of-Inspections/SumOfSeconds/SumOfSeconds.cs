using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSeconds
{
    class SumOfSeconds
    {
        static void Main(string[] args)
        {
            var timeOne = int.Parse(Console.ReadLine());
            var timeTwo = int.Parse(Console.ReadLine());
            var timeThree = int.Parse(Console.ReadLine());
            var totalSeconds = timeOne + timeTwo + timeThree;
            var minutes = totalSeconds / 60;
            var seconds = totalSeconds % 60;
            Console.WriteLine($"{minutes:0}:{seconds:00}");
        }
    }
}

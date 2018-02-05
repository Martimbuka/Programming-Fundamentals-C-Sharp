using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var length = Math.Abs(x1 - x2);
            var height = Math.Abs(y2 - y1);
            var S = length * height;
            var P = 2 * (length + height);
            Console.WriteLine(S);
            Console.WriteLine(P);
        }
    }
}

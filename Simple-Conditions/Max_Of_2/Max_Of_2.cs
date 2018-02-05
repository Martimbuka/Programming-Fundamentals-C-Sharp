using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Of_2
{
    class Max_Of_2
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            if(a >= b)
                Console.WriteLine(a);
            else Console.WriteLine(b);
        }
    }
}

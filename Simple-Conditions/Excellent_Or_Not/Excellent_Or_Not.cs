using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent_Or_Not
{
    class Excellent_Or_Not
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if(grade >= 5.50)
                Console.WriteLine("Excellent!");
            else Console.WriteLine("Not excellent.");
        }
    }
}

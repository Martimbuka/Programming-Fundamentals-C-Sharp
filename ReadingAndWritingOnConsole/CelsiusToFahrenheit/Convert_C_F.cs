using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Celsium = ");
            var celsium = double.Parse(Console.ReadLine());
            var fahrenheit = celsium * 1.8 + 32;
            Console.WriteLine("Fahrenheit = {0}", fahrenheit);
        }
    }
}

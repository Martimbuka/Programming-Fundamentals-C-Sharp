using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedInfo
{
    class SpeedInfo
    {
        static void Main(string[] args)
        {
            var inputSpeed = double.Parse(Console.ReadLine());
            if (inputSpeed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (inputSpeed > 10 && inputSpeed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (inputSpeed > 50 && inputSpeed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (inputSpeed > 150 && inputSpeed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}

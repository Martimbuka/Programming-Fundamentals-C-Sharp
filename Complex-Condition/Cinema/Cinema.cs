using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            var fullHall = rows * cols;
            var price = 0.0;
            switch (type)
            {
                case "Premiere":
                    {
                        price = 12.00;
                        price *= fullHall;
                        Console.WriteLine("{0:f2}", price);
                    } break;
                case "Normal":
                    {
                        price = 7.50;
                        price *= fullHall;
                        Console.WriteLine("{0:f2}", price);
                    }
                    break;
                case "Discount":
                    {
                        price = 5.00;
                        price *= fullHall;
                        Console.WriteLine("{0:f2}", price);
                    }
                    break;
                default: break;
            }
        }
    }
}

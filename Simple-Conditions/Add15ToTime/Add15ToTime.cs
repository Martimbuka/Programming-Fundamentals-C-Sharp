using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add15ToTime
{
    class Add15ToTime
    {
        static void Main(string[] args)
        {
            var hh = int.Parse(Console.ReadLine());
            var mm = int.Parse(Console.ReadLine());
            if(hh >= 0 && hh <= 23 && mm >= 0 && mm <= 59)
            {
                mm += 15;
                if(mm > 59)
                {
                    hh++;
                    mm = mm - 60;
                    if(hh > 23)
                    {
                        hh = 0;
                    }
                }
            }
            Console.WriteLine($"{hh}:{mm:00}");
        }
    }
}

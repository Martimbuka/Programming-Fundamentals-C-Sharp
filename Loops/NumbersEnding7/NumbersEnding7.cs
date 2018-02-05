using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEnding7
{
    class NumbersEnding7
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class BonusPoint
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var bonusPoints = 0.0;
            if (number <= 100)
            {
                bonusPoints += 5;
            }
            else if (number > 100 && number <= 1000)
            {
                bonusPoints += (number / 5.0);
            }
            else if( number > 1000)
            {
                bonusPoints += (number / 10.0);
            }
            if (number % 2 == 0)
                bonusPoints += 1;
            else if (number % 10 == 5)
                bonusPoints += 2;
            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + number);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualCouples
{
    class EqualCouples
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int previousPairSum = 0;
            int currentPairSum = 0;
            int difference = 0;
            int biggestdifference = 0;

            for (int i = 0; i < n; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    previousPairSum = firstNumber + secondNumber;
                }
                else
                {
                    currentPairSum = firstNumber + secondNumber;
                    difference = Math.Abs(currentPairSum - previousPairSum);
                    if (difference > biggestdifference)
                    {
                        biggestdifference = difference;
                    }
                    previousPairSum = currentPairSum;
                }
            }
            if (biggestdifference == 0)
            {
                Console.WriteLine("Yes, value={0}", previousPairSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", biggestdifference);
            }

        }
    }
}


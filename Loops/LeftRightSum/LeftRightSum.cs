using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSum
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            var leftSum = 0.0;
            var rightSum = 0.0;
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var leftNumber = double.Parse(Console.ReadLine());
                leftSum += leftNumber;
            }
            for (int i = 0; i < n; i++)
            {
                var rightNumber = double.Parse(Console.ReadLine());
                rightSum += rightNumber;
            }
            if(rightSum == leftSum)
                Console.WriteLine($"Yes, sum = {leftSum}");
            else Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
        }
    }
}

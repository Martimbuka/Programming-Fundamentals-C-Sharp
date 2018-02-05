using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConvertor
{
    class UnitConverter
    {
        static void Main(string[] args)
        {
            var inputNumber = double.Parse(Console.ReadLine());
            var inputMetric = Console.ReadLine();
            var outputMetric = Console.ReadLine();
            var middleValue = 0.0;
            //Input
            if (inputMetric == "mm")
            {
                middleValue = inputNumber / 1000;
            }
            else if (inputMetric =="cm")
            {
                middleValue = inputNumber / 100;
            }
            else if (inputMetric == "mi")
            {
                middleValue = inputNumber / 0.000621371192;
            }
            else if (inputMetric == "in")
            {
                middleValue = inputNumber / 39.3700787;
            }
            else if (inputMetric == "km")
            {
                middleValue = inputNumber / 0.001;
            }
            else if (inputMetric == "ft")
            {
                middleValue = inputNumber / 3.2808399;
            }
            else if (inputMetric == "yd")
            {
                middleValue = inputNumber / 1.0936133;
            }
            else if (inputMetric == "m")
            {
                middleValue = inputNumber;
            }
            //Output
            var outputValue = 0.0;
            if (outputMetric == "mm")
            {
                outputValue = middleValue * 1000;
            }
            else if (outputMetric == "cm")
            {
                outputValue = middleValue * 100;
            }
            else if (outputMetric == "mi")
            {
                outputValue = middleValue * 0.000621371192;
            }
            else if (outputMetric == "in")
            {
                outputValue = middleValue * 39.3700787;
            }
            else if (outputMetric == "km")
            {
                outputValue = middleValue * 0.001;
            }
            else if (outputMetric == "ft")
            {
                outputValue = middleValue * 3.2808399;
            }
            else if (outputMetric == "yd")
            {
                outputValue = middleValue * 1.0936133;
            }
            else if (outputMetric == "m")
            {
                outputValue = middleValue;
            }
            Console.WriteLine($"{outputValue} {outputMetric}");
        }
    }
}

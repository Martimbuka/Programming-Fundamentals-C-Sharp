using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();
            var USD = 1.79549;
            var EUR = 1.95583;
            var GBP = 2.53405;
            var convert = 0.0; 
            if (inputCurrency == "BGN")
            {
                if(outputCurrency == "USD")
                {
                    convert = money / USD;
                    Console.WriteLine("{0} {1}", Math.Round(convert,2), outputCurrency);
                }
                else if(outputCurrency == "EUR")
                {
                    convert = money / EUR;
                    Console.WriteLine("{0} {1}", Math.Round(convert, 2), outputCurrency);
                }
                else if(outputCurrency == "GBP")
                {
                    convert = money / GBP;
                    Console.WriteLine("{0} {1}", Math.Round(convert, 2), outputCurrency);
                }
            }
            else if(inputCurrency == "USD")
            {
                if (outputCurrency == "BGN")
                {
                    convert = money * USD;
                    Console.WriteLine("{0} {1}", Math.Round(convert, 2), outputCurrency);
                }
                else if (outputCurrency == "EUR")
                {
                    convert = money * USD;
                    convert /= EUR;
                    Console.WriteLine("{0} {1}", Math.Round(convert, 2), outputCurrency);
                }
                else if (outputCurrency == "GBP")
                {
                    convert = money * USD;
                    convert /= GBP;
                    Console.WriteLine("{0} {1}", Math.Round(convert, 2), outputCurrency);
                }
            }
            else if(inputCurrency == "EUR")
            {
                if (outputCurrency == "USD")
                {
                    convert = money * EUR;
                    convert /= USD;
                    Console.WriteLine("{0} {1}", Math.Round(convert, 2), outputCurrency);
                }
                else if (outputCurrency == "BGN")
                {
                    convert = money * EUR;
                    Console.WriteLine("{0} {1}", Math.Round(convert, 2), outputCurrency);
                }
                else if (outputCurrency == "GBP")
                {
                    convert = money * EUR;
                    convert /= GBP;
                    Console.WriteLine("{0} {1}", Math.Round(convert, 2), outputCurrency);
                }
            }
            else if(inputCurrency == "GBP")
            {
                if (outputCurrency == "USD")
                {
                    convert = money * GBP;
                    convert /= USD;
                    Console.WriteLine("{0} {1}", Math.Round(convert, 2), outputCurrency);
                }
                else if (outputCurrency == "EUR")
                {
                    convert = money * GBP;
                    convert /= EUR;
                    Console.WriteLine("{0} {1}", Math.Round(convert, 2), outputCurrency);
                }
                else if (outputCurrency == "BGN")
                {
                    convert = money * GBP;
                    Console.WriteLine("{0} {1}", Math.Round(convert, 2), outputCurrency);
                }
            }
        }
    }
}

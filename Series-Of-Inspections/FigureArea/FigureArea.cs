using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    class FigureArea
    {
        static void Main(string[] args)
        {
            var inputFigure = Console.ReadLine();
            if (inputFigure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var square = a * a;
                Console.WriteLine("{0}",Math.Round(square,3));
            }
            else if (inputFigure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var rectangle = a * b;
                Console.WriteLine("{0}",Math.Round(rectangle,3));
            }
            else if (inputFigure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var ah = double.Parse(Console.ReadLine());
                var triangle = a * ah / 2;
                Console.WriteLine(Math.Round(triangle,3));
            }
            else if (inputFigure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var circle = Math.PI * r * r;
                Console.WriteLine(Math.Round(circle, 3));
            }
        }
    }
}

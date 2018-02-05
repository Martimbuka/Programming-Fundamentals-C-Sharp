using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            var inputAges = double.Parse(Console.ReadLine());
            var inputGender = Console.ReadLine();
            if (inputGender == "f")
            {
                if (inputAges < 16) { Console.WriteLine("Miss"); }
                else { Console.WriteLine("Ms."); }
            }
            else
            {
                if (inputAges < 16) { Console.WriteLine("Master"); }
                else { Console.WriteLine("Mr."); }
            }
        }
    }
}

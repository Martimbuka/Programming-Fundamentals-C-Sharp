using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string StrDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(StrDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessPassword
{
    class GuessPassword
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();
            var guess = "s3cr3t!P@ssw0rd";
            if (password == guess) Console.WriteLine("Welcome");
            else Console.WriteLine("Wrong password!");
        }
    }
}

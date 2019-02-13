using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string kuk = "Hello ";
            string fish = "World";
            object kukfish = kuk + fish;
            string kukk = (string) kukfish;
            Console.WriteLine(kukk);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            int inputnumb;

            Console.WriteLine("Enter your number:");
            test = Console.ReadLine();
            inputnumb = Convert.ToInt32(test);

            if (inputnumb % 7 == 0)
            {
                Console.WriteLine("True Number");
            }
            else if (inputnumb % 5 == 0)
            {
                Console.WriteLine("True Number");
            }
            else
            {
                Console.WriteLine("False Number");
            }
            Console.ReadLine();
        }
    }
}

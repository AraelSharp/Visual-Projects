using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddsAndEvens
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

           if (inputnumb % 2 == 0)
            {
                Console.WriteLine("The number you entered is even ;^)");
            }
           else
            {
                Console.WriteLine("The number you entered is odd ;^(");
            }

            Console.ReadLine();

        }
    }
}

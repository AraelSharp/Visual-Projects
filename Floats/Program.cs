using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.Write("First Number: ");
            string aString = Console.ReadLine(); a = Convert.ToDouble(aString);
            Console.Write("Second Number: ");
            string bString = Console.ReadLine(); b = Convert.ToDouble(bString);


            if (a == b)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            string SuperString;
            int NumberN;

            Console.WriteLine("Number N: ");
            SuperString = Console.ReadLine();
            NumberN = int.Parse(SuperString);

            do
            {
                NumberN --;
            }
            while (NumberN > 1);


            Console.WriteLine();
            Console.ReadLine();

        }
    }
}

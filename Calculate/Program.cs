using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            string numbertwo;
            int A;
            int B;

            Console.WriteLine("Number 1:");
            number = Console.ReadLine();
            A = Convert.ToInt32(number);


            Console.WriteLine("Number 2:");
            numbertwo = Console.ReadLine();
            B = Convert.ToInt32(numbertwo);

            Console.WriteLine(A + B);
            Console.ReadLine();

        }
    }
}

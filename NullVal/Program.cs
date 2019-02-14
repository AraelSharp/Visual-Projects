using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullVal
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;

            Console.WriteLine(a);
            Console.WriteLine(a + 2 + b);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString;
            int sumNumbOne;
            int sumNumbTwo;
            int sumNumbThree;

            Console.WriteLine("Enter 1st number:");
            testString = Console.ReadLine();
            sumNumbOne = int.Parse(testString);

            Console.WriteLine("Enter 2nd number:");
            testString = Console.ReadLine();
            sumNumbTwo = int.Parse(testString);

            Console.WriteLine("Enter 3rd number:");
            testString = Console.ReadLine();
            sumNumbThree = int.Parse(testString);

            Console.Write("The sum of all numbers is: ");
            Console.Write(sumNumbOne + sumNumbTwo + sumNumbThree);

            Console.ReadLine();
        }
    }
}

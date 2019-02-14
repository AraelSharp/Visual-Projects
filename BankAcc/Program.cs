using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EZCREDIT NOTSCAM ONLINE BANKING SERVICE!"); Console.Write("CREATE YOUR ACCOUNT.");
            Console.WriteLine(""); Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine(""); Console.Write("Middle Name: ");
            string midName = Console.ReadLine();
            Console.WriteLine(""); Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(""); Console.Write("Balance: ");
            double Bal;
            string balString = Console.ReadLine(); Bal = Convert.ToDouble(balString);
            Console.WriteLine(""); Console.Write("Bank Name: ");
            string IBAN = Console.ReadLine();
            Console.WriteLine(""); Console.Write("Credit Card #1: ");
            double CC1;
            string cc1String = Console.ReadLine(); CC1 = Convert.ToDouble(cc1String);
            Console.WriteLine(""); Console.Write("Credit Card #2: ");
            double CC2;
            string cc2String = Console.ReadLine(); CC2 = Convert.ToDouble(cc2String);
            Console.WriteLine(""); Console.Write("Credit Card #3: ");
            double CC3;
            string cc3String = Console.ReadLine(); CC3 = Convert.ToDouble(cc3String);

            Console.WriteLine(firstName);
            Console.Write(midName);
            Console.WriteLine(lastName);
            Console.WriteLine("BAL ", Bal);
            Console.WriteLine(IBAN);
            Console.WriteLine(CC1);
            Console.WriteLine(CC2);
            Console.WriteLine(CC3);

            Console.ReadLine();
        }
    }
}

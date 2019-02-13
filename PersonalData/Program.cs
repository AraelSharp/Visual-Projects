using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ZUCKBOOK");Console.Write(" PLEASE LET US KNOW YOUR PERSONAL DATA.");
            Console.WriteLine(""); Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine(""); Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(""); Console.Write("Age: ");
            int Age;
            string ageString = Console.ReadLine(); Age = Convert.ToInt32(ageString);
            Console.WriteLine(""); Console.Write("Gender (m, f, t) : ");
            char Gender;
            string genderString = Console.ReadLine(); Gender = Convert.ToChar(genderString);
            Console.WriteLine(""); Console.Write("Personal ID number (eg. 8306112507) : ");
            double ID;
            string idString = Console.ReadLine(); ID = Convert.ToDouble(idString);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(Age);
            Console.WriteLine(Gender);
            Console.WriteLine(ID);




            Console.ReadLine();
        }
    }
}

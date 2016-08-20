using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str0 = "Word A";
            string str1 = "Word B";
            Console.WriteLine("This is a console application meant for exploring the power of 'strings'.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Comparing " + str0 + " and " + str1);

            int value0 = string.Compare(str0, str1);
            Console.WriteLine(value0);
            value0 = str0.CompareTo(str1);
            Console.WriteLine(value0);
            value0 = str1.CompareTo(str0);
            Console.WriteLine(value0);

            Console.WriteLine("End program");
            Console.ReadKey();
        }
    }
}

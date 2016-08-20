using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose which array type we want to use
            Console.WriteLine("Press '1' for a 1D array or press '2' for a 2D array");
            Console.WriteLine();
            string user_input = Console.ReadLine();
            if (user_input == "1")
            {
                string[] array = new string[] {"a", "b"};

                Console.WriteLine(array[0]);
                Console.WriteLine(array[1]);
            }

            if (user_input == "2")
            {
                string[,] array = new string[,]
                {
                {"0,0", "0,1"},
                {"1,0", "1,1"},
                };

                Console.WriteLine(array[0, 0]);
                Console.WriteLine(array[0, 1]);
                Console.WriteLine(array[1, 0]);
                Console.WriteLine(array[1, 1]);
            }
            Console.ReadKey();
        }
    }
}

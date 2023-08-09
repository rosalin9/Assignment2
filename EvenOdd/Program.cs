using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    /// <summary>
    /// program to take two numbers as input and prints true or false if both numbers are even or odd
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a % 2) == 0 && (b % 2) == 0)
                Console.WriteLine(true);
            else if((a % 2) != 0 &&  (b % 2) != 0)
                Console.WriteLine(false);

            Console.Read();
        }
    }
}

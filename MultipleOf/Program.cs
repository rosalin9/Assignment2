using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleOf
{
    /// <summary>
    /// Program to check if a given number is Multiple of 3 or 7 but not both
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Multiple(n);

            Console.Read();
        }
        static void Multiple(int i)
        {
            if ((i % 3) == 0 && (i % 7) == 0) 
                Console.WriteLine(false);
            else if ((i % 3) == 0)
                Console.WriteLine(true);
            else if ((i % 7) == 0)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }
}

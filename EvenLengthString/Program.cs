using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenLengthString
{
    //program to create a string by using 2 middle characters of a given string if the string length is even
    class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            if ((str.Length)%2 == 0)
                Console.WriteLine(str.Substring((str.Length/2) - 1, 2));

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumber
{
    /// <summary>
    /// program to convert number to a binary number
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number to convert (or \"end\") ? ");
            int n = Convert.ToInt32(Console.ReadLine());
            StringBuilder binary = new StringBuilder();
            while(n>0)
            {
                binary.Append(n%2);
                n /= 2;
            }
            char[] Arr = binary.ToString().ToCharArray();
            Array.Reverse(Arr);
            Console.WriteLine(Arr);

            Console.Read();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSubStr
{
    /// <summary>
    /// program to create a new string from the first 2 charchters of given string.if string length is less than 2 return original string
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            StringBuilder s = new StringBuilder(2);

            if(str.Length >= 2 )
                s.Append(str.Substring(0,2));
            else if(str.Length < 2 && str.Length > 0)
                s.Append(str.Substring(0,1));

            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}

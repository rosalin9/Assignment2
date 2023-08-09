using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWhiteSpaces
{
    /// <summary>
    /// program to create a function to input a string and count the number of white spaces in that string
    /// </summary>
    public class Program
    {
        public static int SpaceCount(string input)
        {
            int count = 0;
            foreach(char c in input) 
            {
                if(c == ' ')
                    count++;
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.Write("Please input a string : ");
            string str = Console.ReadLine();

            int c = SpaceCount(str);

            Console.WriteLine();
            Console.WriteLine($"\"{str}\" contains {c} spaces");

            Console.Read();
        }
    }
}

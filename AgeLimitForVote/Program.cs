using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeLimitForVote
{
    /// <summary>
    /// program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (age > 18)
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            else
                Console.WriteLine("Sorry! You are not eligible to cast your vote.");

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    /// <summary>
    /// program to create a function to check whether a number is prime or not
    /// </summary>
    class Program
    {
        //Function for Prime Number
        static void PrimeNum(int n)
        {
            int flag = 0;

            for(int i=n; i> 1; i--)
            {
                if (n % i == 0)
                    flag++;
            }

            if (flag == 1)
                Console.WriteLine(n+" is a Prime Number");
            else
                Console.WriteLine(n+" is not a Prime Number");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            PrimeNum(a);

            Console.ReadLine();
        }
    }
}

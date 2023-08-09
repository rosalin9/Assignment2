using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    /// <summary>
    /// Create a Menu Driven program to perform calculations.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int op;
 
            Console.Write("Enter the first integer : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Here are the options");
            Console.WriteLine("1-Addition.");
            Console.WriteLine("2-Substraction.");
            Console.WriteLine("3-Multiplication.");
            Console.WriteLine("4-Division.");
            Console.WriteLine("5-Exit.");
            Console.WriteLine();
            do 
            { 
                Console.Write("Input your choice: ");
                op = Convert.ToInt32(Console.ReadLine());
                int res;

                switch (op)
                {
                    case 1:
                        res = a + b;
                        Console.WriteLine($"The Addition of {a} and {b} is: " + res);
                        break;
                    case 2:
                        res = a - b;
                        Console.WriteLine($"The Substraction of {a} and {b} is: " + res);
                        break;
                    case 3:
                        res = a * b;
                        Console.WriteLine($"The Multiplication of {a} and {b} is: " + res);
                        break;
                    case 4:
                        res = a / b;
                        Console.WriteLine($"The Division of {a} and {b} is: " + res);
                        break;
                }
                Console.WriteLine();
            }while (op < 5);
  

        }
    }
}

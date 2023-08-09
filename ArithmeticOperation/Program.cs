using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperation
{
    /// <summary>
    /// program to perform +,-,*,/ operations on two numbers
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Operation: ");
            char op = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int res;

            switch (op) 
            {
                case '+':
                    res = a + b;
                    Console.WriteLine(a + " + " + b + " = " + res);
                    break;
                case '-':
                    res = a - b;
                    Console.WriteLine(a + " - " + b + " = " + res);
                    break;
                case '*':
                    res = a * b;
                    Console.WriteLine(a + " * " + b + " = " + res);
                    break;
                case '/':
                    res = a / b;
                    Console.WriteLine(a + " / " + b + " = " + res);
                    break;
                default :
                    Console.WriteLine("This operation is not possible");
                    break;

            }
            Console.Read();
        }
    }
}

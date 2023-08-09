using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTo100
{
    /// <summary>
    /// program to check which number is closest to 100 among two numbers.Return 0 if numbers are equal
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n1=Convert.ToInt32(Console.ReadLine());
            int n2=Convert.ToInt32(Console.ReadLine());

            Closest(n1,n2);

            Console.Read();
        }
        static void Closest(int i, int j)
        {
            if ((100 - i) < (100 - j))
                Console.WriteLine("The closest number is: "+i);
            else if((100-j) < (100-i)) 
                Console.WriteLine("The closest number is: " + j);    
            else if(i==j) 
                Console.WriteLine("Result is: "+0);
           
        }
    }
}

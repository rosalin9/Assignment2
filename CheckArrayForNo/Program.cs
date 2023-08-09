using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckArrayForNo
{
    class Program
    {
        /// <summary>
        /// program to check if a specified number is present in an array or not
        /// </summary>
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //string input converted to string array
            string[] Arr = str.Split(',');

            int n = Convert.ToInt32(Console.ReadLine());
            int flag = 0;

            foreach(var i in Arr)
            {
                //the value in an array is a string so it converted to Int
                if (Convert.ToInt32(i) == n)
                    flag++;
            }
            if (flag > 0)
                Console.WriteLine(true);
            else 
                Console.WriteLine(false);

            Console.ReadLine();
        }
        
    }
}

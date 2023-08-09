using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceArray
{
    /// <summary>
    /// program to check whether a sequence of number 1,2,3 is present in a given array
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] Arr= str.Split(',');
            int[] arr = new int[Arr.Length];
            int flag = 0;

            for(int i=0; i<Arr.Length; i++) 
            {
                arr[i]=Convert.ToInt32(Arr[i]);
            }

            for (int i = 0; i < (Arr.Length - 2); i++)
            {
                if (arr[i] == 1 && arr[i + 1] == 2 && arr[i + 2] == 3)
                    flag++;
                
            }
            if (flag > 0)
                Console.WriteLine(true); 
            else
                Console.WriteLine(false);

            Console.Read();
        }
    }
}

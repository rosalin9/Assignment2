using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    /// <summary>
    /// program to read temperature and display a suitable message according to the temperature
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature of your city : ");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (temp < 0)
                Console.WriteLine("Freezing weather");
            else if (temp >= 0 && temp < 10)
                Console.WriteLine("Very Cold weather");
            else if (temp >= 10 && temp < 20)
                Console.WriteLine("Cold weather");
            else if (temp >= 20 && temp < 30)
                Console.WriteLine("Normal in Temp");
            else if (temp >= 30 && temp < 40)
                Console.WriteLine("Its Hot");
            else if (temp >= 40)
                Console.WriteLine("Its Very Hot");

            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayDayOfWeek
{
    /// <summary>
    /// program to read any day number and display the name of the day as a word
    /// </summary>
    public class Program
    {
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };

        static void Main(string[] args)
        {
            Console.Write("Enter the day number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Enum.GetName(typeof(enum class name)) is used to get the name of an enum value
            //Enum.GetValues(typeof(enum class name)) is used to get the values of an enum name
            string s = Enum.GetName(typeof(Days), n);

            Console.WriteLine(s);

            Console.Read();

        }
    }
}

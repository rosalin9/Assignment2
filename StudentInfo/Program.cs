using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    /// <summary>
    /// program to read roll no,names and marks of three subjects and calculate total,percentage,division
    /// </summary>
    public struct Student
    {
        public int Id;
        public string Name;
        public Marks marks;
    }

    public struct Marks
    {
        public int Physics;
        public int Chemistry;
        public int ComputerApplication;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student S1;

            Console.Write("Input the Roll Number of the student: ");
            S1.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Name of the student: ");
            S1.Name = Console.ReadLine();
            Console.Write("Input the marks of Physics, Chemistry and Computer Application: ");
            S1.marks.Physics = Convert.ToInt32(Console.ReadLine());
            S1.marks.Chemistry = Convert.ToInt32(Console.ReadLine());
            S1.marks.ComputerApplication = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Roll No : " + S1.Id);
            Console.WriteLine("Name of Student : " + S1.Name);
            Console.WriteLine("Marks in Physics : "+S1.marks.Physics);
            Console.WriteLine("Marks in Chemistry : " + S1.marks.Chemistry);
            Console.WriteLine("Marks in Computer Application : " + S1.marks.ComputerApplication);
            int total = S1.marks.Physics + S1.marks.Chemistry + S1.marks.ComputerApplication;
            Console.WriteLine("Total Marks = " + total);
            decimal percentage = (((decimal)total / 300)*100);
            Console.WriteLine("Percentage = " + percentage);
            if (percentage >= 60)
                Console.WriteLine("Division = First");
            else if (percentage >= 45)
                Console.WriteLine("Division = Second");
            else if (percentage >= 30)
                Console.WriteLine("Division = Third");
            else
                Console.WriteLine("Fail");

            Console.Read();

        }
    }
}

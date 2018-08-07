using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part2deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            //This asks for the user to input the 2 dates
            Console.WriteLine("Enter any date (YYYY/MM/DD): ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter another date (YYYY/MM/DD): ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            // Calculation of both dates 
            TimeSpan diffDate = secondDate.Subtract(firstDate);

            // The answer is then presented in Days, Hours, and Minutes
            Console.WriteLine("Time Difference: ");
            Console.WriteLine(diffDate.Days.ToString() + " Days");
            Console.WriteLine("Or " + diffDate.Days*24 + " Hours"); // multiplied the days by the hours (24) of a day
            Console.WriteLine("Or " + diffDate.Days*1440 + " Minutes"); // multiplied the days by the seconds (1440) of a day
        }

    }
}

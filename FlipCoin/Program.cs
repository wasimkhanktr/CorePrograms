using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 4 digit no");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
                Console.WriteLine("Leap year");
            else if (year % 4 == 0 && year % 100 != 0)
                Console.WriteLine("Leap year");
            else
                Console.WriteLine("Not Leap Year");
        }
    }
}
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
            Console.WriteLine("Enter Two numbers");
            int no1 = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());
            int temp = no1;
            no1 = no2;
            no2 = temp;
            Console.WriteLine("No1 is " + no1 + "\nNo2 is " + no2);
        }
    }
}
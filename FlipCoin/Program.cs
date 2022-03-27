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
            Console.WriteLine("Enter three numbers");
            int no1 = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());
            int no3 = Convert.ToInt32(Console.ReadLine());
            no1 = Math.Max(no1, no2);
            no1 = Math.Max(no1, no3);
            Console.WriteLine("The Largest no is " + no1);
        }
    }
}
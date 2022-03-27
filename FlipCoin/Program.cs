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
            Console.WriteLine("Enter a no");
            int no = Convert.ToInt32(Console.ReadLine());
            if (no % 2 == 0)
                Console.WriteLine("Even No");
            else
                Console.WriteLine("Odd No");
        }
    }
}
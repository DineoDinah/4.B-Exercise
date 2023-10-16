using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.B_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first integer:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >0)
            {
                Console.WriteLine(a % 3 == 0 || a % 7 == 0);
            }
        }
    }
}

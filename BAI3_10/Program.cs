using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n= ");
            int n = int.Parse(Console.ReadLine());
            int f0 = 0;
            int f1 = 1;
            int f = 0;
            Console.WriteLine($"Day Fibonacci {n} so la: ");
            int i = 0;
            while (i < n)
            {
                i++;
                Console.Write(f + "\t");
                f0 = f1;
                f1 = f;
                f = f0 + f1;
            }
            Console.ReadKey();
        }
    }
}

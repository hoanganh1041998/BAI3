using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap 1 so nguyen n= ");
            int n =int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    s += i;
                }
            }
            Console.WriteLine($"Tong cac so le tu 1 den {n} la: {s}");
            Console.ReadKey();
        }
    }
}

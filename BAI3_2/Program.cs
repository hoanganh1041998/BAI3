using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bang cuu chuong tu 1 den {n} la: ");
            for (int i = 1; i <= n; i++)
            {
                for (int j =1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} x {j} = " + i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap 1 so nguyen n= ");
            int n = int.Parse(Console.ReadLine());
            if (n % 3 == 0)
            {
                Console.WriteLine($"{n} chia het cho 3");
            }
            else
            {
                Console.WriteLine($"{n} khong chia het cho 3");
            }
            Console.ReadKey();
        }
    }
}

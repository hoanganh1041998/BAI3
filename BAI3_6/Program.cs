using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap 1 so nguyen n: ");
            int n= int.Parse(Console.ReadLine());
            double s = 0;
            for (int i=1;i<=n;i++)
            {
                s += Math.Pow(i, i);
            }
            Console.WriteLine("Tong la: " + s);
            Console.ReadKey();
        }
    }
}

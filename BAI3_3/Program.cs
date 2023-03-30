using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("-----TINH TONG GIAI THUA-----");
            Console.WriteLine($"Tong giai thua tu 1 den {n} la: " + tong_giai_thua(n));
            Console.WriteLine("-----KIEM TRA SO CHINH PHUONG-----");
            so_chinh_phuong(n);
            Console.ReadKey();
        }
        public static int tong_giai_thua(int n)
        {
            int s = 0;
            int gt = 1;
            for (int i=1;i<=n;i++)
            {
                gt *=i;
                s += gt;
            }
            return s;
        }
        public static void so_chinh_phuong(int n)
        {
            if (Math.Sqrt(n) %1 ==0)
            {
                Console.WriteLine($"{n} la so chinh phuong");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so chinh phuong");
            }
            
        }
    }
}

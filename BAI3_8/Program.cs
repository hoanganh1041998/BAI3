using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n= ");
            uint n = uint.Parse(Console.ReadLine());

            for (int i=2;i<=n;i++)
            {
                if (so_nguyen_to(i)==true)
                {
                    Console.Write(i+"\t");
                }
            }
            
            Console.ReadKey();
        }
        public static bool so_nguyen_to(int n)
        {
            bool kiem_tra = true;
            for (int i = 2; i <n; i++)
            {
                if (n % i ==0)
                {
                    kiem_tra = false;
                    break;
                }
                else
                {
                    kiem_tra = true;
                }
            }
            return kiem_tra;
        }
        
    }
}

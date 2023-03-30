using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 thang bat ky: ");
            uint thang = uint.Parse(Console.ReadLine()); 
            if (thang >12 || thang < 0)
            {
                Console.WriteLine("Thang da nhap khong hop le");
            }
            else
            {
                switch (thang)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("Thang co 30 ngay");
                        break;
                    case 2:
                        Console.WriteLine("Thang co 28 hoac 29 ngay");
                        break ;
                    default:
                        Console.WriteLine("Thang co 31 ngay");
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nhap a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b : ");
            b = int.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)

                    Console.WriteLine("Phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("Phuong Trinh vo nghiem ");
            else
            {
                int ketqua = -b / a;
                Console.WriteLine("Phuong trinh co nghiem la x=0");
                ketqua.ToString();
            }
            Console.ReadKey();  
        }
    }
}

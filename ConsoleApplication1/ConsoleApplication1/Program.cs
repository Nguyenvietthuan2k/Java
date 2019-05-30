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
            int choose;
            do
            {
                Console.WriteLine("1.Nhap vao 2 so nguyen");
                Console.WriteLine("2.Hien thi 2 so vua nhap ");
                Console.WriteLine("3.Tong 2 so");
                Console.WriteLine("4.Tich 2 so");
                Console.WriteLine("5.Hieu hai so");
                Console.WriteLine("6.Thuong hai so");
                Console.WriteLine("7.Nhap lua chon cua ban:");

                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Nhap  so a:");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so b:");
                        b = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Hien thi so a: ");
                        Console.WriteLine("Hien thi so b: ");
                        break;
                    case 3:
                        Console.WriteLine("Nhap so a:");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so b:");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tinh tong {0}", a + b);
                        break;
                    case 4:
                        Console.WriteLine("Nhap so a:");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so b:");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tinh hieu {0}", a - b);
                        break;
                    case 5:
                        Console.WriteLine("Nhap so a:");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so b:");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tinh hieu {0}", a * b);
                        break;
                    case 6:
                        Console.WriteLine("Nhap so a:");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so b:");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tinh hieu {0}", a / b);
                        break;
                    case 7:
                    default:
                        Console.WriteLine("Thoat");
                        break;
                }
                Console.ReadKey();
            } while (choose != 7);
        }
    }
}

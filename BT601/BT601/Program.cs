using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT601
{
    class Program
    {
        static void Main(string[] args) {
            int choose;
            string name;
            int toan;
            int li;
            int hoa;
            do
            {
                Console.WriteLine("1.Nhap ho va ten");
                Console.WriteLine("2.Nhap diem toan li hoa");
                Console.WriteLine("3.Tinh tong diem 3 mon");
                Console.WriteLine("4.Tinh trung binh mon");
                Console.WriteLine("Chon:");

                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Nhap ho ten:");
                        name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Nhap diem toan :");
                        toan = f.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap diem li :");
                        li = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap diem hoa:");
                        hoa = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Nhap diem toan :");
                        toan = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap diem li :");
                        li = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap diem hoa:");
                        hoa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tinh tong diem 3 mon{0}", toan + li + hoa);
                        break;
                    case 4:

                        Console.WriteLine("Tinh trung binh{0}",(toan+li+hoa)/3);
                        break;

                }
            } while (choose != 5);
            Console.ReadLine();
        }                          
    }
}

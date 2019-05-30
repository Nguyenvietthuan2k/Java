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
            do
            {
                Console.WriteLine("Nhap ten");
                Console.WriteLine("Hien thi ten");
                Console.WriteLine("Thoat");
                Console.WriteLine("Nhap lua chon:");

                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Nhap ten:");
                        name = Console.WriteLine();
                        break;
                    case 2:
                        if(name!=null)
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("Thoat");
                        break;

                }
            } while (choose != 4);
            Console.ReadLine();
        }                          
    }
}

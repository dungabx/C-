using System;
namespace CS02
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
            Kieu_du_lieu Ten_bien;
            Ten_bien:
                - a..z A..Z
                - 0..9
                - _
                - khong bat dau bang so
            */
            string studentName = "Huynhvandung";
            // int studentAge = 20;

            // char a;
            // bool b;
            // float c;
            // c = (float)12.12;

            // object d;
            // d = studentName;

            // int av = 1, bc = 2, ca = 3;

            // var f = 12.12 // var la kieu du lieu khong xac dinh no chi xac dinh khi gan cho bien 

            // const double PI = 3.14 // const la hang so, PI se khong duoc thay doi gia tri nua 

            double soPi = 3.14;
            double hai_Pi = soPi * 2;


            //Console.WriteLine(hai_Pi);

            Console.ForegroundColor = ConsoleColor.Red; // thiet lap mau chu xuat ra man hinh
            Console.BackgroundColor = ConsoleColor.Black; // thiet lap mau cua background 

            Console.Title = "Vi du su dung Console";
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Xin chao chuong trinh nhap xuat du lieu console");

            Console.ResetColor(); // Reset mau chu xuat ra 

            System.Console.Write("gia tri cua so Pi la:");
            //Console.ReadKey(); // chuong trinh dung lai chờ cho người dùng bấm 1 phím bất kì


            System.Console.Write(soPi);
            System.Console.WriteLine();

            Console.Write("Nhap vao ho va ten cua ban: ");
            String hoVaten;
            hoVaten = Console.ReadLine();// chuong trinh dung lai cho nguoi dung den khi nguoi dung nhan phim enter
            Console.WriteLine("Xin chao {0}", hoVaten);

            float a, b;
            String sinput;
            Console.WriteLine("hay nhap tham so a: ");
            sinput = Console.ReadLine();
            a = float.Parse(sinput); // chuyen String thanh float.

            Console.WriteLine("hay nhap tham so b: ");
            sinput = Console.ReadLine();
            b = Convert.ToSingle(sinput); // chuyen String thanh float.

            Console.WriteLine("So a = {0}, So b = {1} ", a, b);
        }
    }
}

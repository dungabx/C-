using System;
using System.Web;
namespace cs09
{
    class Count
    {
        public int c = 1;
    }
    class Program
    {
        static void Main(String[] args)
        {
            //xinChao();
            System.Console.WriteLine(tich(10, 4));

            int kq = cs09.Tinhtoan.tong(10, 20);
            System.Console.WriteLine(kq);

            float kq1 = cs09.Tinhtoan.tong(12.12f, 11.11f); //overload
            System.Console.WriteLine(kq1);

            xinChao("Dung", "Huynh");
            xinChao(ho: "Huynh Van", ten: "Dung");// nguoc lai van duoc

            int f = 3;
            binhPhuong(f);
            System.Console.WriteLine(f);//tham tri nen khong thay doi gia tri


            binhPhuong1(ref f);
            System.Console.WriteLine(f);// tham chieu nen thay doi gia tri

            int a;
            binhPhuong2(10, out a);
            System.Console.WriteLine(a);

            Count abc = new Count();
            System.Console.WriteLine(abc.c);

            dem(abc);
            System.Console.WriteLine(abc.c);

            // khi tham so cua phuong thuc la doi tuong cua 1 lop thi no la tham chieu chu khong phai tham tri.!

        }

        static void xinChao(string ten, string ho)
        {
            System.Console.WriteLine($"Xin chao {ho} {ten}");
        }
        // static void xinChao(string ten, string ho= "Huynh") gan mac dinh ho Huynh neu khong truyen ho
        // {
        //     System.Console.WriteLine($"Xin chao {ho} {ten}");
        // }

        public static int tich(int a, int b)
        {
            return a * b;
        }

        static void binhPhuong(int x)
        {
            x = x * x;
            System.Console.WriteLine(x);
        }

        static void binhPhuong1(ref int x)
        {
            x = x * x;
            System.Console.WriteLine(x);
        }

        static void binhPhuong2(int x, out int b) // tham chieu ket qua den b;
        {
            b = x * x;
        }

        static void dem(Count count) {
            count.c++;
        }
    }
}
using System;
namespace cs10
{
    class Program
    {

        class Student
        {
            public String name;

            //ham huy:
            ~Student()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Huy " + name);
                Console.ResetColor();
            }


            public Student(String name)
            {
                this.name = name;
                System.Console.WriteLine("Khoi tao sinh vien " + name);
            }
        }
        static void Main(String[] args)
        {
            Vukhi sungluc;
            sungluc = new Vukhi();

            Vukhi sungtruong = new Vukhi("hello");

            sungtruong.name = "Ak";
            System.Console.WriteLine(sungtruong.name);

            Vukhi sungmay = new Vukhi("sungmay", 10);

            sungluc.thietLapSatThuong(3);
            sungluc.name = "sungluc";
            sungmay.tanCong();
            sungluc.tanCong();


            sungluc.tuyChinhSatThuong = 3;
            System.Console.WriteLine(sungluc.tuyChinhSatThuong);

            sungluc.noiSanXuat = "America";
            System.Console.WriteLine(sungluc.noiSanXuat);

            Student a = new Student("Huynh Van Dung");

            for (int i = 0; i <= 100000; i++)
            {
                a = new Student($"Sinh vien {i}");
                a = null;
            }

            
            GC.Collect(); // thu hoi bo nho cua tat ca cac doi tuong khong tham chieu;
        }
    }
}
using System;
namespace cs19
{
    // virtual method: phuong thuc ao la pt co the bi dinh nghi lai, ghi de lai cho them vao tu khoa "virtual" 


    class Product
    {
        protected double Price { set; get; }

        public virtual void ProductInfo()
        {
            System.Console.WriteLine($"gia san pham la {Price}");
        }

        public void Test() => ProductInfo();
    }

    class Iphone : Product
    {
        public Iphone() => Price = 500;

        //override - nap chong phuong thuc
        // public override void ProductInfo()
        // {
        //     System.Console.WriteLine($"gia iphone la {Price}");
        //     //ghi lai phuong thuc da duoc dinh nghia 
        //     base.ProductInfo();
        // }

    }

    class Program
    {
        static void Main(String[] args)
        {
            // Iphone x = new Iphone();
            // x.Test();

            // Product a = new Product();

            // B c = new B();
            // c.Print();

            Ihinhhoc a = new HinhChuNhat(10, 11);

            System.Console.WriteLine(a.tinhCV());
            System.Console.WriteLine(a.tinhS());

        }
    }

    // abstract class: lop truu tuong : dac diem: 1 khong dung de tao ra cac doi tuong, 2 phuong thuc abstract chi co ten khong co than va cac class ke thua bat buoc phai override lai phuong thuc 
    abstract class A
    {
        public int price { set; get; }

        public abstract void Print();


    }
    class B : A
    {
        public B() => price = 500;
        public override void Print()
        {
            System.Console.WriteLine("gia san pham la {0} ", price);
        }
    }

    //Interface : chi duoc dung de lam co so cho cac lop ke thua != abstract o cho cac phuong thuc trong interface chi can khai bao ten va no la pt truu tuong , lop co so bat buoc phai dinh nghia lai pt do
    interface Ihinhhoc
    {
        public double tinhCV();
        public double tinhS();
    }

    class HinhChuNhat : Ihinhhoc
    {
        public HinhChuNhat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double a { set; get; }
        public double b { set; get; }

        public double tinhCV()
        {
            return (a+b)*2;
        }
        public double tinhS()
        {
            return (a*b);
        }
    }
}
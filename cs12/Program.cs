using System;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;
namespace cs12
{
    class Program
    {
        //struct la kieu tham tri con class la kieu tham chieu
        public struct Product
        {
            // du lieu 
            public string name;
            public double price;
            // phuong thuc 
            public string getInfo()
            {
                return $"Ten san pham {name}, gia: {price}";
            }
            // constructor 
            public Product(string name, double price)
            {
                this.name = name;
                this.price = price;
            }

            public Product()
            {
                
            }

            public string info
            {
                get
                {
                    return $"{name}, {price}";
                }
            }

        }
        // kieu du lieu nho don gian thi nen dung struct, phuc tap lon su dung class

        //Kieu liet ke enum
        /*
            0 - Kem 
            1 - Trung binh
            2 - Kha 
            3 - Gioi
        
        
        
        */

        enum HOCLUC
        {
            Kem=10, //0
            TrungBinh=123,//1
            Kha=333,//2
            Gioi=112//3
        }


        static void Main(String[] args)
        {
            // Product sanpham_1 = new Product();
            // sanpham_1.name = "Iphone";
            // sanpham_1.price = 1000;



            // Product sanpham_2 = new Product("Nokia", 900);

            // sanpham_2 = sanpham_1;
            // sanpham_2.name = "Iphone X"; 
            // System.Console.WriteLine(sanpham_1.getInfo());
            // System.Console.WriteLine(sanpham_2.getInfo());

            // System.Console.WriteLine(sanpham_2.info);

            // Enum 
            // int hocluc= 3;

            // switch (hocluc)
            // {
            //     case 0:
            //         System.Console.WriteLine("yeu");
            //         break;
            //     case 1:
            //         System.Console.WriteLine("trung binh");
            //         break;
            //     case 2:
            //         System.Console.WriteLine("kha");
            //         break;
            //     case 3:
            //         System.Console.WriteLine("gioi");
            //         break;
            // } 

            //1 so vd lien quan den Enum
            // Console.BackgroundColor = ConsoleColor.Blue;
            // FileAccess
            // FileAttributes
            // FileMode
            // DateFormat
            // DateTimeKind

            HOCLUC hocluc;
            hocluc = HOCLUC.Kem;

            int so = (int)hocluc;
            System.Console.WriteLine(so);

            hocluc = (HOCLUC)(333); 

            switch (hocluc)
            {
                case HOCLUC.Kem:
                    System.Console.WriteLine("Kem");
                    break;
                case HOCLUC.TrungBinh:
                    System.Console.WriteLine("Trung Binh");
                    break;
                case HOCLUC.Kha:
                    System.Console.WriteLine("Kha");
                    break;
                case HOCLUC.Gioi:
                    System.Console.WriteLine("Gioi");
                    break;
            }
        }
    }
}
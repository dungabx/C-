using System;
using MyNameSpace;
using xyz = MyNameSpace.abc;
using static System.Console;
using static System.Math;
using Sanpham;
namespace cs15

{
    class Program
    {
        static void Main(String[] args)
        {
            Class1.XinChao();
            xyz.Class1.XinChao();
            WriteLine("Hello");

            WriteLine(PI);
            WriteLine(Sin(PI / 4));

            Sanpham.Product product = new Sanpham.Product();
            product.name = "Ipad";
            product.price = 1000;
            product.description = "Day la Ipad";

            WriteLine(product.GetInfo());

            product.manufactory = new Sanpham.Product.Manufactory();
            product.manufactory.name = "Apple";
            product.manufactory.address = "America";

            WriteLine(product.Abc());
        }
    }
}
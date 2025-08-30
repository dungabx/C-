using System;
namespace cs10
{
    internal class Vukhi
    {
        //Du lieu
        public string name;
        int satThuong = 0;
        //phuong thuc khoi tao
        // this - ref tham chieu den gia tri mac dinh;
        public Vukhi()
        {
            System.Console.WriteLine("Khoi tao");
        }

        public Vukhi(String abc)
        {
            System.Console.WriteLine(abc);
        }

        public Vukhi(String name, int satThuong)
        {
            this.name = name;
            this.satThuong = satThuong;
        }

        //THUOC TINH dung de truy cap hoac thiet lap 1 du lieu nao cua lop;
        public int tuyChinhSatThuong
        {
            // co the co 1 trong 2 deu duoc vd:co set kh get, co get kh set ,hoac co ca 2;
            set
            {
                this.satThuong = value;
            }

            get
            {
                return this.satThuong;
            }
        }

        public string noiSanXuat{ set; get; }
        public void thietLapSatThuong(int satThuong)
        {
            this.satThuong = satThuong;
        }

        public void tanCong()
        {
            System.Console.Write($"{name}:  ");
            for (int i = 0; i < satThuong; i++)
            {
                System.Console.Write(" * ");
            }
            System.Console.WriteLine();
        }
    }
}
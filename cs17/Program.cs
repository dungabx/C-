using System;
namespace cs17
{
    class Program
    {
        // Anonymous - kieu du lieu vo danh
        // Object - thuoc tinh - chi doc
        // new {thuoc tinh = giatri, thuoctinh2 = giaitri2}
        // thuoc tinh cua kieu vo danh CHI DOC khong the chinh sua;
        // Dynamic - kieu du lieu dong.
        class SinhVien
        {
            public string HoTen { set; get; }
            public int NamSinh { set; get; }
            public string NoiSinh { set; get; }

        }

        static void Main(String[] args)
        {
            var sanpham = new
            {
                Ten = "Iphone",
                Gia = 1000,
                NamSx = 2018
            };
            System.Console.WriteLine(sanpham.Ten);
            System.Console.WriteLine(sanpham.Gia);

            List<SinhVien> cacsinhvien = new List<SinhVien>()
            {
                new SinhVien() {HoTen = "Nam", NamSinh = 2001, NoiSinh = "TPHCM"},
                new SinhVien() {HoTen = "Nga", NamSinh = 2000, NoiSinh = "Quang Tri"},
                new SinhVien() {HoTen = "Danh", NamSinh = 2002, NoiSinh = "Hai Phong"}
            };

            var ketqua = from sv in cacsinhvien
                         where sv.HoTen.Contains("a")
                         select new
                         {
                             Ten = sv.HoTen,
                             NS = sv.NoiSinh
                         };
            foreach (var sv in ketqua)
            {
                System.Console.WriteLine(sv.Ten + " " + sv.NS);
            }

            dynamic tenbien1; // khong nhat thiet phai gan ngay gia tri cho no
            var tenbien2 = 123;// bat buoc phai gan gia tri cho no


            student abc = new student();
            PrinIf(abc);
            
        }

        class student
        {
            public string Name { set; get; }

            public void Hello()
            {
                System.Console.WriteLine(Name);
            }

        }
        static void PrinIf(dynamic obj)
        {
            obj.Name = "avacascasc";
            obj.Hello();
        }
    }
}
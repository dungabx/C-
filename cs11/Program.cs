using System;
using System.Runtime.Intrinsics.X86;
using System.Text;
namespace cs11
{
    class Program
    {
        static void Main(String[] args)
        {
            string loichao;//null
            loichao = "Xin chao";

            string ten = "Huynh Van Dung";

            string thongbao = loichao + " " + ten;
            System.Console.WriteLine(thongbao);

            thongbao += "!";
            System.Console.WriteLine(thongbao);

            // de chen "" vao thi can \" 
            string chu_y = "\"chu y\" ngay mai tat ca hoc sinh nghi hoc";
            System.Console.WriteLine(chu_y);
            // de chen dau "\" = \\, can 1 tab = \t, xuong dong = \n, gach dau dong = \r
            System.Console.WriteLine("\rToi ten la:\t Nguyen Van \nA \\!");
            //truong hop dat biet: @ o truoc dau " "thi se du nguyen noi dung ben trong
            string abc = @"toi ten la          nguyen Van A - \ 
            
            abcd    #    "" ";
            System.Console.WriteLine(abc);

            // doi voi $"" thi se chen duoc bieu thuc trong dau {} vd :
            int year = 2025;
            string b = $"nam nay la {year}, nam sau la {year + 1}";
            System.Console.WriteLine(b);

            // hoac co the nhu the nay 
            string e = $"nam nay la {year,-10}, nam sau la {year + 1}";
            System.Console.WriteLine(e);
            // co the su dung $@"..."
            string thongbao2;
            string name = "Huynh Van Dung";
            string gioitinh = "nam";
            thongbao2 =
            $@"
                Ho ten: {name,10}
                Nam sinh: {year - 20,10}
                Gioi tinh:{gioitinh,10}
            ";
            System.Console.WriteLine(thongbao2);

            int doDaiChuoi = thongbao2.Length;
            System.Console.WriteLine(doDaiChuoi);

            char c = thongbao2[30];
            System.Console.WriteLine(c);

            for (int i = 0; i < thongbao2.Length; i++)
            {
                char q = thongbao2[i];
                System.Console.WriteLine($"chi so {i} la ki tu {q,3} ");
            }

            foreach (var kitu in thongbao2)
            {
                System.Console.WriteLine(kitu);
            }

            string pip = "********************Huynh van Dung*****";
            pip = pip.Trim('*');// cat di ki tu o dau va cuoi, co the dung TrimStart(),TrimEnd() de cat o dau,cuoi
            System.Console.WriteLine(pip);
            string abxxx = "toi ten la Huynh Van dung";
            System.Console.WriteLine(abxxx.ToUpper());// bien tat ca thanh chu in hoa;
            System.Console.WriteLine(abxxx.ToLower());// bien tat ca thanh chu in thuong;

            System.Console.WriteLine(abxxx.Replace("toi ten", "ten ban")); // thay chuoi ban 1 chuoi khac
            System.Console.WriteLine(abxxx.Insert(12, "hhh"));// chen chuoi vao 1 vi tri
            System.Console.WriteLine(abxxx.Substring(11, 5));// lay ra chuoi con tu vi tri  nhap vao va bao nhieu ki tu, co the chi co nhap vao
            System.Console.WriteLine(abxxx.Remove(11, 5));// loai di tat ca cac chuoi con tu vi tri bat dau va xoa bn ki tu
            String[] chuoicon = abxxx.Split(' '); //Tra ve mang cac chuoi con duoc chia nho tu chuoi ban dau 
            foreach (var kitu in chuoicon)
            {
                System.Console.WriteLine(kitu);
            }

            string abxxxnew = string.Join('.', chuoicon);//nguoc lai voi Split();
            System.Console.WriteLine(abxxxnew);

            StringBuilder thongbao3 = new StringBuilder();// hieu nang tot hon string chi cap phat bo nho 1 lan duy nhat tu tao ra cho den chinh sua
            thongbao3.Append("Xin");
            thongbao3.Append(" chao cac ban");
            thongbao3.Replace("Xin chao", "hello");
            string kq=thongbao3.ToString();
            System.Console.WriteLine(kq);

        }
    }
}
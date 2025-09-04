namespace Sanpham
{
    public partial class Product //tu khoa partial giup chia nho dinh nghia lop ra lam nhieu file ma nguon
    {
        public string name { set; get; }
        public decimal price { set; get; }

        public string GetInfo()
        {
            return $"{name} / {price} : {description}";
        }
    }
}
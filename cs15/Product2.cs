namespace Sanpham{
    public partial class Product
    {
        public Manufactory manufactory{ set; get; }
        public class Manufactory
        {
            public string name { set; get; }
            public string address { set; get; }

        }
        public string description { set; get; }

        public string Abc()
        {
            return $"name: {manufactory.name}, address: {manufactory.address}";
        }
    }
}
using System;

namespace ForForeachWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product1 adında bir Product oluşturduk.
            Product product1 = new Product
            {
                ProductName = "BMW     ",
                ProductColor = "Blue     ",
                ProductPrice = 65000
            };

            Product product2 = new Product
            {
                ProductName = "Mercedes",
                ProductColor = "Red      ",
                ProductPrice = 120000
            };

            Product product3 = new Product
            {
                ProductName = "Ford    ",
                ProductColor = "Turquoise",
                ProductPrice = 70000
            };
            //products adında dizi oluşturarak product1,2 ve 3 ü Dizi içine yerleştirdik.
            Product[] products = new Product[] { product1, product2, product3 };
            Console.WriteLine("For Başladı:");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Adı= " + products[i].ProductName + " | Ürün Rengi= " + products[i].ProductColor + " | Ürün Fiyatı= " + products[i].ProductPrice);
            }
            Console.WriteLine("For Sonlandı!");
            Console.WriteLine("----------------");
            Console.WriteLine("Foreach Başladı!");
            foreach (var item in products)
            {
                Console.WriteLine("Ürün Adı= " + item.ProductName + "| Ürün Rengi= " + item.ProductColor + "| Ürün Fiyatı= " + item.ProductPrice);
            }
            Console.WriteLine("Foreach Sonlandı!");
            Console.WriteLine("----------------");
            Console.WriteLine("While Başladı!");
            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine("Ürün Adı= " + products[a].ProductName + " | Ürün Rengi= " + products[a].ProductColor + " | Ürün Fiyatı= " + products[a].ProductPrice);
                a++;
            }
            Console.WriteLine("While Sonlandı!");
            Console.WriteLine("----------------");

        }
    }
    //Product adında class oluşturup özelliklerini belirledik.
    class Product
    {
        public string ProductName { get; set; }
        public string ProductColor { get; set; }
        public int ProductPrice { get; set; }
    }
}

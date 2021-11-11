using System;

namespace ETicaretProduct
{
    class Product
    {
        public string UrünAdi { get; set; }
        public int Fiyat { get; set; }
        public string Renk { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            {

            }
            Product Product1 = new Product();
            Product1.UrünAdi = "Mont";
            Product1.Renk = "Siyah";
            Product1.Fiyat = 349;

            Product Product2 = new Product();
            Product2.UrünAdi = "Tshirt";
            Product2.Renk = "Mavi";
            Product2.Fiyat = 149;

            Product Product3 = new Product();
            Product3.UrünAdi = "Bot";
            Product3.Renk = "Sarı";
            Product3.Fiyat = 249;

            Product Product4 = new Product();
            Product4.UrünAdi = "Yelek";
            Product4.Renk = "Siyah";
            Product4.Fiyat = 99;

            Product[] products = new Product[] { Product1, Product2, Product3, Product4 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].UrünAdi + "/" + products[i].Renk + "/" + products[i].Fiyat);

            }

            foreach (Product product in products)
            {

                Console.WriteLine(product.UrünAdi + "/" + product.Renk + "/" + product.Fiyat);

            }

            int sayac = 0;

            while (sayac < products.Length)
            {
                Console.WriteLine(products[sayac].UrünAdi + "/" + products[sayac].Renk + "/" + products[sayac].Fiyat);
                sayac++;

            }
        }
    }
    

    }



using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGrisiYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else
            {
                Console.WriteLine("Sabit");
            }
         

            if (sistemeGrisiYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");

            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");

            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}

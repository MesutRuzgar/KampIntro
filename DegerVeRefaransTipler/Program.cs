using System;

namespace DegerVeRefaransTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = ? cevap 30 olur. Değer tiplerde eşitlendiği zaman yani o şekilde bir kod girildiğinde
            //öncesini unutur ve eşitlediğin değeri sabitler kendine. 11. satırda olduğu gibi.
            //12. satırdan sonra eşitleme işlemi olmadığı için değer tip sayi1 30 olarak kalmıştır.
            //değer tipler sadece bellekte stack'te çalışır!


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? cevap 999
            //new dediğimiz zaman heap ta yeni bir değer oluşturur ve stack e eşitler.Buna adreste diyebiliriz.
            //bir diğerine eşitlendiği zaman kendi refarans adresini unutur diğerinin refarans sayısını
            //üstlenir ve diğerini görmezden gelerek 22. satırda işlediği 0. değeri 999 u kendi değeri
            //gibi görür.

        }
    }
}

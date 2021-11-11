using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar =new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Giriş Eğitimi",
                "Java","Phyton","C++",};

                                    
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("For bitti.");
            
            //foreach daha kolay bence :D

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }


            Console.WriteLine("Sayfa Sonu - footer");

        }
    }
}

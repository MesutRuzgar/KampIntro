using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Carp(int number1,int number2)
        {
            int carp = number1 * number2;
            Console.WriteLine("Sonuç : "+carp);
        }
        public void Carp(int number1, int number2, int number3) 
        {
            int carp = number1 * number2 * number3;
            Console.WriteLine("Sonuç : "+carp);
        }
        public void Hepsi(params int[] numbers) 
        {
            int hepsi =numbers.Sum();
            Console.WriteLine("Sonuç : "+hepsi);

        }
    }
}

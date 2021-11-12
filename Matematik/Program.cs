using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);

            dortIslem.Topla(3, 1);

            dortIslem.Topla(1, 6);

            Console.WriteLine("---------ÇARPMA--------");

            dortIslem.Carp(2, 3);
            dortIslem.Carp(2, 1, 5);

            Console.WriteLine("-----HEPSİ DAHİL TOPLA----");

            dortIslem.Hepsi(2, 1, 3, 7, 2);

        }
    }
}

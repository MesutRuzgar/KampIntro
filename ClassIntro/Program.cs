using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "C #";
            Kurs1.Egitmen = "Engin Demiroğ";
            Kurs1.IzlenmeOrani = 68;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "Java";
            Kurs2.Egitmen = "Serhat Köse";
            Kurs2.IzlenmeOrani = 56;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "Phyton";
            Kurs3.Egitmen = "Erkan Erbaş";
            Kurs3.IzlenmeOrani = 92;

            //Console.WriteLine(Kurs1.KursAdi + " : " + Kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {Kurs1,Kurs2,Kurs3 };


            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);


            }
                      

                   }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
       
    }
}

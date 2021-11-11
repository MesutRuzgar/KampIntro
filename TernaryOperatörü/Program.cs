using System;

namespace TernaryOperatörü
{
    class Program
    {
        static void Main(string[] args)
        {

            bool medeniHal = false;
            string mesaj = medeniHal == true ? "Evlilere özel indirim" : "Bekarlara özel indirim";

            Console.WriteLine(mesaj);
            
        }
    }
}

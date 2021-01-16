using System;

namespace KampIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sistemeGiris = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (sistemeGiris==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Sisteme giriş butonu");
            }

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonunu göster");
            }
            else
            {
                Console.WriteLine("Eşittir butonu göster");
            }
        }
    }
}

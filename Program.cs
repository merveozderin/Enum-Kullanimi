using System;

namespace Enum_Kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Cumartesi);
            Console.WriteLine((int)Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 30 ;

            if(sıcaklık < (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarı çıkmayalım, soğuk.") ;
            }
            else if (sıcaklık > (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.ÇokSıcak)
            {
                Console.WriteLine("Dışarı çıkabiliriz, hava güzel.") ;
            }
             else if (sıcaklık > (int)HavaDurumu.ÇokSıcak)
             {
                 Console.WriteLine("Dışarı çıkmayalım, çok sıcak.") ;
             }

        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=12,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Normal=28,
        Sıcak =30,
        ÇokSıcak= 40
    }
}

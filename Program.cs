using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 01;
            musteri1.Adi = "Ahmet";
            musteri1.SoyAdi = "ASLAN";
            musteri1.Sehir = "Konya";
            musteri1.Telefon = "0531508756";

            MusteriManager musteriManager = new MusteriManager();
            

            Musteri musteri2 = new Musteri();
            musteri2.Id = 02;
            musteri2.Adi = "Ali";
            musteri2.SoyAdi = "KALAN";
            musteri2.Sehir = "Antalya";
            musteri2.Telefon = "05312387511";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 03;
            musteri3.Adi = "Adil";
            musteri3.SoyAdi = "MEHMET";
            musteri3.Sehir = "Ankara";
            musteri3.Telefon = "05324581610";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.SoyAdi);
                Console.WriteLine(musteri.Sehir);
                Console.WriteLine(musteri.Telefon);
                Console.WriteLine("..................");

            }
            musteriManager.Listeleme();
            Console.WriteLine("......................");

            musteriManager.Ekleme(musteri1);
            musteriManager.Ekleme(musteri2);
            musteriManager.Ekleme(musteri3);

        }
    }
}

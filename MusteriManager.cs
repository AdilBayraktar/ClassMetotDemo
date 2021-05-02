using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        public void Ekleme (Musteri musteri)
        {
          
            Console.WriteLine("Musteri Eklendi : " + musteri.Adi); 
        }

        public void Listeleme()
        {
            Console.WriteLine("Musteriler Listesi Olusturuldu");
        }
    }
}

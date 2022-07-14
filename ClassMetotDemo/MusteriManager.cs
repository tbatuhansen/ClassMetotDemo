using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi! " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi ! " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Listele(List<Musteri> musteriler)
        {
            foreach (var item in musteriler)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad);
            }
        }
    }
}

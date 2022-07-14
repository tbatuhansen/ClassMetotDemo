using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri()
            {
                Id = Guid.NewGuid(),
                Ad = "Ali",
                Soyad = "Yılmaz",
                AnneKizlikSoyadi="Yıldırım",
                DogumTarihi = DateTime.Now,
                KimlikNo = "11111111111"
            };

            Musteri musteri2 = new Musteri()
            {
                Id = Guid.NewGuid(),
                Ad = "Ahmet",
                Soyad = "Öztürk",
                AnneKizlikSoyadi = "Yıldırım",
                DogumTarihi = DateTime.Now,
                KimlikNo = "11111111111"
            };

            Musteri musteri3 = new Musteri()
            {
                Id = Guid.NewGuid(),
                Ad = "Mehmet",
                Soyad = "Şimşek",
                AnneKizlikSoyadi = "Yıldırım",
                DogumTarihi = DateTime.Now,
                KimlikNo = "11111111111"
            };

            Musteri musteri4 = new Musteri()
            {
                Id = Guid.NewGuid(),
                Ad = "Ayşe",
                Soyad = "Kaya",
                AnneKizlikSoyadi = "Yıldırım",
                DogumTarihi = DateTime.Now,
                KimlikNo = "11111111111"
            };

            Musteri musteri5 = new Musteri()
            {
                Id = Guid.NewGuid(),
                Ad = "Gizem",
                Soyad = "Şahin",
                AnneKizlikSoyadi = "Yıldırım",
                DogumTarihi = DateTime.Now,
                KimlikNo = "11111111111"
            };

            List<Musteri> musteriler = new List<Musteri>();
            musteriler.Add(musteri1);
            musteriler.Add(musteri2);
            musteriler.Add(musteri3);
            musteriler.Add(musteri4);
            musteriler.Add(musteri5);

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri4);
            musteriManager.Listele(musteriler);
        }
    }
}

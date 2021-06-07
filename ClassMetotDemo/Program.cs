using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 10101010101;
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Alihan";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 202020202;
            musteri2.Adi = "Veli";
            musteri2.Soyadi = "Velihan";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 303030303;
            musteri3.Adi = "Deli";
            musteri3.Soyadi = "Delihan";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 404040404;
            musteri4.Adi = "Mehmet";
            musteri4.Soyadi = "Mehmethan";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine("---------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);
            musteriManager.Sil(musteri2);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Tebrikler! Müşteri başarıyla eklendi. : " + musteri.Adi +" "+ musteri.Soyadi);
        }
        
        public void Sil (Musteri musteri)
        {
            Console.WriteLine("Müşteri silme işlemi başarılı. : " + musteri.Adi + " " + musteri.Soyadi);
        }
        
        
    }
}

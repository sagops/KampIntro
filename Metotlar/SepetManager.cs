using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);
        }
        //yukarı kısım aşağıda ki kısımın daha kolayı yani ; Urun class ı içinde stringler intler doubllar var biz onu çağırıp aşağıda ki işlemi kolay yoldan hallediyoruz. tercih etmee.
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunAdi);
        }
    }
}

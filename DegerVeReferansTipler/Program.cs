using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 sonucu nedir???    >>>>>>>>>>> sayi1 sonucu tabisikide 30 fakat aşağıda çarşı karışıyor. şöyle ki;

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;            //>>>>>>>>>>>>> sayilar2[0] sıfır burda ilk eleman demek yani sayilar2 nin ilk elemanı
            //sayilar1[0] elemanı nedir?? >>> sayilar1 sorusunun cevabı 999 olur.

            // int decimal float double bool = değer tip  
            // array class interface  = referans tip 

            // değer tipleri eşitlediğinde değerler atanıyor fakat referans tiplerde bellekte ne tutuyorsa onu atıyor.
            // yani sayilar1 arrayinde 10,20,30 olabilir fakat eşitlediğin zaman "new" adresi sonraki döngüde sayilar2 ye eşitlediysen eğer sayilar2 nin belleğini çağırıyor.
            // yazılımcı yetiştirme kampı 3. gün 2.31.20 dakikalarında bulabilirsin eğer anlamadıysan 
        }
    }
}

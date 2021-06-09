using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);              ctrl + k ctrl + c etrafı yeşile boyadı. ctrl k ctrl u geri alıyor.
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];           // yeni bir array oluşturduk artık isimler yeni referans numarası tutuyor.
            //isimler[4] = "Semih";             // 6 elemanlı arrayin 5. kısmına semih yazdı ama kalan 5 eleman hala null
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);   // ilk eleman null olduğu için yazar ama boş yazar neden?? çünkü yukarıda ki arrayin üstüne boş array yazdık. "new string."

            List<string> isimler2 = new List<string> { "Engin", "Ali", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Semih");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}

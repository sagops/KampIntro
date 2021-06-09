using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();  // mylist classında T belirttik. yani burda liste içine string ve int yazabiliriz.
            isimler.Add("Semih");



            Console.WriteLine("Hello World!");
        }
    }
}

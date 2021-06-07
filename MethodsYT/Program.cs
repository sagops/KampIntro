using System;
using System.Linq;

namespace MethodsYT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(20);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4,5));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!!!!");
        }

        static int Add2(int number1 , int number2=30)
        {
            return number1 + number2;
        }

        // şimdi numbar1 a baktığımız zaman başında ref ibaresini görürüz. yani artık numbar1 artık değer tip değil referans tip gibi davranır
        //bundan mutevellit sonucumuz 130 olmaktadır. 
        //ref yerine out keywordu de kullanılabilir. farkı şu ref keywordünde değeri mutlaka değeri belirlememiz gerekiyor. fakat out da böyle bişeye ihtiyacımız yok.
        //değeri baştan set etmek durumundaysan ref eğer öyle birr zorunluluğumuz yoksa out kullanırız.
        //out kullanırken dikkat edilmesi gereken metodun içinde set edilmesi gerektiğidir. değeri baştan set etmek gerekmiyor fakat metod içinde mutlaka set edilmesi gerekmekte.
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //params keywordü ile metodlarımıza aynı tipte istediğimiz kadar parametre gönderebiliriz. yani int numbar1, int numbar2 vs vs uzun uzadıya yazmak yerine yukarıda
        // seri seri yazarız.
        //Sum toplama keywordü galiba. geri dönüp bakamadım /:
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}

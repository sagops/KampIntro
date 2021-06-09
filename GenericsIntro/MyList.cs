using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;            // burda arrayi newlemeden önce refere ettiği bir önceki arrayi tutturuyoruz yani array null gelmiyor.
            items = new T[items.Length + 1]; // burda +1 olarak array geliyor ama üstteki satır olmasaydı +1 lediği item dışında null gelecekti. yukarıdaki satırda unutmasını engelliyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];                    // 4. bölüm dk 2.42.40 acayip güzel açıklıyor.
            }

            items[items.Length - 1] = item;
        }
    }
}

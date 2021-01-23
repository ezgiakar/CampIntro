using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        // constructor methodu
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];


            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
        // Buradaki T typedan gelir. istediğim tipi yazabilirim ya da T tipinde yazarım.
        // ben mylistimde T tipinde çalışıcam demektir.
        // ben sana ne verirsem, hangipi verirsem T odur demek.
        // temparrayi önceki yok olan listeleri elde tutmak için kullanırım.
        // for ile items eski elemanlarına kavuşur.
    }
}

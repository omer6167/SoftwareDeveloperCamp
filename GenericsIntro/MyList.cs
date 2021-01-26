using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    internal class MyList<T>
    { /*
       T[] items;

       public int Length
       {
           get { return items.Length; }
       }

       public T[] Items
       {
           get { return items; }
       }
       */
        public int Length => Items.Length;
        public T[] Items { get; private set; }

        //constructor
        public MyList()
        {
            Items = new T[0];
        }
        
        public void Add(T item)
        {
            T[] tempArray = Items;
            Items = new T[Items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Items[i] = tempArray[i];
            }

            Items[^1] = item; //= items[items.Length - 1] = item;
        }

        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();

            //foreach (var item in Items)
            //{
            //    yield return item;
            //}
        }
    }
}

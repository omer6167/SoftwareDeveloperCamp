using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGenerics
{
    internal class DataList<T>  // where T : class //we can add constraint
    {
        //Property
        public int Length => Array.Length;

        private static readonly T[] _emptyArray = new T[0];
        public T LastValue => Array[^1];

        private T[] Array { get; set; }

        //Constructor
        public DataList()
        {
            Array = _emptyArray;
        }
        public DataList(T item)
        {
            Array = new T[1];
            Array[0] = item;
        }
        public DataList(params T[] item)
        {
            Array = new T[item.Length];

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = item[i];
            }
        }

        //Method
        public void Add(params T[] item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            T[] tempArray = Array;
            Array = new T[Array.Length + item.Length];

            for (int i = 0; i < tempArray.Length; i++)
            {
                Array[i] = tempArray[i];
            }

            for (int i = tempArray.Length, j = 0; i < Array.Length; i++, j++)
            {
                Array[i] = item[j];
            }
        }
        public void Add(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            T[] tempArray = Array;
            Array = new T[Array.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                Array[i] = tempArray[i];
            }

            Array[^1] = item;
        }


        public void Update(int index, T item)
        {
            if (Array.Length - 1 < index || index < 0)
                throw new IndexOutOfRangeException($"index parameter can't be bigger than List's last index and can't be negative number");
            
            Array[index] = item;
        }

        public void Delete()
        {
            throw new NotImplementedException(); // Will be done later
        }

        public T GetData(int index)
        {
            if (Array.Length - 1 < index && index < 0)
                throw new IndexOutOfRangeException("index parameter can't be bigger than List's last index and can't be negative number");

            return Array[index];
        }


        public IEnumerator GetEnumerator()
        {
            return Array.GetEnumerator();
            //foreach (var item in Array)
            //{
            //    yield return item;
            //
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace HomeworkGenerics
{
    internal class DataDictionary<TKey, TValue>
    {
        private static readonly TKey[] _emptyKey = new TKey[0];
        private static readonly TValue[] _emptyValue = new TValue[0];

        private TKey[] TkeyArray { get; set; }
        private TValue[] TvalueArray { get; set; }

        public DataDictionary()
        {
            TkeyArray = _emptyKey;
            TvalueArray = _emptyValue;
        }

        public DataDictionary(TKey keyItem, TValue valueItem)
        {
            TkeyArray = new TKey[1];
            TvalueArray = new TValue[1];

            TkeyArray[0] = keyItem;
            TvalueArray[0] = valueItem;
        }

        public void Add(TKey keyItem, TValue valueItem)
        {
            if (TkeyArray.Any(t => t.Equals(keyItem)))
                throw new DuplicateNameException("There is such a key value");

            
            TKey[] tempKeyArray = TkeyArray;
            TValue[] tempValueArray = TvalueArray;

            TkeyArray = new TKey[TkeyArray.Length + 1];
            TvalueArray = new TValue[TvalueArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                TkeyArray[i] = tempKeyArray[i];
            }
            for (int i = 0; i < tempValueArray.Length; i++)
            {
                TvalueArray[i] = tempValueArray[i];
            }
            
            TkeyArray[^1] = keyItem;
            TvalueArray[^1] = valueItem;
        }

        public void Update(int index, TKey keyItem,TValue valueItem)
        {

            if (TkeyArray.Any(t => t.Equals(keyItem)))
                throw new DuplicateNameException("There is such a key value");


            if (TkeyArray.Length - 1 < index || index < 0)
                throw new IndexOutOfRangeException($"index parameter can't be bigger than List's last index and can't be negative number");

            TkeyArray[index] = keyItem;
            TvalueArray[index] = valueItem;
        }

        public string GetData(int index)
        {
            if (TvalueArray.Length - 1 < index && index < 0)
                throw new IndexOutOfRangeException("index parameter can't be bigger than List's last index and can't be negative number");

            return $"{TkeyArray[index]},{TvalueArray[index]}";
        }

        public string GetData(TKey keyItem)
        {
            int index =0;
            bool var = false;
            for (int i = 0; i < TkeyArray.Length; i++)
            {
                if (!TkeyArray[i].Equals(keyItem)) continue;
                index = i;
                var = true;
                break;
            }

            if (var == false)
                throw new Exception("There is no such a keyvalue");
            
            return $"{TkeyArray[index]},{TvalueArray[index]}";
        }

        public void Delete(int index)
        {
            if (TvalueArray.Length - 1 < index && index < 0)
                throw new IndexOutOfRangeException("index parameter can't be bigger than List's last index and can't be negative number");

            TKey[] tempKeyArray = TkeyArray;
            TValue[] tempValueArray = TvalueArray;

            TkeyArray = new TKey[TkeyArray.Length - 1];
            TvalueArray = new TValue[TvalueArray.Length - 1];

            for (int i = 0,j=0; i < TkeyArray.Length; i++,j++)
            {
                if (j==index)
                {
                    j++;
                }
                TkeyArray[i] = tempKeyArray[j];
                TvalueArray[j] = tempValueArray[j];
            }
        }

        public IEnumerator GetEnumerator()
        {
            IEnumerator keyEnumerator = TkeyArray.GetEnumerator();
            IEnumerator valueEnumerator = TvalueArray.GetEnumerator();
            while (keyEnumerator.MoveNext() && valueEnumerator.MoveNext() &&
                   keyEnumerator.Current != null)
            {
                yield return $"{keyEnumerator.Current},{valueEnumerator.Current}";
            }
        }
    }
}

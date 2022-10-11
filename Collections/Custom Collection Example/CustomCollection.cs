using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionDemo
{
    public class CustomCollection : IEnumerable
    {
        object[] customArr = new object[4];
        static int count = 0;
        public void Add(object a)
        {
            if (customArr.Length > count)
            {
                customArr[count] = a;
            }
            else
            {
                object[] arr1 = customArr;
                customArr = new object[arr1.Length * 2];
                Array.Copy(arr1, customArr, arr1.Length);
                customArr[count] = a;
            }
            count++;
        }
        public object Get(int i)
        {
            return customArr[i];
        }
        public void Update(object pre, object data)
        {
            for(int i=0; i<customArr.Length; i++)
            {
                if(customArr[i].Equals(pre))
                {
                    customArr[i] = data;
                    Console.WriteLine("Value Updated");
                }
            }
            Console.WriteLine("Value is not found");
            //customArr[i] = data;
        }
        public void Insert(int j, object data)
        {
            if (count == customArr.Length)
            {

                object[] arr1 = customArr;
                customArr = new object[arr1.Length * 2];
                Array.Copy(arr1, customArr, arr1.Length);
            }
            object temp = data;

            for (int i = j; i <= count; i++)
            {
                data = customArr[i];
                customArr[i] = temp;
                temp = data;

            }
            count++;
        }

        public void Remove(object data)
        {
            int index = Array.IndexOf(customArr, data);
            for (int i = index; i < count - 1; i++)
            {
                customArr[i] = customArr[i + 1];
            }

            count--;
            if (count * 2 <= customArr.Length)
            {
                object[] arr1 = customArr;
                customArr = new object[arr1.Length / 2];
                Array.Copy(arr1, customArr, count);
            }
        }
        public int Capacity()
        {
            return customArr.Length;
        }
        public int Size()
        {
            return count;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public CustomObjectEnum GetEnumerator()
        {
            return new CustomObjectEnum(customArr, count);
        }
    }
    public class CustomObjectEnum : IEnumerator
    {
        public object[] customArr;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;
        int count = 0;
        public CustomObjectEnum(object[] list, int count)
        {
            customArr = list;
            this.count = count;
        }

        public bool MoveNext()
        {
            position++;
            return (position < count);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public object Current
        {
            get
            {
                try
                {
                    return customArr[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

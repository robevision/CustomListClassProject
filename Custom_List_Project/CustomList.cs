using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList<T> : IEnumerable
    {
        private T[] items;
       
        //T value;
        
        int capacity;

        public CustomList()
        {
            Count = 0;
            capacity = 4;
            items = new T[capacity];
            Capacity();
            

        }
        public int Count
        {
            get; set;
      
        }

        private void Capacity()
        {
            if (Count == capacity)
            {
                T[] temp = new T[capacity * 2];
                for (int i = 0; i < capacity; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;

            }
        }
        public void Add(T item)
        {
            Capacity();

            for (int i = 0; i < Count; i++)
            {
                items[Count] = item;
            }
            items[Count] = item;
            Count++;

            //temp array hint

            //if(capacity > )
            //{
            //    capacity = 4;
            //}



            //{

            //}
            //int temp;
            //temp = item;
            //T item1;
            //try
            //{
            //    item += item1;
            //    canAdd = true;
            //}
            //catch
            //{

            //}

            //if (value + value)
            //{

            //    int x = 0;
            //    int grow = x++;
            //}



            //items +  


            //ADDED THING
            //count++
        }
       //public IEnumerator <T> GetEnumerator()
       // {
       //     for (int i = 0; i < Count; i++)
       //     {
       //         yield return items[i];
       //     }
       // }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }
    }
}

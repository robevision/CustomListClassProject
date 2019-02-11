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
        int count;

        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
            GenerateCapacity();
            

        }
        public int Count
        {
            get
            {
                return count;
            }   
      
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            
        }

        private void GenerateCapacity()
        {
            if (count == capacity)
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
            GenerateCapacity();

            for (int i = 0; i < count; i++)
            {
                items[count] = item;
            }
            items[count] = item;
            count++;

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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }
    }
}

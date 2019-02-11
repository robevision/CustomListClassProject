using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList<T>
    {
        private T[] items;
       
        //T value;
        
        int capacity;

        public CustomList()
        {
            Count = 0;
            capacity = 4;
            items = new T[capacity];
            
            
            
        }
        public int Count
        {
            get; set;
      
        }

        //public int Capacity { get;}
        public void Add(T item)
        {
          
            for (int i = 0; i < Count; i++)
            {
                items[Count] = item;
            }

            items[Count] = item;
            Count++;

            if (Count + 1 == capacity)
            {
                T[] temp = new T[capacity * 2];
                //for(int i = 0; i < Count; i++)
                //{
                //    items[Count] = item;
                //}
                //T[] NewItems = items + temp;

                //copy values over while maintaining original size
            }

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
        //public void Capacity()
        //{
        //    if (items == 1)
        //    {
        //        .Add defaultCapacity[4]
        //    }
        //}
     
    }
}

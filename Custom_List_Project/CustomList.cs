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
        int count;

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
            
            
        }
        public int Count
        {
            get;
            set;
        }

        //public int Capacity { get;}
        public void Add(T item)
        {
            item = items[count + 1];
            count++;
            if (count == capacity)
            {
                T[] temp = new T[capacity * 2];
                temp = items;
            }
            
            //temp array hint
            
            //if(capacity > )
            //{
            //    capacity = 4;
            //}
       

            //for(int i=0;i < /*SOMETHING*//*;*/ i++)
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

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
        //overload operator +
    

   

        int capacity;
        int count;
        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            for (int i = 0; i < b.count; i++)
            {
                a.Add(b[i]);
            }
            return a;

        }
        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
        {
            for (int i = 0; i < b.count; i++)
            {
                a.Remove(b[i]);
            }
            return a;
        }

    //TODO: Indexer
    //public items [int index]
    public T this[int index]   // Indexer declaration  
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
                //this and that conditionals 
                //index needs to be in the bounds of what items array will be set at
                //index will be positive and will start at 1
              
            }

        }



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
                for (int i = 0; i < count; i++)
                {
                    temp[i] = items[i];
                    
                }
                capacity = capacity * 2;
                items = temp;

            }
        }
        public void Remove(T item)
        {
            int i = 0;
            T[] temp = new T[capacity];
                //GenerateCapacity();
            for (int j = 0; j < count; j++)
            {
                    if (!items[j].Equals(item))
                    {
                       temp[j] = items[i];
                       i++;
                    }
                    else
                    {
                        int nextIndex = i + 1;
                        temp[j] = items[nextIndex];
                        count--;
                    }
                    //not able to expand
                    //CustomList<T> tempList = new CustomList<T>() { temp[j] };
                    //for(int k=0; k< count; k++)
                    //{
                    //    items[k] = tempList[k];
                    //}
                   
            }
            items = temp;
             
                        
        }
        public override string ToString()
        {
            StringBuilder appendList = new StringBuilder();
            for(int i = 0; i < count; i++)
            {
                appendList.Append(items[i]);

            }
           
            return appendList.ToString();
            
        }
        public CustomList<string> ToStringList()
        {
            CustomList<string> customStringList = new CustomList<string>();
            try
            {
                //1
                //CustomList<string> customStringList = new CustomList<string>();
                //foreach (string value in items)
                //{
                //    customStringList.Add(value);
                //}
                //2
                //for (int i = 0; i < count; i++)
                //{
                //    if (items[i].Equals(item))
                //    {
                //        foreach (string character in items[i])
                //        {
                //            items[i] = character;
                //        }
                //    }
                //}
                //3
                //use StringBuilder or concat
                for (int i = 0; i < count; i++)
                {
                    
                    foreach (T value in items)
                    {
                        string test = Convert.ToString(value);

                        customStringList[i] = test;
                        return customStringList;
                    }
                }
                return customStringList;
            }
            catch
            {
                return customStringList;
            }
        }
        public void Zip()
        {

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

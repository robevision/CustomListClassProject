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
        //overload operator -
        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
        {
            //1
            //CustomList<T> c = new CustomList<T>();

            //   foreach (T value in a)
            //   {
            //       foreach(T value1 in b)
            //       {
            //           if (value.Equals(value1))
            //           {

            //               c.Remove(value1);
            //           }
            //           else
            //           {

            //               c.Add(value);
            //           }
            //       }
            //   }

            //2

            //    for (int i = 0; i < b.count; i++)
            //    {
            //       for(int j=0; i < a.count;j++)
            //        if (!a[i].Equals(b[i]))
            //        {

            //            c.Add(b[i]);
            //            c.Add(a[i]);
            //        }
            //        else
            //        {

            //            //int nextIndex = i + 1;
            //            //c.Remove(b[nextIndex]);
            //        }

            //}
            
            int i = 0;
            CustomList<T> c = new CustomList<T>();
                //GenerateCapacity();
                for (int j = 0; j < a.count; j++)
                {
                    if (!a[j].Equals(b[i]))
                    {
                        c[j] = a[i];
                        i++;
                    }
                    else
                    {
                        int nextIndex = i + 1;
                        c[j] = a[j];
                        
                    }
                    //not able to expand
                    //CustomList<T> tempList = new CustomList<T>() { temp[j] };
                    //for(int k=0; k< count; k++)
                    //{
                    //    items[k] = tempList[k];
                    //}

                }
               


            
            return c;
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
        public CustomList<T> Zip(CustomList<T> items, CustomList<T> items1)
        {
            int j = 0;
            CustomList<T> tempList = new CustomList<T>();
            for(int i = 0; i < count; i++)
            {
                tempList.Add(items[i]);
                tempList.Add(items1[j++]);
            }
            //foreach (T value in items)
            //{
            //    tempList.Add(value);
            //    tempList.Remove(value1);

            //    foreach (T value1 in items1)

            //    {

            //        tempList.Add(value1);

            //    }
            //}
            //Console.WriteLine(tempList);
            //Console.ReadLine();
            return tempList;
        //    int i = 0;
        //    T[] temp = new T[capacity];
        //for(i = 0; i < count; i++)
        //    {
        //        temp[i]=items[i];
        //    }
        //for(int j = 1; j < count; j++)
        //    {
        //        temp[i]
        //    }
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

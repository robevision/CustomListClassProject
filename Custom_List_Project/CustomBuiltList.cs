using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomBuiltList<T> : IEnumerable
    {
        private T[] items;
        //overload operator +
    

   

        int capacity;
        int count;
        public static CustomBuiltList<T> operator +(CustomBuiltList<T> a, CustomBuiltList<T> b)
        {
            for (int i = 0; i < b.count; i++)
            {
                a.Add(b[i]);
            }
            return a;

        }
       
        //overload operator -
        public static CustomBuiltList<T> operator -(CustomBuiltList<T> comparableListA, CustomBuiltList<T> comparableListB)
        {
           
            CustomBuiltList<T> afterSubtraction = new CustomBuiltList<T>();
            //GenerateCapacity();
            //for (int j = 0; j < comparableListA.count; j++)
            //{
            //    if (comparableListA[j].Equals(comparableListB[j]))
            //    {
            //        afterSubtraction.Add(comparableListA[j]);

            //    }
            //    else
            //    {
            //        //int nextIndex = i + 1;
            //        //afterSubtraction.Add(comparableListA[j]);
            //        //afterSubtraction.Add(comparableListB[i]);

            //    }

            //}
            //for(int i=0; i < comparableListB.count; i++)
            //{
            //    if (comparableListA[i].Equals(comparableListB[i]))
            //    {
            //        afterSubtraction.Add(comparableListB[i]);

            //    }
            //    else
            //    {

            //    }
            //}
            //1
            //CustomBuiltList<T> afterSubtraction = new CustomBuiltList<T>();
            //int j = afterSubtraction.count;
            //foreach (T value in comparableListA)
            //{
                
            //        afterSubtraction.Add(value);
            //}
            //foreach (T value1 in comparableListB)
            //{
                
            //        afterSubtraction.Add(value1);
            //}
            //for (int i = 0; i < afterSubtraction.count; i++)
            //{
            //    foreach (T value in comparableListA) ;
            //    foreach (T value1 in comparableListB) ;
            //    if(!afterSubtraction[i].Equals(comparableListA))
            //{

            //}
            
            //foreach (T value2 in afterSubtraction)
            //{
            //    if(!value2)
            //}

            //2

            //    for (int i = 0; i < comparableListB.count; i++)
            //    {
            //       for(int j=0; i < comparableListA.count;j++)
            //        if (!comparableListA[i].Equals(comparableListB[i]))
            //        {

            //            c.Add(comparableListB[i]);
            //            c.Add(comparableListA[i]);
            //        }
            //        else
            //        {

            //            //int nextIndex = i + 1;
            //            //c.Remove(comparableListB[nextIndex]);
            //        }

            //}



            return afterSubtraction;
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



        public CustomBuiltList()
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
        public CustomBuiltList<string> ToStringList()
        {
            CustomBuiltList<string> customStringList = new CustomBuiltList<string>();
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
        public CustomBuiltList<T> Zip(CustomBuiltList<T> items, CustomBuiltList<T> items1)
        {
            int j = 0;
            CustomBuiltList<T> tempList = new CustomBuiltList<T>();
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

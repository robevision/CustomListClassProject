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
                for (int i = 0; i < capacity; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;

            }
        }
        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {

                //if(i < count - 1)
                //{
                //    items[i] = items[i + 1];
                //    items[i] = items[i - 1];
                //}
                //else
                //{
                //    items[i] = items[0];
                //}
                if (items[i].Equals(item))
                    //i = 0 & i = value 3
                {
                    T[] temp = new T[capacity];
                    
                    //T[] anotherTemp = tempList[0] - temp[i];
                    for (int j = 0; j < count; j++)
                    {
                        if (!items[j].Equals(items[i]))
                        {
                           items[i] = temp[j];
                         
                            
                        }
                        else
                        {
                            count--;
                            capacity--;
                        }
                        // this below is taking iteration j and equaling items that takes iteration j and subtracts i; this is not resulting in the correct way because I am just subtracting an iteration from itself and not actually removing it.
                        //temp[j] = items[j - i];
                        //
                        // this below is attempting to create a new temporary list to utilize the Add method so that i could be overridden by another value. The assembly of this was abandoned because my motive is not to change a value, but remove it. Also, my count currently resides in Add and I did not want the count to be modified by doing this.
                        //CustomList<int> tempList = new CustomList<int>();
                        //tempList.Add(j);
                    }
                    
                    //T[] temp = { items[i] };
                    //arrayData.splice
                    //T[] test = items - temp[0];
                    //bring to last array value
                    //count--;
                    //T value = (item - items[i]);
                    //items[count] = value;
                    
                }
                else
                {

                    break;
                }
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

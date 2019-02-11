using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    class BuiltInListMethod
    {
        public void RunList()
        {
            List<int> list = new List<int>()
            {
            2,2,0,0
            };
            list.Add(5);
            list.Add(6);
            list.Add(10);
            list.Remove(2);
            Console.WriteLine(list.Remove(2));

        }
    }
}

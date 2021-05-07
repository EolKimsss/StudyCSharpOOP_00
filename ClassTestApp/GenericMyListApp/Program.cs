using System;
using System.Collections.Generic;

namespace GenericMyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<object> mylist = new MyList<object>();
            for (int i = 0; i < mylist.Length; ++i)
            {
                mylist[i] = i+1;          

            }
            for (int i = 0; i < mylist.Length; ++i)
            {
                Console.WriteLine(mylist[i]);

            }
        }
    }
}

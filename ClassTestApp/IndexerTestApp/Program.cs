using System;
using System.Collections;
using System.Collections.Generic;

namespace IndexerTestApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");

            MyList mylist = new MyList();
            
            for (int i = 0; i < 5; ++i)
            {
                mylist[i] = (i + 1);
            }

            Console.WriteLine("==============for===================");
            for (int i = 0; i < mylist.Length; ++i)
            {
                Console.WriteLine(mylist[i]);
            }

            Console.WriteLine("==============foreach===================");
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }

        }
    }
}

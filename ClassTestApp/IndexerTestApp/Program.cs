using System;
using System.Collections;
using System.Collections.Generic;

namespace IndexerTestApp
{
    class Program : IEnumerable,IEnumerator
    {
        public object Current => throw new NotImplementedException();

        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");

            MyList mylist = new MyList();
            
            for (int i = 0; i < 5; ++i)
            {
                mylist[i] = (i + 1);
            }

            for (int i = 0; i < mylist.Length; ++i)
            {
                Console.WriteLine(mylist[i]);
            }

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList :IEnumerable , IEnumerator
    {
        private int[] array;
        private int position = -1;
        // 배열화 (배열이 아닌 MyList를 배열처럼 만들어주는 property)
        public int this[int index] // MyList[i] == array[i]
        { 
            get
            { 
                return array[index]; 
            }
            set             
            {
                if (index >= array.Length)
                {
                    System.Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value; 
            }
        }


        public int Length
        {
            get { return array.Length; }
        }

        public object Current => array[position];

        public MyList() { array = new int[3]; }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}

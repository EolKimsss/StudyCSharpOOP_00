using System;
using System.Collections;

namespace QueueTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 스택큐 로직 영역
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue("strst");
            queue.Enqueue(5);


            /*            Stack stack = new Stack();
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push(4);
                        stack.Push(5);

                        while (stack.Count > 0)
                        {
                            Console.Write(stack.Pop() + "\t");
                        }
                        Console.WriteLine();
            */

            #endregion

            Hashtable dictionary = new Hashtable();
            dictionary[1] = "책";
            dictionary[2] = "요리사";
            dictionary[3] = "지저귀다";
            dictionary[4] = "고래";

            Console.WriteLine(dictionary.Keys);
            Console.WriteLine(dictionary.Values);


        }
    }
}

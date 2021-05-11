using System;
using System.Threading;

namespace ThreadLockTestApp
{
    class Counter 
    {
        private int count = 1000;
        private object thisLock = new object();
        public void Run ()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread th = new Thread(UnsafeCalc);
                th.Start();
            }
        }
        public void UnsafeCalc()
        {
            lock (thisLock)
            {
                count++;
                Thread.Sleep(1);
                Console.WriteLine(count);
            }    

            

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter obj = new Counter();
            obj.Run();
            /*

            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();
            th5.Start();
            th1.Join(); th2.Join(); th3.Join(); th4.Join(); th5.Join();
            Console.WriteLine(obj.Count);*/
        }
    }
}

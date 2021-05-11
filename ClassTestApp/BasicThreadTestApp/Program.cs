using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BasicThreadTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // DoSomething();
            Thread th1 = new Thread((DoSomething));
            th1.Start();
            th1.Interrupt();
            th1.Join();
            th1.Suspend();
            //th1.Join();
            DoOtherthing();
            th1.Abort();
             // 스레드를 Wait Join Sleep 상태일 때 중단메서드
        }

        private static void DoOtherthing()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoOtherthing : {i}");
                Thread.Sleep(10);
            }

        }

        private static void DoSomething()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);
            }
        }
    }
}

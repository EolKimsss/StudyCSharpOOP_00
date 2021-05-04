using System;
using System.Threading;

namespace UsingInterfaceTestApp
{
    
    class MainApp
    {
        static void Main(string[] args)
        {

                var monitor = new ExtendedMonitor(new ConsoleLogger(DateTime.Now));
                monitor.PrintLog("ConsoleLog");

                var monitor1 = new ExtendedMonitor(new FileLogger("210504.log"));
                monitor1.PrintLog("로그내용입니다.");

                Thread.Sleep(1000); // 시간딜레이

                monitor1.PrintLog("이하 오류가 발생했습니다.");
                Console.WriteLine("프로그램종료");
        }
    }
}

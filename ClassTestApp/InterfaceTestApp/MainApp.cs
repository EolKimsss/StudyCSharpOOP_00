using System;

namespace InterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {

            ILogger logger = new ConsoleLogger();
            logger.WriteLog("기본 콘솔 로그입니다.");
            logger.WriteError("에러메세지!!");

            ILogger clmLogger = new FileLogger();
            clmLogger.WriteLog("파일생성");
            clmLogger.WriteError("문제발생!");

            ILogger logger2 = new ClimateLogger();
            logger2.WriteLog("맑음");
        }
    }
}

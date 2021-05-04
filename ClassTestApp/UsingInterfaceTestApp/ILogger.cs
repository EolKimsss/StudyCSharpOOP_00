namespace UsingInterfaceTestApp
{ 
    // 약속이다. ILogger를 구현하게되면 아래의 액션을 무조건 구현해야한다.

    interface ILogger
    {
        void WriteLog(string message); // 하나의 메세지를 받아서 처리할 것.

    }
}

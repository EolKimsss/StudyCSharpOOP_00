using System;

namespace EventHandlerTestApp
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappend;

        public void DoSomething(int number)
        {
            string str = number.ToString();
            if (str.Contains("3") || str.Contains("6") || str.Contains("9"))
            {
                SomethingHappend($"{number} : 짝!\t");
            }
            else SomethingHappend($"{number}\t");
        }
    }
}

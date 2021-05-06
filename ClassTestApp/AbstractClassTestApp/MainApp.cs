using System;

namespace AbstractClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived(); // Parent로는 안됨 파생된 Child는 가능
            obj.PublicMethod();
            obj.AbstractMethod();
        }
    }
}

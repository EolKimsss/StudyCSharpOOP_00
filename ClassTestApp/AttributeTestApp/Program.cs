using System;

namespace AttributeTestApp
{
    public class Myclass
    {
        //properties

        [Obsolete("이 메서드는 폐기되었습니다. NewMethod()로 대체하세요.")]

        public void OldMethod() { Console.WriteLine("do something"); }
        public void NewMethod() { Console.WriteLine("do something new"); }

        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Divide(int a, int b)
        {
            return a % b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass mine = new Myclass();
            //mine.OldMethod();
            mine.NewMethod();

            var result = mine.Plus(3, 5);
            Console.WriteLine(result); ;
        }
    }
}

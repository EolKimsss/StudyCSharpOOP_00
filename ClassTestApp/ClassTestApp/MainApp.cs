using System;
using System.Collections;



namespace ClassTestApp
{
    class MainApp
    {

        static void Main(string[] args)
        {
            Console.WriteLine("고양이 객체 생성 :");
            Cat kitty = new Cat("키티",3);
            kitty.Age = 3;
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat nero = new Cat("네로",12)
            {
                Color = "검정"
            };
            nero.Meow();

            Cat mimi = new Cat("mimi", "노랑", 3);
            mimi.Meow();

            Cat aaa = new Cat("aa", "흰색");
            aaa.Meow();
            aaa.Sleep();

            var kkk = (123,456.345,"aaa",cat:aaa);
            Console.WriteLine(kkk.Item1.GetType()) ;
            Console.WriteLine(kkk.Item2.GetType());
            Console.WriteLine(kkk.Item3.GetType());
           // Console.WriteLine(kkk.Item4.GetType());
            kkk.Item1 ++;
            kkk.cat.Meow();

            //  Animal ak = new Cat();

        }
    }
}

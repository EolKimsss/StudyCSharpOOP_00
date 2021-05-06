using System;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("강아지 객체 생성");
            Dog baekgoo = new Dog();
            baekgoo.Age = 5;
            baekgoo.Name = "백구";
            Console.WriteLine($"{baekgoo.Name}의 나이는 {baekgoo.Age}");

            Dog dog1 = new()
            {
                Name = "abc",
                Age = 5

            };
        }
    }
}

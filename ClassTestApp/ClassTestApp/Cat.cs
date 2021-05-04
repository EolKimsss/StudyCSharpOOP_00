using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {

        public string Color { get; set; }
        public int Age { get; set; }
        public Cat() { }
        public Cat(string name, string color, int age)
        {
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
        public Cat(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void Meow() { Console.WriteLine($"{this.Color} {this.Name} {this.Age} 야옹!");}

        public override void Sleep()
        {
            base.Sleep(); // 부모 Sleep() 실행
            Console.WriteLine($"{this.Color}고양이 {this.Name}이(가) 쿨쿨잡니다.");
        }
    }
}

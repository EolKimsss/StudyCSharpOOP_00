using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        private int age;

        public string Name { get; set; } = "멍멍이";

        public int Age
        {
            //get { return age; }
            get => this.age;
            set 
            {
                if (value < 0) age = 1;
                else if (value > 15) age = 15;
                else age = value;
            }

        }

        public string GetAge() // 값을 사용
        {
            return $"{this.age}세";
        }
        public void SetAge(int age) // 값을 설정
        {
            if (age < 0) this.age = 1;
            else if (age > 15) this.age = 15;
            else this.age = age;
        }
    }
}

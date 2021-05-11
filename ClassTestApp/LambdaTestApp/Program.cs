using System;
using System.Linq;

namespace LambdaTestApp
{
    class Program
    {
        delegate void Dosomething();
        delegate string Concatenate(string[] arr);

        static void Main(string[] args)
        {
            Dosomething doIt = () =>
            {
                Console.WriteLine("Hello");
                Console.WriteLine("asdfad");
                return;
            };

            //doIt();

            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (var item in arr)
                {
                    result += item;
                    
                }
                return result;
            };
            string[] strarr = { "a", "aab", "ababab" };
            Console.WriteLine(concat(strarr));

            Func<int> func1 = () => 3;
            var val = func1();
            Console.WriteLine($"{ val}");

            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"{plus(3,5)}");

            Action<double> area = (r) =>
            {
                Console.WriteLine($"원의 넓이는 : {r * r * Math.PI}");
            };
            area(10);
        }
    }
}

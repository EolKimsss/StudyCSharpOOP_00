using System;
using System.Threading.Tasks;

namespace AsyncTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Caller();

            Console.ReadLine();
        }

        private static void Caller()
        {
            Console.WriteLine("Caller A");
            Console.WriteLine("Caller B");
            MyMethodAsync(3);
            Console.WriteLine("Caller E");
            Console.WriteLine("Caller F");
        }

        async private static void MyMethodAsync(int v)
        {
            Console.WriteLine("My C");
            Console.WriteLine("My D");
            await Task.Run(async () =>
            {

                for (int i = 1; i <= v; i++)
                {
                    Console.WriteLine($"{i}/{v}...");
                    await Task.Delay(1);
                }
                Console.WriteLine("My G");
                Console.WriteLine("My H");
            });
        }
    }
}

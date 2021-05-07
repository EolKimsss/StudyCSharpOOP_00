using System;

namespace DelegateTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine($"{calc.Plus(3, 5)}");

            CalcDelegate callback;
            callback = new CalcDelegate(calc.Plus);
        }
    }
}

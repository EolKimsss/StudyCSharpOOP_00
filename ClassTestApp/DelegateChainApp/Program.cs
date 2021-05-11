using System;
using System.Security.Cryptography.X509Certificates;

namespace DelegateChainApp
{
    delegate int Calculate(int a, int b);
    
    class Program
    {
        static void Main(string[] args)
        {
            #region
            FireStation station = new FireStation();
            ThereIsAFire fireHouse = new ThereIsAFire(station.Call119);
            fireHouse += new ThereIsAFire(station.ShotOut);
            fireHouse += new ThereIsAFire(station.Escape);
            fireHouse("우리집");
            Console.WriteLine();
            ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
            fireWoorim += new ThereIsAFire(station.Escape);
            fireWoorim("우림라이온스밸리A");
            #endregion
            Calculate calc;
            calc = (a, b) => a + b;
            Console.WriteLine(calc(3, 5));
            
        }
    }
}

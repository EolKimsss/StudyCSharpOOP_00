using System;
using System.Collections.Generic;

namespace ArrayClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int [] array = new int[] { 3, 2, 1, 6, 5, 4, 9,8,7,10 }; 
/*            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }*/
            Array.Sort(array);
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }

            Array.Reverse(array);
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
            /*
                        Array.Resize<int>(ref array, 11);
                        array[10] = 100;
                        foreach (var item in array)
                        {
                            Console.Write($"{item}\t");
                        }*/

            int[,] matrix1 = new int[2, 3] { { 1, 2, 3 }, { 6, 5, 4 } };
            int number = matrix1[0,1];
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
/*            int [] array = new int[] { 3, 2, 1, 6, 5, 4, 9,8,7,10 }; 
*//*            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }*//*
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
            *//*
                        Array.Resize<int>(ref array, 11);
                        array[10] = 100;
                        foreach (var item in array)
                        {
                            Console.Write($"{item}\t");
                        }*//*

            int[,] matrix1 = new int[2, 3] { { 1, 2, 3 }, { 6, 5, 4 } };
            int number = matrix1[0,1];*/

            ArrayList list = new ArrayList();
            ArrayList listan = new ArrayList();
            list.Add(10);
            list.Add(10);
            list.Add(10);
            list.Add(1);
            list.Add(2);
            //list.Add("dfsdf");

            //list.Remove(10);

            for (int i = 0; i < list.Count; ++i)
            {
                if ((int)list[i] == 10) listan.Add(i);
            }
            foreach (var item in listan)
                Console.WriteLine(item);

        }
    }
}

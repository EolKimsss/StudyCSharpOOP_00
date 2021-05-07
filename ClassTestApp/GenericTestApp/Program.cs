using System;
using System.ComponentModel;

namespace GenericTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length];

            Gene.CopyArray<int>(sourceInt, targetInt);
            foreach (var item in targetInt)
                Console.WriteLine(item);

            float[] sourceFloat = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length];
            Gene.CopyArray<float>(sourceFloat, targetFloat);
            foreach (var item in targetFloat)
                Console.WriteLine(item);

            string[] sourceString = { "a","b","c","d","e" };    
            string[] targetString = new string[sourceString.Length];
            Gene.CopyArray(sourceString, targetString);
            foreach (var item in targetString)
                Console.WriteLine(item);
            

        }


    }
}

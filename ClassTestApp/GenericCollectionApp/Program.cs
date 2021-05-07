using System;
using System.Collections.Generic;

namespace GenericCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic collection test");

            List<int> list = new List<int>();
            for(int i=1; i<=100;++i)
            {
                list.Add(i);
            }
            var sum = 0;
            list.RemoveRange(0, 10);
            foreach (var item in list)
                sum += item;
            Console.WriteLine(sum);


            Dictionary<string, int> dics1 = new Dictionary<string, int>();
            dics1["하나"] = 1;
            dics1["둘"] = 2;
            dics1["셋"] = 3;
            dics1["넷"] = 4;
            dics1["다섯"] = 5;

            Console.WriteLine(dics1["하나"]);

            Dictionary<int, string> dics2 = new Dictionary<int, string>();
            dics2[1] = "하나";
            dics2[2] = "둘";
            dics2[3] = "셋";
            dics2[4] = "넷";
            dics2[5] = "다섯";
            Console.WriteLine(dics2[1]);

            Dictionary<Dictionary<int, string>, int> dics = new Dictionary<Dictionary<int, string>, int>();
            

        }
    }
}

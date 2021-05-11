using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
/*            string fullPath = @"C:\Test\Help\PFRO.log";
            StreamReader str = new StreamReader(new FileStream(fullPath,FileMode.Open));

            while (str.EndOfStream == false)
            {
                Console.WriteLine(str.ReadLine());
            }
            str.Close();*/
            // 텍스트파일 읽어오는 부분

            string writePath = @"C:\Test\Help\EulKim.txt";
            StreamWriter sw = new StreamWriter(new FileStream(writePath, FileMode.Create));
            sw.Write("Ajou University Software Eul Kim");
            sw.Close(); // close 없으니까 안써지네
            Console.WriteLine("써짐");


        }
    }
}

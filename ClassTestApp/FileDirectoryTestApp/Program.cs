using System;
using System.IO;

namespace FileDirectoryTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
/*            string path = @"C:\GitRepository\StudyCSharpOOP_00";
            var dirs = Directory.GetDirectories(path);
            // 하위폴더 전부 가져오기
           // var aaa = Directory.GetFiles(path);
            var bbb = Directory.GetCurrentDirectory();
           // Console.WriteLine(bbb);

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
                var dirInfo = new DirectoryInfo(item);
                Console.WriteLine($"{dirInfo.Name} / {dirInfo.Attributes} / {dirInfo.CreationTime}");
            }

            var files = Directory.GetFiles(path);
            foreach (var item in files)
            {
                Console.WriteLine(item);
                var fileInfo = new FileInfo(item);
                Console.WriteLine($"{fileInfo.Name}/ {fileInfo.Attributes}/{fileInfo.CreationTime}/{fileInfo.Length}");
            }*/

            string newPath = @"C:\Test\Help"; // 디렉토리 , 파일을 생성할 위치
            while (true)
            {
                var input = Console.ReadLine();
                int dirNum = 0;

                if (input == "X" || input == "x")
                {
                    break;

                }
                else
                {
                    if (input == "file")
                    {
                        var fileName = $"SampleFile_{DateTime.Now.ToString("yyMMddHHmmss")}.txt";
                        var fullPath = $@"{newPath}\{fileName}";
                        File.Create(fullPath);
                    }
                    else if (input == "dir")
                    {
                        var dirName = "Sampledirectory";
                        var fullPath = $@"{newPath}\{dirName}";
                        if (!Directory.Exists(fullPath))
                        {
                            Directory.CreateDirectory(fullPath);
                        }
                        else 
                        {
                            dirNum++;
                            fullPath = $@"{newPath}\{dirName}{dirNum}";
                            Directory.CreateDirectory(fullPath);
                        }
                        Console.WriteLine("디렉토리생성");
                    }
                    else
                    {
                        Console.WriteLine("input must be file or dir");
                    }
                }
            }
            Console.WriteLine("exit");

            //24명 
        }
    }
}

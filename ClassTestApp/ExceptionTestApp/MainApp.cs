using System;
using System.Collections.Generic;

namespace ExceptionTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] list = new int[3];
            try
            {
                for (int i = 0; i < 3; ++i)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException 발생");
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DivideByZeroException 발생");
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("NullReferenceException 발생");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("항상 실행");
            }
        }
    }
}

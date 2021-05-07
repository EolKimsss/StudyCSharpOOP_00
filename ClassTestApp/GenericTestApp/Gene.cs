using System;

namespace GenericTestApp
{
    class Gene
    {
        public static void CopyArray<T>(T[] source, T[] target)
        {
            try
            {
                for (int i = 0; i < source.Length; ++i)
                    target[i] = source[i];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

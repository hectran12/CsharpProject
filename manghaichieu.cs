using System;
using System.Text;

namespace manghaichieu
{ 
    class Program
    {
        static void Main (string[] args)
        {
            int SoDong = 3, SoCot = 3;
            int[,] arr = new int[SoDong, SoCot];
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    arr[i, j] = (i + 1) * j;
                }
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}

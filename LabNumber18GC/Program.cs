using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber18GC
{
    class Program
    {
        static void Main(string[] args)
        {
            //1a.

            TheMostAwesomeList MAL_EVER = new TheMostAwesomeList();
            
            MAL_EVER.Add("James");
            MAL_EVER.Add("Jackson");
            MAL_EVER.Add("John");


            MAL_EVER.PrintINfo();
            MAL_EVER.RemoveAll("Jackson");
            MAL_EVER.PrintINfo();



            //2a.

            int[] array = new int[] { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
            int[] freq = new int[array.Length];

            for (int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array.Length; y++)
                {
                    if (array[y] == x)
                        freq[x]++;
                }
            }

            for (int x = 0; x < array.Length; x++)
            {
                if (freq[x] != 0)
                {
                    Console.WriteLine("[" + x + "]:" + freq[x]);
                }
            }

        }
    }
}

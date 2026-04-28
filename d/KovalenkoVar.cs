using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d
{
    public static class KovalenkoVar
    {
        public static void Run(ref int[][] arr)
        {
            RemoveEvenRows(ref arr);
        }

        static void RemoveEvenRows(ref int[][] a)
        {
            if (a.Length == 0)
                return;

            int newSize = a.Length / 2;

            if (newSize == 0)
            {
                a = new int[0][];
                return;
            }

            int[][] b = new int[newSize][];
            int k = 0;

            for (int i = 1; i < a.Length; i += 2)
            {
                b[k] = a[i];
                k++;
            }

            a = b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrary_Search_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 0, 1, 1, 5, 7, 9, 12, 12, 13, 14, 21 };
            Console.WriteLine(Tetrary_Search(data,0,11,7));
            Console.ReadKey();
        }
        /// <summary>
        /// algorithm gives you the indxes, where is the value, which you are looking for
        /// </summary>
        /// <param name="array">the aray in which we are looking for the value</param>
        /// <param name="f">it's the variable, which means the first index int the interval</param>
        /// <param name="l">it's the variable, which means the last index int the interval</param>
        /// <param name="s">it's the variable, which means the searched value </param>
        /// //the tetrary search algorithm assumes that the array is sorted increasingly
        public static int Tetrary_Search(int[] array, int f, int l, int s)
        {
            if (f >= l && array[f] == s) return f;
            else if (f >= l) return -1;
            int mid1 = f + (l - f) / 3;
            int mid2 = f + (l - f) * 2 / 3;
            if (array[mid1] >= s) return Tetrary_Search(array, f, mid1, s);
            else if (array[mid2] >= s) return Tetrary_Search(array, mid1 + 1, mid2, s);
            else return Tetrary_Search(array, mid2 + 1, l, s);
        }
    }
}

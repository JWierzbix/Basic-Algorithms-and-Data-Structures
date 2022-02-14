using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_RECURSION
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 2, 2, 3, 4, 6, 8, 11, 16 };
            Console.WriteLine(Binary_Search(data, 0, 9, 3));
            Console.ReadKey();
        }
        /// <summary>
        /// algorithm gives you the indxes, where is the value, which you are looking for
        /// </summary>
        /// <param name="array">the aray in which we are looking for the value</param>
        /// <param name="f">it's the variable, which means the first index int the interval</param>
        /// <param name="l">it's the variable, which means the last index int the interval</param>
        /// <param name="s">it's the variable, which means the searched value </param>
        //the binary search algorithm assumes that the array is sorted increasingly

        public static int Binary_Search(int[] array, int f, int l, int s)
        {
            if (f >= l && array[f] == s) return f;
            else if (f >= l) return -1;

            int m = (f + l) / 2;
            if (array[m] >= s) return Binary_Search(array, f, m, s);
            else return Binary_Search(array, m + 1, l, s);
        }
    }
}

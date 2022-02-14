using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_leader_of_first_raw
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 2, 2, 3, 4, 5, 2, 2, 7, 2, 2, 1, 1, 2, 2, 2 };
            Console.WriteLine(ArrayLeader(data,0,16));
            Console.ReadKey();
        }
        /// <summary>
        /// the algorithm returns value of the element that is the most frequent int the array (>50%)
        /// </summary>
        /// <param name="Array"></param>
        /// <param name="l">left side</param>
        /// <param name="r">right side</param>
        /// <returns>the value of the most frequent element in the array</returns>
        public static int ArrayLeader(int[] Array, int l, int r)
        {            
            if (l >= r) return Array[l];
            int mid = (l + r) / 2;
            int leader1 = ArrayLeader(Array, l, mid);
            int leader2 = ArrayLeader(Array, mid + 1, r);
            int countert1 = 0, counter2 = 0;
            for (int i = l; i <= r; i++)
            {
                if (Array[i] == leader1) countert1++;
                else if (Array[i] == leader2) counter2++;
            }
            if (countert1 > counter2) return leader1;
            else return leader2;
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Raw_Leader_Search_ITERATION
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 2, 4, 2, 1, 2, 2, 7, 2, 1, 1, 2 };
            Console.WriteLine(Leader_Search(data));
            Console.ReadKey();
        }
        //we ssume that leader must be frequent more than 50% of the size of the array, because otherwise it won't work
        //when we assume that we know that at least in one pair we have two uniqe elements with the same value
        public static int Leader_Search(int[] array)
        {
            if (array.Length < 1) return -1;
            int leader = array[0];
            int count = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (count == 0)
                {
                    leader = array[i];
                    count = 1;
                }
                else if (leader == array[i]) count++;
                else count--;
            }
            return leader;
        }
    }
}

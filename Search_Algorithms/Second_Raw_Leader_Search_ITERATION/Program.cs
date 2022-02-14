using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Raw_Leader_Search_ITERATION
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 2, 2, 1, 1, 3, 4, 5, 1, 2, 1, 2, 5, 6, 7, 8, 9, 1, 1, 2, 3, 1, 1, 1, 2, 2, 2, 2 };
            Leader2_Search(data);
            Console.ReadKey();
        }
        //the algorithm returns to us two elements, that are more frequent than 33% in array
        public static void Leader2_Search(int[] array)
        {
            if (array.Length < 2) throw new Exception("the array is too short");
            int leader1 = array[0];
            int leader2 = array[1];
            int counter1 = 1, counter2 = 1;
            for (int i = 2; i < array.Length; i++)
            {
                if (counter1 == 0)
                {
                    leader1 = array[i];
                    counter1 = 1;
                }
                else if (counter2 == 0)
                {
                    leader2 = array[i];
                    counter2 = 1;
                }
                else if (array[i] == leader1) counter1++;
                else if (array[i] == leader2) counter2++;
                else { counter1--; counter2--; }
            }
            Console.WriteLine($"leader 1: {leader1}   leader2: {leader2}");
        }
    }
}

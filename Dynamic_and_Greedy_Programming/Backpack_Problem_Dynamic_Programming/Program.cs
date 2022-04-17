using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backpack_Problem_Dynamic_Programming
{
    class Program
    {
        //the algorithm assumes that we can use each item only once
        static void Main(string[] args)
        {
            Item[] items = { new Item(23, 45), new Item(15, 60), new Item(21, 17), new Item(13, 28), new Item(21, 51) };
            Console.WriteLine(Backpack(items,50));
            Console.ReadKey();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="items">the array with items, their value and weight</param>
        /// <param name="load">the maximum load that our bag is able to hold</param>
        /// <returns>the optimmum (maximal) value that we can put in bagpack</returns>
        public static int Backpack(Item[] items, int load)
        {
            int[,] DP = new int[items.Length+1, load + 1];
            for (int i = 1; i < DP.GetLength(0); i++)
            {
                int k = i - 1; //index of current item in array
                for (int j = 1; j < DP.GetLength(1); j++)
                {
                    if (j - items[k].weight >= 0)
                    {
                        DP[i, j] = Math.Max(DP[i - 1, j], DP[i - 1, j - items[k].weight] + items[k].value);
                        DP[i, j] = Math.Max(DP[i, j],DP[i,j-1]);
                    }
                    else DP[i, j] = DP[i - 1, j];
                }                
            }
            return DP[DP.GetLength(0) - 1, DP.GetLength(1) - 1];
        }
    }
    class Item
    {
        public int weight;
        public int value;
        public Item(int w, int v)
        {
            weight = w;
            value = v;
        }
    }
}

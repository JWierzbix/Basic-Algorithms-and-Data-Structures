using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Lightest_Road_DYNAMIC_PROGRAMMING
{
    class Program
    {//We have the maze and for each step you get the cost. We have to find the way where the cost is the smallest.
     //the algorithm finds the way to achieve this aim using dynamic programming.
        static void Main(string[] args)
        {
            int[,] right = { {1 ,5 },
                             {2 ,1 },
                             {2 ,4 } };
            int[,] down = { {3, 1, 4},
                            {1, 2, 1} };
            Console.WriteLine(Road(down, right, 3, 3));
            Console.ReadKey();
        }
        public static int Road(int[,] down, int[,] right, int high, int width)
        {
            int[,] DP = new int[high,width];
            for (int i = 1; i < high; i++)
            {
                DP[i, 0] = down[i-1, 0] + DP[i-1,0];
            }
            for (int i = 1; i < width; i++)
            {
                DP[0, i] = right[0, i-1] + DP[0,i-1];
            }
            for (int i = 1; i < DP.GetLength(0); i++)
            {
                for (int j = 1; j < DP.GetLength(1); j++)
                {
                    DP[i, j] = Math.Min(DP[i - 1, j] + down[i - 1, j], DP[i, j - 1] + right[i, j - 1]);
                }
            }
            return DP[high-1,width-1];
        }
    }
}

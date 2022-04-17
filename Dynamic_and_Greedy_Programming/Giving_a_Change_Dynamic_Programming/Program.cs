using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giving_a_Change_Dynamic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] money = { 25, 20, 10, 5, 2, 1 };
            Console.WriteLine(Change(money,40));
            Console.ReadKey();
        }
        public static int Change(int[] money, int change)
        {
            int[] DP = new int[change + 1];
            for (int i = 1; i < DP.Length; i++)
            {
                DP[i] = int.MaxValue;
                for (int j = 0; j < money.Length; j++)
                {
                    if(i - money[j] >= 0)
                    {
                        DP[i] = Math.Min(DP[i],DP[i- money[j]]+1);
                    }
                }                
            }
            return DP[change];
        }
    }
}

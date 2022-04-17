using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giving_a_change_GREEDY_ALGORITHM
{
    public class Program
    {
        //giving a change - greedy algorithm
        static void Main(string[] args)
        {
            int[] money = { 25, 20, 10, 5, 3, 2, 1 };
            Console.WriteLine(Change(money,40));
            Console.ReadKey();
        }
        public static int Change(int[] money, int change)
        {            
            int counter = 0;//the variable that tells how many coins do I have to give
            for (int i = 0; i < money.Length; i++)
            {
                if(change - money[i] >= 0)
                {
                    counter += change / money[i];
                    change %= money[i];
                }
            }
            return counter;
        }
    }
}

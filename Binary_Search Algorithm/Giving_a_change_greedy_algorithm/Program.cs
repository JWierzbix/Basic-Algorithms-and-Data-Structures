using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giving_a_change_greedy_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 25, 20, 10, 5, 2, 1 };
            Console.WriteLine(Change(data,40));
            Console.ReadKey();
        }
        /// <summary>
        /// it returns the number of each currency values, which are required to give a change
        /// </summary>
        /// <param name="currency">avaiable currency values</param>
        /// <param name="change">the change we have to give to customer</param>
        /// <returns>number of notes w give the customer in return</returns>
        // Attention! This code doesn't always give you the optimum solution. The greedy method isn't the most efficient method in this situation.
        public static int Change(int[] currency, int change)
        {
            int counter = 0;
            for (int i = 0; i < currency.Length; i++)
            {
                if(change - currency[i] >= 0)
                {
                    counter += change / currency[i];
                    change %= currency[i];
                }
            }
            return counter;
        }
    }
}

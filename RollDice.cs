using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RollDice
{
    internal class RollDice
    {
        private int Rolls;


        // Constructor
        public RollDice()
        {
            Rolls = 0;
        }
       
        public int[] RollingSimulator(int Rolls)
        {
            // the array stores the total num of results for 2-12, in total 11 numbers
            // array[0] = the num of 2s, array[1] = the num of 3s, array[2] = the num of 4s and so on
            int[] results = new int[11];
            Random random = new Random();

            for (int count = 0; count <= Rolls; count++)
            {

                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int result = dice1 + dice2;

                // since the results will be between 2-12, to locate the correct index for the corresponding result will be "result - 2" (aka 0-10)
                results[(result - 2)]++;
            }

            return results;
        
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class RandomNumber

    {
        public static void Roll_The_Die()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("random number is " + dice);
        }
    }
}

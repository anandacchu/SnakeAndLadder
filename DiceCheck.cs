using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame.DiceCheck
{
    internal class DiceCheck

    {
        public static void CheckOption()
        {
            Random random = new Random();
            int check = random.Next(4);
            Console.WriteLine("Dice Number is " + check);
            if (check ==0)
            {
                Console.WriteLine("No play and player stays in the same position");
            }
            else if (check ==1)
            {
                Console.WriteLine("Ladder : Move ahead by the number of position received in ThreadExceptionEventArgs die");

            }
            {
                Console.WriteLine("Snake :Move ahead by the number of position received in ThreadExceptionEventArgs die");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAndTernaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            int num1 = 50;
            int num2 = 10;

            if (num1 > num2)
            {
                Console.WriteLine("The first number is greater than the second.");
            }
            else
            {
                Console.WriteLine("The first number is less than the second.");
            }
            Console.ReadLine();

            // Part 2
            int player1 = 80;
            int player2 = 90;
            int player3 = 100;

            if ((player1 > player2) && (player1 > player3))
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if ((player2 > player1) && (player2 > player3))
            {
                Console.WriteLine("Player 2 wins!");
            }
            else
            {
                Console.WriteLine("Player 3 wins!");
            }
            Console.ReadLine();

            // Part 3
            string winOrLose = (50 > 10) ? "You win!" : "You lose...";
            Console.WriteLine(winOrLose);
            Console.ReadLine();
        }
    }
}

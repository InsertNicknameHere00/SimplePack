using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePack
{
    internal class GuessTheNumber : MainHub
    {
        int diceNum = 0;
        int winChance = 0;
        List<int> diceList = new List<int>();

        public void diceRollEnterCheck()
        {
            Console.Clear();
            Console.WriteLine("If you want to enter: \n -> Give Y as answer;");
            Console.WriteLine();
            Console.WriteLine("If you want to go back to the main menu: \n -> Give N as answer;");
            String decisionentercheck = Console.ReadLine();

            if (decisionentercheck == "Y")
            {
                DiceRoll();
            }
            if (decisionentercheck == "y")
            {
                DiceRoll();
            }
            if (decisionentercheck == "N")
            {
                Console.Clear();
                StartHub();
            }
            if (decisionentercheck == "n")
            {
                Console.Clear();
                StartHub();
            }
        }

        public void DiceRoll() {
            Console.Clear();
            Random random = new Random();

            // Generating the random numbers and putting them in the list!
            for (int i = 0; i < 6; i++)
            {
                diceNum = random.Next(1, 47);
                diceList.Add(diceNum);
            }
            Console.WriteLine("Number pulling finished. \n Try to guess the 6 numbers between 1 and 47!");

            //Time to guess the numbers!
            rollNumbers();
        }

        public void rollNumbers()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write(" \n Enter a number: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (diceList.Contains(guess))
                {
                    Console.WriteLine("You guessed the number: " + guess);
                    winChance++;
                }
                else
                {
                    Console.WriteLine("Wrong number! Try again!");
                }
            }
            winCheck();
        }

        public void winCheck()
        {
            if (winChance == 6)
            {
                Console.WriteLine("Jackpot!");
                Thread.Sleep(4000);
            }
            else
            {
                Console.WriteLine(" \n You guessed " + winChance + " numbers correctly. Try again next time!");
                Thread.Sleep(4000);
            }
            replayCheck();
        }

        public void replayCheck() {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Would you like to play again? Y/N");
            string decisionleavecheck = Console.ReadLine();

            if (decisionleavecheck == "Y")
            {
                Console.Clear();
                DiceRoll();
            }

            if (decisionleavecheck == "N")
            {
                Console.Clear();
                Console.WriteLine("See you!");
                Thread.Sleep(1000);
                Console.Clear();
                StartHub();
            }

            if (decisionleavecheck == "y")
            {
                Console.Clear();
                DiceRoll();
            }

            if (decisionleavecheck == "n")
            {
                Console.Clear();
                Console.WriteLine("See you!");
                Thread.Sleep(1000);
                Console.Clear();
                StartHub();
            }
        }

    }
}

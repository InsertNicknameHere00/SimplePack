using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePack
{
    internal class MainHub
    {
        // Options for the user to choose from (Pushed into a string array)
        List<string> options = new List<string>(){
            "1. Calculator",
            "2. Dice Roller",
            "3. Journal",
            "4. Deal Or no Deal",
            "0. Exit"
        };

        public void EnterCalc() {
            Console.Clear();
            Calculator calculator = new Calculator();
            calculator.calculatorEnterCheck();
        }

        public void EnterJournal() {
            Console.Clear();
            Journal journal = new Journal();
            journal.JournalEnterCheck();
        }

        public void EnterDeal() {
            Console.Clear();
            DealOrNoDeal dealOrNoDeal = new DealOrNoDeal();
            dealOrNoDeal.EnterDeal();
        }

        public void LeaveApp() {
            Console.Clear();
            Console.WriteLine("The World is a weird place...some even say that dividing by 0 will destroy the fabric of reality...");
            Thread.Sleep(3000);
            Console.Clear();
            Environment.Exit(0);
        }

        public void EnterDice() {
            Console.Clear();
            GuessTheNumber guessTheNumber = new GuessTheNumber();
            guessTheNumber.diceRollEnterCheck();
        }

        public void StartHub() {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\r\n  __  __       _         _    _       _     \r\n |  \\/  |     (_)       | |  | |     | |    \r\n | \\  / | __ _ _ _ __   | |__| |_   _| |__  \r\n | |\\/| |/ _` | | '_ \\  |  __  | | | | '_ \\ \r\n | |  | | (_| | | | | | | |  | | |_| | |_) |\r\n |_|  |_|\\__,_|_|_| |_| |_|  |_|\\__,_|_.__/ \r\n                                            \r\n                                            \r\n");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine();

            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

            Console.WriteLine();
            int decision = int.Parse(Console.ReadLine());

            switch (decision) {

                case 1:
                    EnterCalc();
                    break;

                    case 2:
                    EnterDice();
                    break;

                case 3:
                    EnterJournal();
                    break;

                case 4:
                    EnterDeal();
                    break;

                case 0:
                    LeaveApp();
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}

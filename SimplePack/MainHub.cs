using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePack
{
    internal class MainHub
    {
        // Options for the user to choose from (Pushed into a String array)
        String[] options = new String[] {
            "1. Calculator",
            "2. Dice Roller",
            "0. Exit"
        };

        public void EnterCalc() {
            Console.Clear();
            Calculator calculator = new Calculator();
            calculator.calculatorEnterCheck();
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
            Console.WriteLine("What do you want to do?");

            foreach (String option in options)
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

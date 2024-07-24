using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePack
{
    internal class DealOrNoDeal : MainHub
    {
        List<string> options = new List<string>(){
            "1. Play",
            "2. View Balance",
            "3. Go back to the main menu",
            "0. Exit"
        };

        List<object> Boxes = new List<object>();
        List<int> BoxMoney = new List<int>() {
            0,
            0,
        500,
        1000,
        250,
        100,
        };

        List<int> OpenedBoxes = new List<int>();

        int Chances = 3;
        int TotalSum = 0;
        int startBalance = 200;
        public void LeaveApp()
        {
            Console.Clear();
            Console.WriteLine("The World is a weird place...some even say that dividing by 0 will destroy the fabric of reality...");
            Thread.Sleep(3000);
            Console.Clear();
            Environment.Exit(0);
        }
        public void EnterDeal()
        {
            Console.Clear();
            Console.WriteLine("If you want to enter: \n -> Give Y as answer;");
            Console.WriteLine();
            Console.WriteLine("If you want to go back to the main menu: \n -> Give N as answer;");
            string decisionentercheck = Console.ReadLine();

            switch (decisionentercheck)
            {

                case "Y":
                    DealDecision();
                    break;

                case "y":
                    DealDecision();
                    break;

                case "N":
                    Console.Clear();
                    StartHub();
                    break;

                case "n":
                    Console.Clear();
                    StartHub();
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        public void DealDecision()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\r\n  _____             _                _   _         _____             _ \r\n |  __ \\           | |              | \\ | |       |  __ \\           | |\r\n | |  | | ___  __ _| |   ___  _ __  |  \\| | ___   | |  | | ___  __ _| |\r\n | |  | |/ _ \\/ _` | |  / _ \\| '__| | . ` |/ _ \\  | |  | |/ _ \\/ _` | |\r\n | |__| |  __/ (_| | | | (_) | |    | |\\  | (_) | | |__| |  __/ (_| | |\r\n |_____/ \\___|\\__,_|_|  \\___/|_|    |_| \\_|\\___/  |_____/ \\___|\\__,_|_|\r\n                                                                       \r\n                                                                       \r\n");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            int decision = int.Parse(Console.ReadLine());

            switch (decision)
            {
                case 1:
                    PlayDealCheck();
                    break;

                case 2:
                    ViewStats();
                    break;

                case 3:
                    StartHub();
                    break;

                case 0:
                    LeaveApp();
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
        public void PlayDealCheck()
        {
            Console.Clear();
            Console.WriteLine("To enter the game, put down 100$.");
            Console.WriteLine("Your current balance is: " + startBalance + "$");
            Console.WriteLine();
            Console.WriteLine("To put down 100$: \n -> Give Y as answer;");
            Console.WriteLine();
            Console.WriteLine("If you want to go back to the main menu: \n -> Give N as answer;");
            Console.WriteLine();
            string decision = Console.ReadLine();
            switch (decision) {
                case "Y":
                                    if (startBalance >= 100)
                {
                    startBalance -= 100;
                    BoxRoll();
                }
                else
                {
                    Console.WriteLine("You don't have enough money to play the game!");
                    Thread.Sleep(3000);
                    DealDecision();
                }
                break;

                    case "N":
                    Console.Clear();
                    DealDecision();
                    break;

                    case "y":
                    if (startBalance >= 100)
                    {
                        startBalance -= 100;
                        BoxRoll();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money to play the game!");
                        Thread.Sleep(3000);
                        DealDecision();
                    }
                    break;

                    case "n":
                    Console.Clear();
                    DealDecision();
                    break;

                    default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        public void BoxRoll()
        {
            Random random = new Random();

            for (int i = 1; i < 7; i++)
            {
                Boxes.Add(random.Next(1, BoxMoney.Count + 1));
            }
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine(Boxes.Count + " Boxes rolled!");
            Thread.Sleep(1000);
            PlayDeal();
        }

        public void PlayDeal()
        {
            Console.Clear();
            Console.WriteLine("You have 3 chances to guess the boxes with money in them!");
            Console.WriteLine();
            Console.WriteLine("Total amount of boxes is " + Boxes.Count + "\n Enter the number of the box you want to open: ");
            while (Chances > 0)
            {
                string decision = Console.ReadLine();
                switch (decision)
                {
                    case "1":
                        if (OpenedBoxes.Count > 0 && OpenedBoxes[0].Equals(BoxMoney[0])){
                            Console.WriteLine(decision + " has already been opened!");
                            break;
                        }
                        else {
                            TotalSum += Convert.ToInt32(BoxMoney[0]);
                            Chances--;
                            Console.WriteLine("You open the box: " + BoxMoney[0].ToString() + "\n You have " + Chances + " chances left!");
                            OpenedBoxes.Add(BoxMoney[0]);
                            Console.WriteLine("The money you have won until now: " + TotalSum);
                            break;
                        }

                    case "2":
                        if (OpenedBoxes.Count > 0 && OpenedBoxes[1].Equals(BoxMoney[1]))
                        {
                            Console.WriteLine(decision + " has already been opened!");
                            break;
                        }
                        else
                        {
                            TotalSum += Convert.ToInt32(BoxMoney[1]);
                            Chances--;
                            Console.WriteLine("You open the box: " + BoxMoney[1].ToString() + "\n You have " + Chances + " chances left!");
                            OpenedBoxes.Add(BoxMoney[1]);
                            Console.WriteLine("The money you have won until now: " + TotalSum);
                            break;
                        }

                    case "3":
                        if (OpenedBoxes.Count > 0 && OpenedBoxes[2].Equals(BoxMoney[2]))
                        {
                            Console.WriteLine(decision + " has already been opened!");
                            break;
                        }
                        else
                        {
                            TotalSum += Convert.ToInt32(BoxMoney[2]);
                            Chances--;
                            Console.WriteLine("You open the box: " + BoxMoney[2].ToString() + "\n You have " + Chances + " chances left!");
                            OpenedBoxes.Add(BoxMoney[2]);
                            Console.WriteLine("The money you have won until now: " + TotalSum);
                            break;
                        }

                    case "4":
                        if (OpenedBoxes.Count > 0 && OpenedBoxes[3].Equals(BoxMoney[3]))
                        {
                            Console.WriteLine(decision + " has already been opened!");
                            break;
                        }
                        else
                        {
                            TotalSum += Convert.ToInt32(BoxMoney[3]);
                            Chances--;
                            Console.WriteLine("You open the box: " + BoxMoney[3].ToString() + "\n You have " + Chances + " chances left!");
                            OpenedBoxes.Add(BoxMoney[3]);
                            Console.WriteLine("The money you have won until now: " + TotalSum);
                            break;
                        }

                    case "5":
                        if (OpenedBoxes.Count > 0 && OpenedBoxes[4].Equals(BoxMoney[4]))
                        {
                            Console.WriteLine(decision + " has already been opened!");
                            break;
                        }
                        else
                        {
                            TotalSum += Convert.ToInt32(BoxMoney[4]);
                            Chances--;
                            Console.WriteLine("You open the box: " + BoxMoney[4].ToString() + "\n You have " + Chances + " chances left!");
                            OpenedBoxes.Add(BoxMoney[4]);
                            Console.WriteLine("The money you have won until now: " + TotalSum);
                            break;
                        }

                    case "6":
                        if (OpenedBoxes.Count > 0 && OpenedBoxes[5].Equals(BoxMoney[5]))
                        {
                            Console.WriteLine(decision + " has already been opened!");
                            break;
                        }
                        else
                        {
                            TotalSum += Convert.ToInt32(BoxMoney[5]);
                            Chances--;
                            Console.WriteLine("You open the box: " + BoxMoney[5].ToString() + "\n You have " + Chances + " chances left!");
                            OpenedBoxes.Add(BoxMoney[5]);
                            Console.WriteLine("The money you have won until now: " + TotalSum);
                            break;
                        }

                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            Thread.Sleep(1000);
            replayCheck();
        }

        public void replayCheck()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("You have won: " + TotalSum + "$");
            Console.WriteLine("Would you like to add them to your balance? Your current balance is: " + startBalance + "$");
            Console.WriteLine("If you want to add them to your balance: \n -> Give Y as answer;");
            Console.WriteLine();
            Console.WriteLine("If you want to go back to the main menu: \n -> Give N as answer;");
            Console.WriteLine();
            string decisionleavecheck = Console.ReadLine();

            switch (decisionleavecheck)
            {
                case "Y":
                    startBalance += TotalSum;
                    Chances = 3;
                    TotalSum = 0;
                    Console.WriteLine("Your new balance is: " + startBalance + "$");
                    Thread.Sleep(3000);
                    Console.Clear();
                    DealDecision();
                    break;

                case "N":
                    Console.Clear();
                    Chances = 3;
                    TotalSum = 0;
                    DealDecision();
                    break;

                case "y":
                    startBalance += TotalSum;
                    Chances = 3;
                    TotalSum=0;
                    Console.WriteLine("Your new balance is: " + startBalance + "$");
                    Thread.Sleep(3000);
                    Console.Clear();
                    DealDecision();
                    break;

                case "n":
                    Console.Clear();
                    Chances = 3;
                    TotalSum = 0;
                    DealDecision();
                    break;
            }
        }

        public void ViewStats()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\r\n  ____        _                      \r\n |  _ \\      | |                     \r\n | |_) | __ _| | __ _ _ __   ___ ___ \r\n |  _ < / _` | |/ _` | '_ \\ / __/ _ \\\r\n | |_) | (_| | | (_| | | | | (_|  __/\r\n |____/ \\__,_|_|\\__,_|_| |_|\\___\\___|\r\n                                     \r\n                                     \r\n");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Your current balance is: " + startBalance + "$");
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.WriteLine("If you want to go back to the main menu: \n -> Give Y as answer;");
            string decisionentercheck = Console.ReadLine();
            switch (decisionentercheck)
            {
                case "Y":
                    Console.Clear();
                    DealDecision();
                    break;

                case "y":
                    Console.Clear();
                    DealDecision();
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
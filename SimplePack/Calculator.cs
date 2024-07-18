using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePack
{
    internal class Calculator : MainHub
    {

        public void calculatorEnterCheck() {
            Console.Clear();
            Console.WriteLine("If you want to enter: \n -> Give Y as answer;");
            Console.WriteLine();
            Console.WriteLine("If you want to go back to the main menu: \n -> Give N as answer;");
            String decisionentercheck = Console.ReadLine();

            switch (decisionentercheck) { 

            case "Y":
                calculator();
                break;

                    case "N":
                    Console.Clear();
                        StartHub();
                        break;

                    case "y":
                    calculator();
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

        public void calculator() {
                Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("|| Calculator ||");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("What do you want to do? \n A. is for addition; \n B. is for Substraction; \n C. is for Multiplying; \n D. is for Dividing;");
            string decision = Console.ReadLine();

            switch (decision) {
                case "A":
                    Console.WriteLine("The result is: " + (number1 + number2));
                    break;

                case "a":
                    Console.WriteLine("The result is: " + (number1 + number2));
                    break;

                    case "B":
                    Console.WriteLine("The result is: " + (number1 - number2));
                    break;

                    case "b":
                        Console.WriteLine("The result is: " + (number1 - number2));
                    break;

                    case "C":
                    Console.WriteLine("The result is: " + (number1 * number2));
                    break;

                case "c":
                    Console.WriteLine("The result is: " + (number1 * number2));
                    break;

                case "D":
                    Console.WriteLine("The result is: " + (number1 / number2));
                    break;

                case "d":
                    Console.WriteLine("The result is: " + (number1 / number2));
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Would you like to calculate something again or leave? \n Enter C for calculate or L for leave!");
            string decisionleavecheck = Console.ReadLine();

            if(decisionleavecheck == "C") {
                Console.Clear();
                calculator();
            }

            if (decisionleavecheck == "L") {
                Console.Clear();
                Console.WriteLine("See you!");
                Thread.Sleep(1000);
                Console.Clear();
                StartHub(); 
            }

            if (decisionleavecheck == "c")
            {
                Console.Clear();
                calculator();
            }

            if(decisionleavecheck == "l")
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

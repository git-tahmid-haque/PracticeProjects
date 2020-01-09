using System;
using System.Collections.Generic;

// Things learnt:
//  - Better understanding of switch statement
//  - Further use of the Int.TryParse method

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int inputOne = 0;
            int inputTwo = 0;
            string inputOperator = "";

            string userInputOne = "";
            string userInputTwo = "";

            int output = 0;


            //Methods
            void GetFirstInput()
            {
                Console.WriteLine("Enter first number");
                userInputOne = Console.ReadLine();
            }

            void GetSecondInput()
            {
                Console.WriteLine("Enter second number");
                userInputTwo = Console.ReadLine();
            }

            void GetArithmeticOperator()
            {
                Console.WriteLine("Enter arithmetic operator");
                inputOperator = Console.ReadLine();
                CalculateResult();
            }

            void CalculateResult()
            {
                switch (inputOperator)
                {
                    case "+":
                        output = inputOne + inputTwo;
                        break;
                    case "-":
                        output = inputOne - inputTwo;
                        break;
                    case "x":
                        output = inputOne * inputTwo;
                        break;
                    case "*":
                        output = inputOne * inputTwo;
                        break;
                    case "/":
                        output = inputOne / inputTwo;
                        break;
                    default:
                        Console.WriteLine("Please enter +, -, /, x or *");
                        GetArithmeticOperator();
                        break;
                }
            }


            //Get first input
            GetFirstInput();
            bool isInputOneNumeric = int.TryParse(userInputOne, out inputOne);

            while (isInputOneNumeric == false)
            {
                Console.WriteLine("This is not a number. Please enter a number.");
                GetFirstInput();
                isInputOneNumeric = int.TryParse(userInputOne, out inputOne);
            }

            //Get second input
            GetSecondInput();
            bool isInputTwoNumeric = int.TryParse(userInputTwo, out inputTwo);

            while (isInputTwoNumeric == false)
            {
                Console.WriteLine("This is not a number. Please enter a number.");
                GetSecondInput();
                isInputTwoNumeric = int.TryParse(userInputTwo, out inputTwo);
            }

            //Get arithetic operator
            GetArithmeticOperator();

            //Print output
            Console.WriteLine("Your result is " + output);
        }
    }
}

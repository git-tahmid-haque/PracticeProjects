using System;
using System.Threading;

// Things learnt:
//  - Array.Sort using second array of numbers (not completely sure how it works though)
//  - How to fully use the Int.TryParse method
//  - How to use the Random class
//  - That you can recall a method from within that method's body
//  - To be careful with when you initialise variables and objects within the application

namespace SecretSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int numberOfParticipants = 0;
            string[] listOfNames = new string[numberOfParticipants];
            string[] listOfSecretSantas = new string[numberOfParticipants];
            var random = new Random();

            //Methods
            void GetNumberOfParticipants()
            {
                Console.WriteLine("How many participants are there? Enter a number.");
                bool isResultANumber = int.TryParse(Console.ReadLine(), out numberOfParticipants);

                if (isResultANumber == false)
                {
                    Console.WriteLine("You have not entered a number.");
                    GetNumberOfParticipants();
                }
                else
                {
                    listOfNames = new string[numberOfParticipants];
                    listOfSecretSantas = new string[numberOfParticipants];
                }
            }

            void CreateParticipantList()
            {
                for (int i = 1; i < (numberOfParticipants + 1); i++)
                {
                    Console.WriteLine("Please enter the name of participant number " + i.ToString());
                    string userInput = Console.ReadLine();
                    listOfNames[i-1] = userInput;
                }
            }

            void CreateSecretSantaList()
            {
                double[] order = new double[numberOfParticipants];

                for (int i = 0; i < numberOfParticipants; i++)
                {
                    listOfSecretSantas[i] = listOfNames[i];
                    order[i] = random.NextDouble();
                }

                Array.Sort(order, listOfSecretSantas);

                for (int i = 0; i < numberOfParticipants; i++)
                {
                    if (string.IsNullOrEmpty(listOfSecretSantas[i]))
                    {
                        CreateSecretSantaList();
                    }
                }

                for (int i = 0; i < numberOfParticipants; i++)
                {
                    if (listOfNames[i] == listOfSecretSantas[i])
                    {
                        CreateSecretSantaList();
                    }
                }
            }

            void PrintSecretSantas()
            {
                for (int i = 0; i < numberOfParticipants; i++)
                {
                    Console.WriteLine(listOfNames[i] + " has " + listOfSecretSantas[i] + " as their Secret Santa!");
                }
            }

            void Think()
            {
                Console.Write("Thinking");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
            }

            //Application
            void RunApplication()
            {
                GetNumberOfParticipants();

                Console.WriteLine();
                Console.WriteLine(" ----------------------------------- ");
                Console.WriteLine();

                CreateParticipantList();

                Console.WriteLine();
                Console.WriteLine(" ----------------------------------- ");
                Console.WriteLine();

                CreateSecretSantaList();

                Think();

                Console.WriteLine();
                Console.WriteLine(" ----------------------------------- ");
                Console.WriteLine();

                PrintSecretSantas();

                Console.WriteLine();
                Console.WriteLine(" ----------------------------------- ");
                Console.WriteLine();
            }

            RunApplication();
        }
    }
}

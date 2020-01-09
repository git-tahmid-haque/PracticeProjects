using System;
using System.Collections.Generic;
using System.Text;

// Things learnt:
//  - Filling an array when creating it
//  - Importance of order when it comes to organising logic

namespace PractiseProject
{
    class PrintingNumbersQuiz
    {
        public static void PrintingNumbers()
        {
            int[] twentyArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

            foreach (int number in twentyArray)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("USBDevice");
                    continue;
                }

                if (number % 3 == 0)
                {
                    Console.WriteLine("USB");
                    continue;
                }

                if (number % 5 == 0)
                {
                    Console.WriteLine("Device");
                    continue;
                }

                Console.WriteLine(number);
            }
        }
    }
}

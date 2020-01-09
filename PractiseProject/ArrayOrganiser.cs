using System;
using System.Collections.Generic;
using System.Text;

// Things learnt:
//  - How to use a break statement
//  - How to sort an array

namespace PractiseProject
{
    class ArrayOrganiser
    {
        public static int LowestPositiveNumber(int[] array)
        {
            int a = 1;
            Array.Sort(array);


            foreach (int number in array)
            {
                if (a == number)
                {
                    a++;
                }
                else
                {
                    break;
                }
            }

            return a;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given an arrayOfInts, find the highestProduct you can get from three of the integers.
The input arrayOfInts will always have at least three integers.
*/

namespace CSharpProblems
{
    class FindHighestProductOf3Ints
    {
        /// <summary>
        /// Return the highest product possible from three of the
        /// integers in the array. Assume array has atleast 3 ints
        /// </summary>
        /// <param name="array"></param>
        /// <returns>highestProductOf3</returns>
        private int GetHighestProductOf3Ints(int[] array)
        {
            // Do the following 3 assignments for ease of reading
            int num0 = array[0];
            int num1 = array[1];
            int num2 = array[2];

            // Set initial variables - can assume there are 3 integers
            int highestProductOf3 = num0 * num1 * num2;
            // If we have highest product of 2
            int highestProductOf2 = Math.Max(num0 * num1, Math.Max(num0 * num2, num1 * num2));
            int highest = Math.Max(num0, Math.Max(num1, num2));

            int lowestProductOf2 = Math.Min(num0 * num1, Math.Min(num0 * num2, num1 * num2));
            int lowest = Math.Min(num0, Math.Min(num1, num2)); ;

            // Need to check for negative numbers
            // Product of [2, -3, -3] > [2, 2, 3]
            for(int i = 3; i < array.Length; i++)
            {
                int current = array[i];

                highestProductOf3 = Math.Max(highestProductOf3, Math.Max(current * highestProductOf2, current * lowestProductOf2));
                
                if (Math.Sign(current) == 1)
                {
                    highestProductOf2 = Math.Max(current * highest, highestProductOf2);
                    highest = Math.Max(current, highest);
                } else if (Math.Sign(current) == -1)
                {
                    lowestProductOf2 = Math.Max(current * lowest, lowestProductOf2);
                    lowest = Math.Max(current, lowest);
                }
            }
            
            return highestProductOf3;
        }

        /// <summary>
        /// Run the Find Highest Product of 3 Integers in an array Problem
        /// </summary>
        /// <param name="helper"></param>
        public void RunFindHighestProductOf3Ints(HelperFunctions helper)
        {
            int[] arrayOfInts = new int[] { 1, 10, -5, 1, -100, 100, 0 };
            System.Diagnostics.Debug.WriteLine("Input: " + helper.ArrayToString(arrayOfInts) + "\nOutput: " + GetHighestProductOf3Ints(arrayOfInts));
        }
    }
}

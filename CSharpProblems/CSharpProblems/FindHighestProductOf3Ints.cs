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
            // Set initial variables - can assume there are 3 integers
            int highestProductOf3 = array[0] * array[1] * array[2];

            // Use first two numbers to initialize highest/lowestproductof2
            // and highest/lowest numbers found
            int highestProductOf2 = array[0] * array[1];
            int highest = Math.Max(array[0], array[1]);
            int lowestProductOf2 = array[0] * array[1];
            int lowest = Math.Min(array[0], array[1]);

            // Need to check for negative numbers
            // Product of [2, -3, -3] > [2, 2, 3]
            for(int i = 2; i < array.Length; i++)
            {
                int current = array[i];

                //Check if there is a newest highest product of 3 with current value
                highestProductOf3 = Math.Max(highestProductOf3, Math.Max(current * highestProductOf2, current * lowestProductOf2));
                //Check for a new highest or lowest product of 2 using highest/lowest and current value
                highestProductOf2 = Math.Max(highestProductOf2, Math.Max(current * highest, current * lowest));
                lowestProductOf2 = Math.Min(lowestProductOf2, Math.Min(current * highest, current * lowest));
                //Check for a new highest and lowest value
                highest = Math.Max(current, highest);
                lowest = Math.Min(current, lowest);
            }
            
            return highestProductOf3;
        }

        /// <summary>
        /// Run the Find Highest Product of 3 Integers in an array Problem
        /// </summary>
        /// <param name="helper"></param>
        public void RunFindHighestProductOf3Ints(HelperFunctions helper)
        {
            int[] arrayOfInts = new int[] { 1, 10, -5, 1, -100, 100 };

            System.Diagnostics.Debug.WriteLine("Input: " + helper.ArrayToString(arrayOfInts) + "\nOutput: " + GetHighestProductOf3Ints(arrayOfInts));
        }
    }
}

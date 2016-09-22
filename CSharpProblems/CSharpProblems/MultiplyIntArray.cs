using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You have an array of integers, and for each index you want to find the product of every integer except the integer at that index.
Write a function getProductsOfAllIntsExceptAtIndex() that takes an array of integers and returns an array of the products.

For example, given:

  [1, 7, 3, 4]

your function would return:

  [84, 12, 28, 21]

by calculating:

  [7*3*4, 1*3*4, 1*7*4, 1*7*3]

Do not use division in your solution.
*/

namespace CSharpProblems
{
    class MultiplyIntArray
    {

        /// <summary>
        /// Example array [1, 2, 3]
        /// Will produce [ 2*3, 1*3, 1*2]
        /// If we produce the following two arrays:
        ///  product of all indexes before current index: [1, 1, 1*2]
        ///  product of all indexes after current index: [2*3, 3, 1]
        /// We can see that by running through the original array twice
        ///  we get all the info we need (multiply those two arrays together)
        /// </summary>
        /// <param name="array"></param>
        /// <returns>returnArray</returns>
        private int[] GetProductsOfAllIntsExceptAtIndex(int[] array)
        {
            // Create one new array to hold products
            int[] returnArray = new int[array.Length];

            // Go forward through array get products of all indexes before
            //  current index (first index is 1 as identity)
            int productSoFar = 1;
            for(int i = 0; i < array.Length; i++)
            {
                returnArray[i] = productSoFar;
                productSoFar *= array[i];
            }

            // Go backward through array get products of all indexes after
            //  current index (first index is 1 as identity) and calc
            //  products of both arrays as you go to create final array
            productSoFar = 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                returnArray[i] *= productSoFar;
                productSoFar *= array[i];
            }

            return returnArray;
        }

        /// <summary>
        /// Run the Multiply Integer Array Problem
        /// </summary>
        public void RunMultiplyIntArray()
        {
            HelperFunctions helper = new HelperFunctions();

            int[] array = new int[] { 3, 5, 6, 7, 8 };

            System.Diagnostics.Debug.WriteLine("Input: " + helper.ArrayToString(array) + "\nOutput: " + helper.ArrayToString(GetProductsOfAllIntsExceptAtIndex(array)));
        }
    }
}

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
        private int GetProductOfAllInts(int[] array)
        {
            int product = 1;

            foreach(var num in array)
            {
                product *= num;
            }

            return product;
        }

        private int[] GetProductsOfAllIntsExceptAtIndex(int[] array)
        {
            int[] returnArray = new int[array.Length];

            for(int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                array[i] = 1;
                returnArray[i] = GetProductOfAllInts(array);
                array[i] = temp;
            }

            return returnArray;
        }

        public void RunMultiplyIntArray()
        {
            HelperFunctions helper = new HelperFunctions();

            int[] array = new int[] { 1, 7, 3, 4, 0 };

            System.Diagnostics.Debug.WriteLine("Input: " + helper.ArrayToString(array) + "\nOutput: " + helper.ArrayToString(GetProductsOfAllIntsExceptAtIndex(array)));
        }
    }
}

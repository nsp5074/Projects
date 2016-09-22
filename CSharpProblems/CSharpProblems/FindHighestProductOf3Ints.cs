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
        ///  integers in the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>highestProduct</returns>
        private int GetHighestProductOf3Ints(int[] array)
        {
            int highestProduct = 1;

            return highestProduct;
        }

        /// <summary>
        /// Run the Find Highest Product of 3 Integers in an array Problem
        /// </summary>
        /// <param name="helper"></param>
        public void RunFindHighestProductOf3Ints(HelperFunctions helper)
        {
            int[] array = new int[] { 1, 2, 3, 4, 2, -3, -3, 0 };
            System.Diagnostics.Debug.WriteLine("Input: " + helper.ArrayToString(array) + "\nOutput: " + GetHighestProductOf3Ints(array));
        }
    }
}

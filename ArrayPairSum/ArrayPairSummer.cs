using System.Security.Cryptography;
using System.Xml.Linq;
using System;

namespace NArrayPairSum
{
    public class ArrayPairSummerException:Exception
    {
        public ArrayPairSummerException(string msg) : base(msg) { }
        public static  ArrayPairSummerException ArrayLengthMustBeEven() => new ArrayPairSummerException("Array length must be even");

    }
    public class ArrayPairSummer
    {
        /// <summary>
        /// Given an integer array nums of 2n integers, group these integers into n pairs (a1, b1), (a2, b2), ..., (an, bn) such that the sum of min(ai, bi) for all i is maximized
        /// Input: nums = [6,2,6,5,1,2]
        //  Output: 9
        //Explanation: The optimal pairing is (2, 1), (2, 5), (6, 6). min(2, 1) + min(2, 5) + min(6, 6) = 1 + 2 + 6 = 9.
        //   Hide Hint #3  
        //    Did you observe that- Minimum element gets add into the result in sacrifice of maximum element.
        /// </summary>
        /// <param name="nums">array for analyze </param>
        /// <returns>maximaised sum of  minimum from pairs  </returns>
        public int ArrayPairSum(int[] nums)
        {if (nums.Length % 2 != 0) throw ArrayPairSummerException.ArrayLengthMustBeEven();
         var sorted=nums.OrderBy(x => x).ToArray();

            var sum = 0; 
            for (int i = 0; i < sorted.Length; i += 2) 
            {
                sum += sorted[i]< sorted[i+1]? sorted[i]: sorted[i + 1];
            }
            return sum;
        }
    }
}
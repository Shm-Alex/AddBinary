using System.Security.Cryptography;
using System.Xml.Linq;
using System;

namespace NArrayPairSum
{
    public class ArrayPairSummerException:Exception
    {
        public ArrayPairSummerException(string msg) : base(msg) { }
        public static  ArrayPairSummerException ArrayLengthMustBeEven() => new ArrayPairSummerException("Array length must be even");
        public static ArrayPairSummerException ArrayLengthTooLess() => new ArrayPairSummerException("Array length must more then 2 elems");

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
        public int[] TwoSum(int[] numbers, int target)
        {
             int r=numbers.Length-1;
            if(!(r > 0)) { throw ArrayPairSummerException.ArrayLengthTooLess(); }
            for (int i = 0; i < r; i++) 
            {
                var secondIndex = targetIndex(numbers, i+1, r, target - numbers[i]);
                if (secondIndex != -1) return new int[] { i+1,secondIndex+1};
            }
            return new int[0];
        }

        public int targetIndex(int[] nums, int l, int r, int target) {
            if (target == nums[r]) return r;
            if (target == nums[l]) return l;

            while (l < r) 
            {
                if (target<nums[l]) return -1;
                if (target> nums[r]) return -1;
                if (target == nums[r]) return r;
                if (target == nums[l]) return l;
                int mid = (l + r) / 2;
                if (nums[mid]==target) return mid;
                if ((nums[mid] < target)&& (l != mid)) { l = mid; continue; }
                else
                {
                    if (r != mid) { r = mid; continue; }
                }
                return -1;
            }
            return -1;
        }
    }
}
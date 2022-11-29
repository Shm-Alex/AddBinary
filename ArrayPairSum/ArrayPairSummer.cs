using System.Security.Cryptography;
using System.Xml.Linq;
using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

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
        public int RemoveElement(int[] nums, int val)
        {
            int slow =0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val) 
                {
                    nums[slow] = nums[i];
                    slow++;
                }
            }
            return slow;
        }
        public int RemoveElement1(int[] nums, int val)
        {
            int k = nums.Length ;

            for (int i = 0; i < k; i++)
            {
                for (; k > 0; k--)
                {
                    if (nums[k - 1] != val) break;
                   
                }
                if (k == 0) return 0;
                if (nums[i] == val) { 
                    nums[i] = nums[k-1];
                    k--;
                }
            }
            return k;
        }
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxLength = 0;
            int Consecutive1=0;
            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] == 0)
                {
                    if (Consecutive1 > maxLength) maxLength = Consecutive1;
                    Consecutive1 = 0;
                }
                else Consecutive1++;
            }
            return maxLength> Consecutive1? maxLength: Consecutive1;
        }
        public void Sort(int[] nums) 
        {
            
            for (int unsortedB = 0;  unsortedB < nums.Length; unsortedB++) {
                int max = nums[unsortedB];
                int maxIndex = unsortedB;

                for (int i = unsortedB + 1; i < nums.Length; i++)
                {
                    if (nums[i] > max) { max = nums[i]; maxIndex = i; }
                }
                nums[maxIndex] = nums[unsortedB];
                nums[unsortedB] = max;

            }
        }

        public int SubArrayMaxSum(int subArraylength, int[] nums)
        {
            
            //if (subArraylength > nums.Length) throw;
            int ret = nums[0];
            for (int j = 1; j < subArraylength;  ret += nums[j], j++) { }
            for (int l = 1, r = l + subArraylength; r < nums.Length ; l++,r++ )
            {
                int i = l, windowSum = 0;
                for (; i < r; i++, windowSum += nums[i]) { }

               if(windowSum> ret)ret=windowSum;
            }
            return ret;
        }
        public int MinSubArrayLen(int target, int[] nums)
        {

            for (int subArraylength = 1; (subArraylength <= nums.Length); subArraylength++) {
                var subArrayMaxSum = SubArrayMaxSum(subArraylength, nums);
                if (subArrayMaxSum >= target)
                    return subArraylength;
            }
            
            return 0;
        }
            public int MinSubArrayLen1(int target, int[] nums)
        {
            var copy = nums.ToArray();
            var targetCopy = target;
            int ret = 0;
            for (int unsortedB = 0; unsortedB < nums.Length; unsortedB++)
            {
                int max = nums[unsortedB];
                int maxIndex = unsortedB;

                for (int i = unsortedB + 1; i < nums.Length; i++)
                {
                    if (nums[i] > max) { max = nums[i]; maxIndex = i; }
                }
                nums[maxIndex] = nums[unsortedB];
                nums[unsortedB] = max;
                target = target - max;
                if (target <= 0)
                {
                    var dbg = nums.Take(ret + 1).ToArray();
                    var sum=dbg.Sum();
                    return ret + 1;
                }
                else ret++;
            }
            return 0;
        }

    }
}

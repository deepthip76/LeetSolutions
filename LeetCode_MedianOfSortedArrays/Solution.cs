using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_MedianOfSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> mergedArray = GetMergedArray(nums1, nums2);
            int medianIndex = mergedArray.Count / 2;
            if (mergedArray.Count % 2 == 0 && medianIndex != 0)
            {
                return (mergedArray[medianIndex] + mergedArray[medianIndex - 1]) / 2.0;
            }
            else if (medianIndex == 0)
            {
                return mergedArray[0];
            }
            else
            {
                return mergedArray[medianIndex];
            }
        }

        public List<int> GetMergedArray(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0;
            List<int> result = new List<int>();
            if (nums1.Length == 0)
            {
                return nums2.ToList();
            }
            if (nums2.Length == 0)
            {
                return nums1.ToList();
            }
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] > nums2[j])
                {
                    result.Add(nums2[j++]);
                }
                else
                {
                    result.Add(nums1[i++]);
                }
            }
            while (i < nums1.Length) result.Add(nums1[i++]);
            while (j < nums2.Length) result.Add(nums2[j++]);
            return result;


        }
    }
}

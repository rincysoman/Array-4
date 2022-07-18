using System;
namespace Algorithms
{
    public class NextPermutation
    {
        /// Time Complexity : O(N) 
        // Space Complexity :O(1) 
        // Did this code successfully run on Leetcode :Yes
        public void NextPermutationAlg(int[] nums)
        {
            //null case
            if (nums.Length == 0) return;
            int n = nums.Length;
            //find the breach
            int i = n - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }
            //find next higher number and swap
            if (i >= 0)
            {
                int j = n - 1;
                while (nums[i] >= nums[j])
                {
                    j--;
                }
                swap(nums, i, j);
            }
            //reverse
            reverse(nums, i + 1, n - 1);
        }

        private void reverse(int[] nums, int l, int r)
        {
            while (l < r)
            {
                swap(nums, l, r);
                r--;
                l++;
            }
        }
        private void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}

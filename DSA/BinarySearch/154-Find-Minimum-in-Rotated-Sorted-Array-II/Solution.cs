// LeetCode 154 - Find Minimum in Rotated Sorted Array II
// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/
//
// Time Complexity: O(log n) average, O(n) worst case with duplicates
// Space Complexity: O(1)

public class Solution
{
    public int FindMin(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] < nums[right])
                right = mid;
            else if (nums[mid] > nums[right])
                left = mid + 1;
            else
                right--;
        }

        return nums[left];
    }
}

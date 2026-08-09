// LeetCode 167 - Two Sum II - Input Array Is Sorted
// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
//
// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];

            if (sum == target)
                return new int[] { left + 1, right + 1 };

            if (sum < target)
                left++;
            else
                right--;
        }

        return new int[] { };
    }
}

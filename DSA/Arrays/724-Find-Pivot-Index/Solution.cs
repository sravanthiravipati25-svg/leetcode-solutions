// LeetCode 724 - Find Pivot Index
// https://leetcode.com/problems/find-pivot-index/
//
// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int totalSum = 0;

        // Calculate total sum
        foreach (int num in nums)
        {
            totalSum += num;
        }

        int leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int rightSum = totalSum - leftSum - nums[i];

            if (leftSum == rightSum)
            {
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}

// LeetCode #1 - Two Sum
// https://leetcode.com/problems/two-sum/
//
// Time Complexity:  O(n)
// Space Complexity: O(n)

using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>(); // value -> index

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (seen.TryGetValue(complement, out int j))
            {
                return new int[] { j, i };
            }
            seen[nums[i]] = i;
        }

        return System.Array.Empty<int>();
    }
}

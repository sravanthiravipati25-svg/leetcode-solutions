// LeetCode 217 - Contains Duplicate
// https://leetcode.com/problems/contains-duplicate/
//
// Time Complexity: O(n)
// Space Complexity: O(n)

using System.Collections.Generic;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in nums)
        {
            if (seen.Contains(num))
            {
                return true;
            }

            seen.Add(num);
        }

        return false;
    }
}

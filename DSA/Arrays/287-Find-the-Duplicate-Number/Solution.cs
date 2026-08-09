// LeetCode 287 - Find the Duplicate Number
// https://leetcode.com/problems/find-the-duplicate-number/
//
// Time Complexity: O(n)
// Space Complexity: O(1)

public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        int slow = nums[0];
        int fast = nums[0];

        // Find intersection point
        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        while (slow != fast);

        // Find entrance of the cycle
        slow = nums[0];

        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }

        return slow;
    }
}

// LeetCode 501 - Find Mode in Binary Search Tree
// https://leetcode.com/problems/find-mode-in-binary-search-tree/
//
// Time Complexity: O(n)
// Space Complexity: O(h) recursion stack, excluding output

using System.Collections.Generic;

public class Solution
{
    private int previous;
    private bool hasPrevious;
    private int currentCount;
    private int maxCount;
    private List<int> modes = new List<int>();

    public int[] FindMode(TreeNode root)
    {
        InOrder(root);
        return modes.ToArray();
    }

    private void InOrder(TreeNode node)
    {
        if (node == null)
            return;

        InOrder(node.left);

        if (!hasPrevious || node.val != previous)
        {
            currentCount = 1;
            previous = node.val;
            hasPrevious = true;
        }
        else
        {
            currentCount++;
        }

        if (currentCount > maxCount)
        {
            maxCount = currentCount;
            modes.Clear();
            modes.Add(node.val);
        }
        else if (currentCount == maxCount)
        {
            modes.Add(node.val);
        }

        InOrder(node.right);
    }
}

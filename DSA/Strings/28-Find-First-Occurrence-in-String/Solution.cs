// LeetCode 28 - Find the Index of the First Occurrence in a String
// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
//
// Time Complexity: O(n * m) worst case
// Space Complexity: O(1)

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle, System.StringComparison.Ordinal);
    }
}

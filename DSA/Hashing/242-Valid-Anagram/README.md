# 242. Valid Anagram

## Problem
Return `true` if two strings contain the same characters with the same frequencies.

## Approach
Use an array of 26 counts. Increment counts for `s` and decrement them for `t`. If all counts are zero, they are anagrams.

## Key Concepts
- Frequency Count
- Hashing
- Character Counting
- ASCII Mapping

## Complexity
- Time: O(n)
- Space: O(1)

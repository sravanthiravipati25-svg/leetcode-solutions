# 167. Two Sum II - Input Array Is Sorted

## Problem
Find two numbers in a sorted array that add up to `target`. Return their 1-based indices.

## Approach
Use two pointers:
- `left` starts at the beginning.
- `right` starts at the end.
- If sum is too small, move `left` right.
- If sum is too large, move `right` left.
- If equal, return the indices.

## Key Concepts
- Two Pointers
- Sorted Array
- Target Sum

## Complexity
- Time: O(n)
- Space: O(1)

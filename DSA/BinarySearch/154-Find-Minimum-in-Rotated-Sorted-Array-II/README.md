# 154. Find Minimum in Rotated Sorted Array II

## Problem
Find the minimum element in a rotated sorted array that may contain duplicates.

## Approach
Use binary search with `left`, `mid`, and `right`.

- `nums[mid] < nums[right]` -> minimum is at `mid` or to the left.
- `nums[mid] > nums[right]` -> minimum is to the right of `mid`.
- Equal values -> `right--` safely removes one duplicate.

## Key Concepts
- Binary Search
- Rotated Sorted Array
- Duplicates
- Two Pointers

## Complexity
- Time: O(log n) average, O(n) worst case
- Space: O(1)

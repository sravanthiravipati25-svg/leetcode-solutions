# 26. Remove Duplicates from Sorted Array

## Problem

Given an integer array `nums` sorted in non-decreasing order, remove the duplicates in-place so that each unique element appears only once.

Return the number of unique elements `k`.

The first `k` elements of `nums` should contain the unique numbers in sorted order.

## Approach

Since the array is already sorted, duplicate values will always be next to each other.

Use two pointers:

- `i` → scans the array.
- `k` → keeps track of the position where the next unique element should be placed.

If `nums[i]` is different from the previous element:

```text
nums[i] != nums[i - 1]

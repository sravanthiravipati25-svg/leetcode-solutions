# 217. Contains Duplicate

## Problem

Given an integer array `nums`, return `true` if any value appears at least twice in the array.

Return `false` if every element is unique.

## Approach

Use a `HashSet<int>` to keep track of the numbers we have already seen.

For each number:

1. Check if the number already exists in the HashSet.
2. If it exists, a duplicate is found → return `true`.
3. If it does not exist, add it to the HashSet.
4. If we finish the loop without finding a duplicate, return `false`.

## Example 1

### Input

```text
nums = [1,2,3,1]

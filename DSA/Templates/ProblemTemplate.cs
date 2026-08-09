# LeetCode 1 - Two Sum

[LeetCode Problem](https://leetcode.com/problems/two-sum/)

## Problem

Given an integer array `nums` and an integer `target`, return the indices of the two numbers such that they add up to `target`.

Each input has exactly one solution, and the same element cannot be used twice.

## Approach

Use a `Dictionary<int, int>` to store:

* **Key** → Number
* **Value** → Index

For each number:

1. Calculate the `complement = target - nums[i]`.
2. Check if the complement already exists in the dictionary.
3. If it exists, return its index and the current index.
4. Otherwise, store the current number and its index.

## C# Solution

```csharp
using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }

        return new int[] { };
    }
}
```

## Example

```text
Input:
nums = [2,7,11,15]
target = 9

Output:
[0,1]
```

### Dry Run

```text
i = 0
nums[i] = 2
complement = 9 - 2 = 7

7 is not in map

map:
2 → 0
```

Next:

```text
i = 1
nums[i] = 7
complement = 9 - 7 = 2

2 exists in map

map[2] = 0

Return:
[0,1]
```

## Complexity

**Time Complexity:** `O(n)`

**Space Complexity:** `O(n)`

## Key Concepts

* Dictionary / HashMap
* Complement
* Array
* One-pass solution
* Hashing
* `O(n)` time complexity

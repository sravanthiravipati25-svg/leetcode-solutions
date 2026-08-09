# 238. Product of Array Except Self

**LeetCode:** https://leetcode.com/problems/product-of-array-except-self/

**Difficulty:** Medium

## Problem Description

Given an integer array `nums`, return an array `answer` such that:

```text
answer[i] = product of all elements of nums except nums[i]
```

The solution must:

* Run in **O(n)** time.
* Not use division.
* Use **O(1)** extra space, excluding the output array.

## Example

### Input

```text
nums = [1, 2, 3, 4]
```

### Output

```text
[24, 12, 8, 6]
```

### Explanation

For each index, calculate the product of every element except the current element:

```text
Index 0 → 2 × 3 × 4 = 24
Index 1 → 1 × 3 × 4 = 12
Index 2 → 1 × 2 × 4 = 8
Index 3 → 1 × 2 × 3 = 6
```

Therefore:

```text
[24, 12, 8, 6]
```

---

## Approach

The key idea is:

```text
answer[i] = left product × right product
```

Instead of calculating the product for every index separately, we use **prefix products** and **suffix products**.

### Step 1: Calculate Prefix Products

First, store the product of all elements to the **left** of each index in the `answer` array.

For:

```text
nums = [1, 2, 3, 4]
```

The prefix products are:

```text
Index:   0   1   2   3
Nums:    1   2   3   4
Prefix:  1   1   2   6
```

So:

```text
answer = [1, 1, 2, 6]
```

For example:

```text
answer[2] = 1 × 2 = 2
```

---

### Step 2: Calculate Suffix Products

Now traverse the array from **right to left**.

Maintain a variable:

```csharp
int suffixProduct = 1;
```

This stores the product of all elements to the right of the current index.

For:

```text
nums = [1, 2, 3, 4]
```

We calculate:

```text
Index 3:
left  = 6
right = 1
answer = 6 × 1 = 6

Index 2:
left  = 2
right = 4
answer = 2 × 4 = 8

Index 1:
left  = 1
right = 12
answer = 1 × 12 = 12

Index 0:
left  = 1
right = 24
answer = 1 × 24 = 24
```

Final result:

```text
[24, 12, 8, 6]
```

---

## C# Solution

```csharp
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] answer = new int[n];

        // Step 1: Calculate prefix products
        answer[0] = 1;

        for (int i = 1; i < n; i++)
        {
            answer[i] = answer[i - 1] * nums[i - 1];
        }

        // Step 2: Calculate suffix products
        int suffixProduct = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            answer[i] *= suffixProduct;

            suffixProduct *= nums[i];
        }

        return answer;
    }
}
```

---

## Dry Run

### Input

```text
nums = [1, 2, 3, 4]
```

### After Prefix Pass

```text
answer = [1, 1, 2, 6]
```

### Suffix Pass

| Index | Prefix Product | Suffix Product | Result |
| ----: | -------------: | -------------: | -----: |
|     3 |              6 |              1 |      6 |
|     2 |              2 |              4 |      8 |
|     1 |              1 |             12 |     12 |
|     0 |              1 |             24 |     24 |

### Final Output

```text
[24, 12, 8, 6]
```

---

## Why Not Use Division?

A simple approach would be:

```text
totalProduct = product of all elements
answer[i] = totalProduct / nums[i]
```

However, the problem explicitly requires a solution **without using division**.

Division also creates problems when the array contains `0`.

The prefix + suffix approach handles zero values naturally.

### Example

```text
nums = [1, 2, 0, 4]
```

Output:

```text
[0, 0, 8, 0]
```

---

## Complexity Analysis

### Time Complexity

```text
O(n)
```

We traverse the array twice, so the total time is still **O(n)**.

### Space Complexity

```text
O(1) extra space
```

We only use the `suffixProduct` variable as additional space.

The `answer` array is the required output array, so it is not counted as extra space.

---

## Key Takeaway

For every index:

```text
answer[i] = product of elements on the left
          ×
            product of elements on the right
```

Using prefix and suffix products allows us to solve the problem efficiently:

```text
Time  → O(n)
Space → O(1) extra space
```

without using division.

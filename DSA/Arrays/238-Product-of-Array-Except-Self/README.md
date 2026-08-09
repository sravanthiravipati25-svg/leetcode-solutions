\# 238. Product of Array Except Self



\*\*LeetCode:\*\* https://leetcode.com/problems/product-of-array-except-self/



\*\*Difficulty:\*\* Medium



\## Problem Description



Given an integer array `nums`, return an array `answer` such that:



```text

answer\[i] = product of all elements of nums except nums\[i]

```



The solution must:



\* Run in \*\*O(n)\*\* time.

\* Not use division.

\* Use \*\*O(1)\*\* extra space, excluding the output array.



\### Example 1



\*\*Input:\*\*



```text

nums = \[1, 2, 3, 4]

```



\*\*Output:\*\*



```text

\[24, 12, 8, 6]

```



\### Explanation



For each index, calculate the product of every element except the current element:



```text

Index 0 → 2 × 3 × 4 = 24

Index 1 → 1 × 3 × 4 = 12

Index 2 → 1 × 2 × 4 = 8

Index 3 → 1 × 2 × 3 = 6

```



Therefore:



```text

\[24, 12, 8, 6]

```



\---



\## Approach



The key idea is:



```text

answer\[i] = left product × right product

```



Instead of calculating the product for every index separately, use two passes.



\### Step 1: Calculate Prefix Products



First, store the product of all elements to the \*\*left\*\* of each index in the `answer` array.



For:



```text

nums = \[1, 2, 3, 4]

```



The prefix products are:



```text

Index:   0   1   2   3

Nums:    1   2   3   4

Prefix:  1   1   2   6

```



So:



```text

answer = \[1, 1, 2, 6]

```



For example:



```text

answer\[2] = 1 × 2 = 2

```



\---



\### Step 2: Calculate Suffix Products



Now traverse the array from \*\*right to left\*\*.



Maintain a variable:



```csharp

int suffixProduct = 1;

```



This stores the product of all elements to the right of the current index.



For:



```text

nums = \[1, 2, 3, 4]

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

\[24, 12, 8, 6]

```



\---



\## C# Solution



```csharp

public class Solution

{

&#x20;   public int\[] ProductExceptSelf(int\[] nums)

&#x20;   {

&#x20;       int n = nums.Length;

&#x20;       int\[] answer = new int\[n];



&#x20;       // Step 1: Calculate prefix products

&#x20;       answer\[0] = 1;



&#x20;       for (int i = 1; i < n; i++)

&#x20;       {

&#x20;           answer\[i] = answer\[i - 1] \* nums\[i - 1];

&#x20;       }



&#x20;       // Step 2: Calculate suffix products

&#x20;       int suffixProduct = 1;



&#x20;       for (int i = n - 1; i >= 0; i--)

&#x20;       {

&#x20;           answer\[i] \*= suffixProduct;



&#x20;           suffixProduct \*= nums\[i];

&#x20;       }



&#x20;       return answer;

&#x20;   }

}

```



\---



\## Dry Run



\### Input



```text

nums = \[1, 2, 3, 4]

```



\### After Prefix Pass



```text

answer = \[1, 1, 2, 6]

```



\### Suffix Pass



| Index | Prefix Product | Suffix Product | Result |

| ----: | -------------: | -------------: | -----: |

|     3 |              6 |              1 |      6 |

|     2 |              2 |              4 |      8 |

|     1 |              1 |             12 |     12 |

|     0 |              1 |             24 |     24 |



\### Final Output



```text

\[24, 12, 8, 6]

```



\---



\## Why Not Use Division?



A simple approach would be:



```text

totalProduct = product of all elements

answer\[i] = totalProduct / nums\[i]

```



However, the problem explicitly requires a solution \*\*without using division\*\*.



Division also creates problems when the array contains `0`.



The prefix + suffix approach handles zero values naturally.



\### Example



```text

nums = \[1, 2, 0, 4]

```



Output:



```text

\[0, 0, 8, 0]

```



\---



\## Complexity Analysis



\### Time Complexity



```text

O(n)

```



We traverse the array twice.



\### Space Complexity



```text

O(1)

```



We only use the `suffixProduct` variable as additional space.



The `answer` array is considered the required output array and is not counted as extra space.



\---



\## Key Takeaway



For every index:



```text

answer\[i] = product of elements on the left

&#x20;         ×

&#x20;           product of elements on the right

```



Using prefix and suffix products allows us to solve the problem in:



```text

Time  → O(n)

Space → O(1) extra space

```



without using division.




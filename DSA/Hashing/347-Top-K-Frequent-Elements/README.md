# 347. Top K Frequent Elements

## Problem
Return the `k` elements that occur most frequently in an integer array.

## Approach
1. Count frequencies with a dictionary.
2. Use frequency as the bucket index.
3. Traverse buckets from highest frequency to lowest.
4. Stop after collecting `k` elements.

## Key Concepts
- Dictionary / HashMap
- Frequency Count
- Bucket Sort
- Top K

## Complexity
- Time: O(n)
- Space: O(n)

# 49. Group Anagrams

## Problem
Group strings that are anagrams of each other.

## Approach
Sort the characters of each word. The sorted word becomes the dictionary key.

Example:
```text
eat -> aet
tea -> aet
ate -> aet
```

All three use the same key, so they belong to the same group.

## Key Concepts
- Dictionary / HashMap
- Sorting
- Anagrams
- Grouping

## Complexity
- Time: O(n * k log k)
- Space: O(n * k)

Where `n` is the number of strings and `k` is the average string length.

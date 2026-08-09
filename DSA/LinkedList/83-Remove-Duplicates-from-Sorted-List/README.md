# 83. Remove Duplicates from Sorted List

## Problem
Given the head of a sorted linked list, delete all duplicates so each value appears only once.

## Approach
Because the list is sorted, duplicate values are adjacent. Compare the current node with the next node. If they are equal, skip the next node.

## Key Concepts
- Linked List
- Two Pointers
- In-Place Modification
- Sorted Data

## Complexity
- Time: O(n)
- Space: O(1)

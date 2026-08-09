# 501. Find Mode in Binary Search Tree

## Problem
Return all values that appear most frequently in a Binary Search Tree.

## Approach
Perform an inorder traversal. In a BST, inorder traversal visits values in sorted order, so equal values appear next to each other. Track the current frequency and maximum frequency.

## Key Concepts
- Binary Search Tree
- Inorder Traversal
- Frequency Counting
- Recursion

## Complexity
- Time: O(n)
- Space: O(h) recursion stack, excluding output

# 1. Two Sum

**Link:** https://leetcode.com/problems/two-sum/
**Difficulty:** Easy
**Topic:** Arrays / Hash Map
**Date solved:** 2026-08-06

## Problem

Given an array of integers `nums` and an integer `target`, return the indices
of the two numbers that add up to `target`.

## Approach

Single pass with a hash map. For each number, check if its complement
(`target - nums[i]`) has already been seen. If yes, return the stored index
and the current index. Otherwise store the current number's index and continue.

## Complexity

- **Time:** O(n) — one pass through the array
- **Space:** O(n) — hash map can hold up to n entries

## Notes

- Assumes exactly one valid answer exists (per problem constraints)
- Brute force O(n²) nested-loop approach was the naive alternative

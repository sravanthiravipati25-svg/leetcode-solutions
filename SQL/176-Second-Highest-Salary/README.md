# 176. Second Highest Salary

**Link:** https://leetcode.com/problems/second-highest-salary/
**Difficulty:** Medium
**Date solved:** 2026-08-06

## Problem

Table `Employee(id, salary)`. Return the second highest distinct salary.
If there is no second highest salary, return `null`.

## Approach

`DISTINCT` on salary removes duplicate values, then order descending and
skip the first row (`OFFSET 1`) to land on the second-highest. Wrapping in
a subquery with alias `SecondHighestSalary` naturally returns `NULL` when
fewer than two distinct salaries exist, instead of erroring out.

## Notes

- Edge case: table with 0 or 1 distinct salary → returns `NULL` correctly
- Alternative: `MAX(salary) WHERE salary < (SELECT MAX(salary) FROM Employee)`

# 584. Find Customer Referee

## Problem
Find customers who were not referred by customer `2`, including customers with no referee.

## Approach
Use `referee_id <> 2 OR referee_id IS NULL`.

Important: `NULL` must be checked with `IS NULL`.

## Key Concepts
- WHERE
- OR
- NULL
- IS NULL

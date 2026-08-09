# 196. Delete Duplicate Emails

## Problem
Delete duplicate email rows while keeping the row with the smallest `id`.

## Approach
Self join `Person` with itself. Delete `p1` when another row `p2` has the same email and a smaller id.

## Key Concepts
- DELETE
- Self Join
- Duplicate Removal
- Primary Key

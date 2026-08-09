# 182. Duplicate Emails

## Problem
Find email addresses that appear more than once.

## Approach
Group rows by email and use `HAVING COUNT(*) > 1`.

## Key Concepts
- GROUP BY
- HAVING
- COUNT
- Duplicate Detection

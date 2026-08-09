# 181. Employees Earning More Than Their Managers

## Problem
Find employees whose salary is greater than their manager's salary.

## Approach
Use a self join:
- `e` represents the employee.
- `m` represents the manager.
- Match `e.managerId = m.id`.

## Key Concepts
- INNER JOIN
- Self Join
- Table Aliases
- Comparison

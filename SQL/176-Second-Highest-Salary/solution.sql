-- LeetCode #176 - Second Highest Salary
-- https://leetcode.com/problems/second-highest-salary/
-- Dialect: MySQL

SELECT
    (SELECT DISTINCT Salary
     FROM Employee
     ORDER BY Salary DESC
     LIMIT 1 OFFSET 1) AS SecondHighestSalary;

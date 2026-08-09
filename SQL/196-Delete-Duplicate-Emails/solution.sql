-- LeetCode 196 - Delete Duplicate Emails
-- Keep the row with the smallest id for each email.
DELETE p1
FROM Person p1
INNER JOIN Person p2
    ON p1.email = p2.email
   AND p1.id > p2.id;

# LeetCode Solutions — DSA & SQL

Personal archive of LeetCode problems I'm solving, organized by topic.

* **DSA:** C#
* **SQL:** SQL solutions using the dialect supported by each problem

## Structure

```text
leetcode-solutions/
├── DSA/
│   ├── Arrays/
│   ├── Strings/
│   ├── LinkedList/
│   ├── Trees/
│   ├── Graphs/
│   ├── DynamicProgramming/
│   ├── Backtracking/
│   ├── Greedy/
│   ├── HeapsAndPriorityQueues/
│   ├── HashMaps/
│   ├── StacksAndQueues/
│   ├── SortingAndSearching/
│   ├── BinarySearch/
│   ├── SlidingWindow/
│   ├── TwoPointers/
│   └── Templates/
└── SQL/
    ├── 176-Second-Highest-Salary/
    ├── 1757-Recyclable-and-Low-Fat-Products/
    ├── 181-Employees-Earning-More-Than-Managers/
    ├── 182-Duplicate-Emails/
    ├── 196-Delete-Duplicate-Emails/
    ├── 584-Find-Customer-Referee/
    ├── 595-Big-Countries/
    └── Templates/
```

Each problem gets its own folder.

### DSA

```text
DSA/<Topic>/<LeetCodeNumber>-<Problem-Slug>/
├── Solution.cs
└── README.md
```

### SQL

```text
SQL/<LeetCodeNumber>-<Problem-Slug>/
├── solution.sql
└── README.md
```

## How to Add a New Solved Problem

1. Copy the template for the appropriate topic:

   * **DSA:** `DSA/Templates/`
   * **SQL:** `SQL/Templates/`
2. Rename the folder to:

   ```text
   <number>-<problem-slug>
   ```

   Example:

   ```text
   1-Two-Sum
   176-Second-Highest-Salary
   ```
3. Add the solution and README.
4. Include:

   * Problem description/link
   * Approach
   * Time complexity
   * Space complexity
   * Edge cases/notes
5. Update the progress tracker below.
6. Commit and push:

```bash
git add .
git commit -m "Add <number>. <Problem Title>"
git push origin main
```

## Progress Tracker

|    # | Problem                                                                                                  | Topic         | Difficulty | Status   |
| ---: | -------------------------------------------------------------------------------------------------------- | ------------- | ---------- | -------- |
|    1 | [Two Sum](DSA/Arrays/1-Two-Sum/)                                                                         | Arrays        | Easy       | ✅ Solved |
|   26 | [Remove Duplicates from Sorted Array](DSA/Arrays/26-Remove-Duplicates-from-Sorted-Array/)                | Arrays        | Easy       | ✅ Solved |
|   28 | [Find the Index of the First Occurrence in a String](DSA/Strings/28-Find-First-Occurrence-in-String/)    | Strings       | Easy       | ✅ Solved |
|   49 | [Group Anagrams](DSA/Hashing/49-Group-Anagrams/)                                                         | Hashing       | Medium     | ✅ Solved |
|   83 | [Remove Duplicates from Sorted List](DSA/LinkedList/83-Remove-Duplicates-from-Sorted-List/)              | Linked List   | Easy       | ✅ Solved |
|  154 | [Find Minimum in Rotated Sorted Array II](DSA/BinarySearch/154-Find-Minimum-in-Rotated-Sorted-Array-II/) | Binary Search | Hard       | ✅ Solved |
|  167 | [Two Sum II - Input Array Is Sorted](DSA/Arrays/167-Two-Sum-II-Input-Array-Is-Sorted/)                   | Arrays        | Medium     | ✅ Solved |
|  176 | [Second Highest Salary](SQL/176-Second-Highest-Salary/)                                                  | SQL           | Medium     | ✅ Solved |
|  181 | [Employees Earning More Than Their Managers](SQL/181-Employees-Earning-More-Than-Managers/)              | SQL           | Easy       | ✅ Solved |
|  182 | [Duplicate Emails](SQL/182-Duplicate-Emails/)                                                            | SQL           | Easy       | ✅ Solved |
|  196 | [Delete Duplicate Emails](SQL/196-Delete-Duplicate-Emails/)                                              | SQL           | Easy       | ✅ Solved |
|  217 | [Contains Duplicate](DSA/Hashing/217-Contains-Duplicate/)                                                | Hashing       | Easy       | ✅ Solved |
|  238 | [Product of Array Except Self](DSA/Arrays/238-Product-of-Array-Except-Self/)                             | Arrays        | Medium     | ✅ Solved |
|  242 | [Valid Anagram](DSA/Hashing/242-Valid-Anagram/)                                                          | Hashing       | Easy       | ✅ Solved |
|  287 | [Find the Duplicate Number](DSA/Arrays/287-Find-the-Duplicate-Number/)                                   | Arrays        | Medium     | ✅ Solved |
|  347 | [Top K Frequent Elements](DSA/Hashing/347-Top-K-Frequent-Elements/)                                      | Hashing       | Medium     | ✅ Solved |
|  501 | [Find Mode in Binary Search Tree](DSA/Trees/501-Find-Mode-in-Binary-Search-Tree/)                        | Trees         | Easy       | ✅ Solved |
|  584 | [Find Customer Referee](SQL/584-Find-Customer-Referee/)                                                  | SQL           | Easy       | ✅ Solved |
|  595 | [Big Countries](SQL/595-Big-Countries/)                                                                  | SQL           | Easy       | ✅ Solved |
|  724 | [Find Pivot Index](DSA/Arrays/724-Find-Pivot-Index/)                                                     | Arrays        | Easy       | ✅ Solved |
| 1757 | [Recyclable and Low Fat Products](SQL/1757-Recyclable-and-Low-Fat-Products/)                             | SQL           | Easy       | ✅ Solved |

## Stats

* **DSA solved:** 14
* **SQL solved:** 6
* **Total solved:** 20

## Topics Covered

### DSA

* Arrays
* Binary Search
* Hashing
* Linked List
* Strings
* Trees

### SQL

* Filtering
* Aggregation
* Duplicate detection
* Self joins
* Data modification
* Basic relational queries

---

> 🚀 **Goal:** Keep solving consistently, improve problem-solving skills, and build a strong foundation in DSA and SQL for software engineering interviews.

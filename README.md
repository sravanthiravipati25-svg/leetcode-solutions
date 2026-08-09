# LeetCode Solutions — DSA & SQL

Personal archive of LeetCode problems I'm solving, organized by topic.
DSA solutions are in **C#**; database problems are plain **SQL** (MySQL/PostgreSQL dialect as noted per problem).

## Structure

```
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
    └── Templates/
```

Each problem gets its own folder:

```
DSA/<Topic>/<LeetCodeNumber>-<Problem-Slug>/
├── Solution.cs
└── README.md      (problem link, approach, complexity, notes)
```

```
SQL/<LeetCodeNumber>-<Problem-Slug>/
├── solution.sql
└── README.md
```

## How to add a new solved problem

1. Copy the template folder for the right topic:
   - DSA: `DSA/Templates/ProblemTemplate.cs` and `DSA/Templates/ProblemTemplate.md`
   - SQL: `SQL/Templates/ProblemTemplate.sql` and `SQL/Templates/ProblemTemplate.md`
2. Rename the folder to `<number>-<slug>` (e.g. `1-Two-Sum`, `176-Second-Highest-Salary`).
3. Fill in the solution + README (approach, time/space complexity, edge cases).
4. Add a row to the progress table below.
5. Commit: `git add . && git commit -m "Add <number>. <Problem Title>"`

## Progress Tracker

| # | Problem | Topic | Difficulty | Status |
|---|---------|-------|------------|--------|
| 1 | [Two Sum](DSA/Arrays/1-Two-Sum/) | Arrays | Easy | ✅ Solved |
| 176 | [Second Highest Salary](SQL/176-Second-Highest-Salary/) | SQL | Medium | ✅ Solved |

_Update this table each time you add a new solution — makes it easy to see coverage across topics at a glance._

## Stats

- **DSA solved:** 1
- **SQL solved:** 1
- **Total:** 2

<!-- Optional: swap in a LeetCode stats badge, e.g. from leetcode-stats-api or a GitHub Action that auto-updates this README -->

# 36. Valid Sudoku

## Problem

Determine if a 9 x 9 Sudoku board is valid.

A Sudoku board is valid if:

- Each row contains the digits 1-9 without repetition.
- Each column contains the digits 1-9 without repetition.
- Each 3 x 3 sub-box contains the digits 1-9 without repetition.
- Empty cells are represented by `.`.

## Approach

Use three boolean arrays:

- `rows` → tracks numbers used in each row
- `cols` → tracks numbers used in each column
- `boxes` → tracks numbers used in each 3 x 3 box

For every non-empty cell:

1. Convert the character to an index from `0` to `8`.
2. Calculate which 3 x 3 box it belongs to.
3. Check whether the number already exists in the row, column, or box.
4. If it exists, return `false`.
5. Otherwise mark it as used.

If we finish checking the entire board, return `true`.

## Box Calculation

```text
box = (row / 3) * 3 + (column / 3)

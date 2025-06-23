# Fit-in-the-Data-Type
CodeChef Difficulty 1133 Problem

# Fit in Data Type

Chef is working with a custom data type that can only store values from `0` to `N` (inclusive). If a value `X` greater than `N` is stored in this data type, it wraps around cyclically.

### Cyclic Behavior Example:

- If `N = 4`, then:
  - `X = 5` → stored as `0`
  - `X = 6` → stored as `1`
  - `X = 9` → stored as `4`
  - `X = 10` → stored as `0`

This behavior is equivalent to computing the value `X % (N + 1)`.

---

## Input Format

- The first line contains a single integer `T` — the number of test cases.
- Each of the next `T` lines contains two space-separated integers:
  - `N` — the maximum value that can be stored in the data type
  - `X` — the value Chef wants to store

---

## Output Format

- For each test case, output a single integer: the actual value that would be stored in memory.

---

## Constraints

- `1 ≤ T ≤ 10^4`
- `0 ≤ N ≤ 10^9`
- `0 ≤ X ≤ 10^18`

---

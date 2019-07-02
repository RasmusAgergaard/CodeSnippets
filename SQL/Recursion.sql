/* Recursion example */
with f1(A, B)
as
(
    select 3, 4
    union all
    select A-1, B*A from f1
    where not A <= 1
)
select A, B from f1;

-- Outputs:
--     A   B
-- 1   3   4
-- 2   2  12
-- 3   1  24
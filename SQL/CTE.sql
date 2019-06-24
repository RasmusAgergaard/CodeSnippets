--A CTE (Common Table Expression) defines a temporary result set which you can then use in a SELECT statement.  
--It becomes a convenient way to manage complicated queries.
--Common Table Expressions are defined within the statement using the WITH operator.  
--You can define one or more common table expression in this fashion.

/* CTE Example (Common Table Expressions) */
with EmployeeView(ID, [First Name], [Last Name], [Pay Rate])
as (select id, first_name, last_name, pay_rate from Employee)
select * from EmployeeView;

with ShiftView(ID, Name, Multiplier)
as (select id, name, multiplier from Shift)
select * from ShiftView;
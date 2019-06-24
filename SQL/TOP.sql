/* Standard use */
select TOP 10 * from big_table 
order by round(net_worth, 0);

-- Include ties
select TOP 10 with ties * from big_table 
order by round(net_worth, 0);

/* Delete a large number of entrys using TOP. They are deleted in chunks, to prevent lockup of the DB */
updateMore:
delete TOP (10000) big_table
if @@ROWCOUNT != 0
goto updateMore;
/* SELECT claus */
select S.Zipcode,
AVG(UR.Amount) as 'Average', 
SUM(UR.Amount) as 'Total'
from [Unified Receipts] as UR
join Stores as S
on ur.[Store ID] = s.ID
where UR.Amount > 50               -- Changes the result of the SELECT claus

/* Grouping */
group by s.Zipcode
having AVG(UR.Amount) >= 60;


Outputs:
ID    Zipcode    Average    Total
1     09090      84.7051    322641.88
2     12345      85.3643    209398.77
3     21221      84.84      388312.68
4     54345      85.1352    213774.69
5     89012      85.0896    359078.35
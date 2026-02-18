-- /* Write your T-SQL query statement below */
-- -- select 
-- --     w1.id
-- -- from Weather w1
-- -- join weather w2
-- -- on DATEDIFF( day , w2.recordDate , w1.recordDate  ) = 1
-- -- where w1.temperature  > w2.temperature 

select id from (select 
    id ,
    temperature,
    recordDate ,
    LAG(temperature) over (order by recordDate ) as prev_temp,
    LAG(recordDate ) over (order by recordDate ) as prev_date
    from weather 

    ) t 
    where temperature > prev_temp
        and DATEDIFF (DAY , prev_date , recordDate ) = 1



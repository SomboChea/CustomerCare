CREATE VIEW [dbo].[viewAllCall] AS 
SELECT

dbo.tbl_pregnent.mom_id,
dbo.tbl_pregnent.created_date as 'Call_Date',
dbo.tbl_pregnent.call_status,
'tbl_pregnent' as 'table'

FROM
dbo.tbl_pregnent 
UNION
Select

mom_id,
m.created_date,
m.call_status,
'tbl_mdata'
from
dbo.tbl_mdata m
inner join tbl_kid k
on m.kid_id=k.id
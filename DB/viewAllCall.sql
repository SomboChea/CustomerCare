CREATE VIEW viewAllCall
As

SELECT
	dbo.tbl_pregnent.mom_id,
	dbo.tbl_pregnent.created_date,
	dbo.tbl_pregnent.call_status 
FROM
	dbo.tbl_pregnent UNION
SELECT
	mom_id,
	m.created_date,
	m.call_status 
FROM
	dbo.tbl_mdata m
	INNER JOIN tbl_kid k ON m.kid_id= k.id;

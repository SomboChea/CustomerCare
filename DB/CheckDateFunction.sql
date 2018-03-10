-- using 
-------------- select * from tbl_mom where [dbo].[CheckDateFunc]( id,7,'day' ) =1

CREATE FUNCTION [dbo].[CheckDateFunc]
( @momID AS int ,
@num as int ,
  @type AS varchar(10) ='month' 
)
RETURNS int
AS
BEGIN
	-- routine body goes here, e.g.
	-- SELECT 'Navicat for SQL Server'
	DECLARE @status as int =(Select top 1 call_status from viewAllCall where mom_id=@momID ORDER BY created_date desc);

IF @status=0 BEGIN
	DECLARE @lastdate as int =(Select top 1 call_status from viewAllCall where mom_id=@momID ORDER BY created_date desc);
	declare @duration as int ;
	IF @type!='month' BEGIN
	set @duration=@num;
END
ELSE BEGIN
	set @duration= DATEDIFF(day, @lastdate, DATEADD(month, -@num, @lastdate));
END
IF GETDATE()>DATEADD(day, -@duration, @lastdate) BEGIN
return 1;
END
ELSE begin
return 0;
end
END
return null;
END



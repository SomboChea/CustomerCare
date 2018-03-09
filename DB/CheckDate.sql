CREATE PROCEDURE [dbo].[CheckDatePreg]
  @momID AS int ,
	@num as int,
  @type AS varchar(50)='month'
	
AS
BEGIN
	-- routine body goes here, e.g.
	-- SELECT 'Navicat for SQL Server'
DECLARE @status as int =(Select top 1 call_status from viewAllCall where mom_id=@momID ORDER BY created_date desc);

IF @status!=2 BEGIN
	DECLARE @lastdate as int =(Select top 1 call_status from viewAllCall where mom_id=@momID ORDER BY created_date desc);
	declare @duration as int ;
	IF @type!='month' BEGIN
	set @duration=@num;
END
ELSE BEGIN
	set @duration= DATEDIFF(day, @lastdate, DATEADD(month, -@num, @lastdate));
END
IF GETDATE()>DATEADD(day, -@duration, @lastdate) BEGIN
select 1;
END
ELSE begin
select 0;
end
END
END
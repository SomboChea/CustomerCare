--select * from viewAllCall where dbo.CheckDateFunc( mom_id, 12,call_date, 'month',call_status)=1;

CREATE FUNCTION [dbo].[CheckDateFunc]
( @momID AS int =4,
@num as int =7,
@callDate as datetime,
  @type AS varchar(10) ='month' ,
	@status as int
)
RETURNS int
AS
BEGIN
	-- routine body goes here, e.g.
	-- SELECT 'Navicat for SQL Server'

IF @status=0 begin
	DECLARE @limitdate as date ;
	
	IF @type='month' BEGIN
			set @limitdate=DATEADD(month, -@num, @callDate);
	END
	ELSE BEGIN
			set @limitdate=DATEADD(day, -@num, @callDate);
	END

IF GETDATE()>=@limitdate BEGIN
	return 1;
END



END

else BEGIN

return 0;
end

return 0;

end
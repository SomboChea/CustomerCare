--select * from viewAllCall where dbo.CheckDateFunc( mom_id, 12,call_date, 'month')=1;

Create FUNCTION [dbo].[CheckDateFunc]
( @momID AS int =4,
@num as int =7,
@callDate as datetime,
  @type AS varchar(10) ='month' 
)
RETURNS int
AS
BEGIN
	-- routine body goes here, e.g.
	-- SELECT 'Navicat for SQL Server'
DECLARE @status as int =(Select top 1 call_status from viewAllCall where call_status=0 and mom_id=@momID and call_date=@callDate);

IF @status is not null begin
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
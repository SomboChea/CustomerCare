/*
 Navicat Premium Data Transfer

 Source Server         : SQL_WINDOW_AUTH
 Source Server Type    : SQL Server
 Source Server Version : 14001000
 Source Host           : localhost:1433
 Source Catalog        : Telmarketing
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14001000
 File Encoding         : 65001

 Date: 03/07/2018 20:29:45
*/


-- ----------------------------
-- Table structure for locations
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[locations]') AND type IN ('U'))
	DROP TABLE [dbo].[locations]
GO

CREATE TABLE [dbo].[locations] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [master_id] int DEFAULT ((0)) NULL
)
GO

ALTER TABLE [dbo].[locations] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_alert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_alert]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_alert]
GO

CREATE TABLE [dbo].[tbl_alert] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [at] date  NULL,
  [mom_id] int  NULL,
  [status] smallint DEFAULT ((1)) NULL,
  [type_id] smallint  NULL,
  [locked] smallint DEFAULT ((0)) NULL,
  [kid_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_alert] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'1: First, 2: Pregnent, 3: Step',
'SCHEMA', N'dbo',
'TABLE', N'tbl_alert',
'COLUMN', N'type_id'
GO


-- ----------------------------
-- Table structure for tbl_kid
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_kid]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_kid]
GO

CREATE TABLE [dbo].[tbl_kid] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name_id] int  NULL,
  [sex] smallint  NULL,
  [dob] date  NULL,
  [order] smallint  NULL,
  [mom_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_kid] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_mdata
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_mdata]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_mdata]
GO

CREATE TABLE [dbo].[tbl_mdata] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [kid_id] int  NULL,
  [pro_id] int  NULL,
  [created_at] datetime2(7)  NULL,
  [why] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [memo] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [caller_id] int  NULL,
  [call_status] smallint  NULL,
  [mom_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_mdata] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_mom
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_mom]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_mom]
GO

CREATE TABLE [dbo].[tbl_mom] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name_id] int  NULL,
  [created_at] datetime2(7)  NULL,
  [expected_date] date  NULL,
  [tel_1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [tel_2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [email] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [fb] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [other] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [address_id] int  NULL,
  [refer_id] int  NULL,
  [status] smallint DEFAULT ((1)) NULL,
  [logger_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_mom] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_name
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_name]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_name]
GO

CREATE TABLE [dbo].[tbl_name] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [type_id] smallint DEFAULT ((0)) NULL
)
GO

ALTER TABLE [dbo].[tbl_name] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'1:Source, 2:Owner, 3:Mom, 4:Kid, 5:UserFullname, 6:Product,0:General',
'SCHEMA', N'dbo',
'TABLE', N'tbl_name',
'COLUMN', N'type_id'
GO


-- ----------------------------
-- Table structure for tbl_pregnent
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_pregnent]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_pregnent]
GO

CREATE TABLE [dbo].[tbl_pregnent] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [mom_id] int  NULL,
  [created_at] datetime2(7)  NULL,
  [why] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [memo] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [caller_id] int  NULL,
  [call_status] smallint  NULL
)
GO

ALTER TABLE [dbo].[tbl_pregnent] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_product
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_product]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_product]
GO

CREATE TABLE [dbo].[tbl_product] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name_id] int  NULL,
  [info] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [level] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [status] smallint  NULL,
  [owner] smallint  NULL
)
GO

ALTER TABLE [dbo].[tbl_product] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_refer
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_refer]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_refer]
GO

CREATE TABLE [dbo].[tbl_refer] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name_id] int  NULL,
  [owner_id] int  NULL,
  [created_at] datetime2(7)  NULL,
  [tel_1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [tel_2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [email] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [memo] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [image] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [address_id] int  NULL,
  [type_id] smallint  NULL,
  [status] smallint DEFAULT ((1)) NULL,
  [logger_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_refer] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_refer_type
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_refer_type]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_refer_type]
GO

CREATE TABLE [dbo].[tbl_refer_type] (
  [id] smallint  IDENTITY(1,1) NOT NULL,
  [type] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tbl_refer_type] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_user
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_user]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_user]
GO

CREATE TABLE [dbo].[tbl_user] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [fullname_id] int  NULL,
  [username] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [password] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [role] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [created_at] datetime2(7) DEFAULT (getdate()) NULL,
  [status] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT ((1)) NULL
)
GO

ALTER TABLE [dbo].[tbl_user] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- View structure for viewAllAlerts
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewAllAlerts]') AND type IN ('V'))
	DROP VIEW [dbo].[viewAllAlerts]
GO

CREATE VIEW [dbo].[viewAllAlerts] AS SELECT
	id as Call_id,
	at as Call_Date,
	dbo.getname(mom_id,3) Mom_Name,
	dbo.getname(kid_id,4) Kid_Name,
	locked,
	dbo.getalertdate("at") as Alert_Date,
	mom_id,
	kid_id
FROM
	tbl_alert
Where 
	dbo.getalertdate("at")<GETDATE()
	and
	status=0
GO


-- ----------------------------
-- View structure for viewAllMoms
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewAllMoms]') AND type IN ('V'))
	DROP VIEW [dbo].[viewAllMoms]
GO

CREATE VIEW [dbo].[viewAllMoms] AS SELECT
m.id,
n.name,
m.created_at,
m.expected_date,
m.tel_1,
m.tel_2,
m.email,
m.fb,
m.other,
m.address_id,
m.refer_id,
m.status,
m.logger_id

FROM
tbl_mom m
INNER JOIN tbl_name n
ON m.name_id = n.id
WHERE status = 1
GO


-- ----------------------------
-- View structure for viewUsers
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewUsers]') AND type IN ('V'))
	DROP VIEW [dbo].[viewUsers]
GO

CREATE VIEW [dbo].[viewUsers] AS SELECT
u.id,
n.name,
u.username,
u.role_id role

FROM
tbl_user u
INNER JOIN tbl_name n
ON u.fullname_id = n.id
GO


-- ----------------------------
-- Procedure structure for insertName
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[insertName]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[insertName]
GO

CREATE PROCEDURE [dbo].[insertName]
(
@name NVARCHAR(100),
@type_id INT
)
AS
BEGIN
	
	DECLARE @id INT;
	SET @id = (SELECT id FROM tbl_name WHERE name = @name);
	
	IF @id IS NULL BEGIN
		INSERT INTO tbl_name(name, type_id)
		VALUES(@name, @type_id);
		SET @id = (SELECT IDENT_CURRENT('tbl_name'));
	END

	RETURN @id;
	
END
GO


-- ----------------------------
-- Function structure for getalertdate
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[getalertdate]') AND type IN ('FN', 'FS', 'FT', 'IF', 'TF'))
	DROP FUNCTION[dbo].[getalertdate]
GO

CREATE FUNCTION [dbo].[getalertdate]
( @call_date AS date 
)
RETURNS date
AS
BEGIN
	-- routine body goes here, e.g.
	-- SELECT 'Navicat for SQL Server'
	declare @alertdate date=DATEADD(day, -7, @call_date);
	return @alertdate;
END
GO


-- ----------------------------
-- Function structure for getname
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[getname]') AND type IN ('FN', 'FS', 'FT', 'IF', 'TF'))
	DROP FUNCTION[dbo].[getname]
GO

CREATE FUNCTION [dbo].[getname]
( @id AS int ,
  @type_id AS int =null
)
RETURNS varchar
AS
BEGIN
	-- routine body goes here, e.g.
	-- SELECT 'Navicat for SQL Server'
	declare @name VARCHAR(50) ;
	if @type_id=null 
		begin
			select @name=name from tbl_name where id=@id;
		end
	else
		begin
			select @name=name from tbl_name where id=@id and @type_id=@type_id;
		end
	return @name;
END
GO


-- ----------------------------
-- Procedure structure for insertCustomer
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[insertCustomer]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[insertCustomer]
GO

CREATE PROCEDURE [dbo].[insertCustomer]
(
	@name NVARCHAR(100),
	@expected DATE,
	@tel_1 VARCHAR(15),
	@tel_2 VARCHAR(15),
	@email VARCHAR(100),
	@fb VARCHAR(100),
	@other NVARCHAR(100),
	@address_id INT,
	@refer_id INT,
	@logger_id INT
)
AS
BEGIN
	DECLARE @name_id INT;
	DECLARE @last_id INT;
	DECLARE @prev_id INT;
	DECLARE @count_row SMALLINT;
	
	SET @count_row = (SELECT count(*) FROM tbl_mom);
	SET @prev_id = (SELECT IDENT_CURRENT('tbl_mom'));
	
	EXEC @name_id = insertName @name,3;
	
	INSERT INTO tbl_mom(name_id,created_at,expected_date,tel_1,tel_2,email,fb,other,address_id,refer_id,logger_id)
	VALUES(@name_id,GETDATE(),@expected,@tel_1,@tel_2,@email,@fb,@other,@address_id,@refer_id,@logger_id);
	
	SET @last_id = (SELECT IDENT_CURRENT('tbl_mom'));
	
	IF @count_row > 0 BEGIN
		IF @prev_id < @last_id BEGIN
			SELECT @last_id;
		END
		ELSE BEGIN
			SELECT 0;
		END
	END
	ELSE BEGIN
		SELECT @last_id;
	END

END
GO


-- ----------------------------
-- Procedure structure for insertSource
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[insertSource]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[insertSource]
GO

CREATE PROCEDURE [dbo].[insertSource]
(
@name NVARCHAR(100),
@owner NVARCHAR(100),
@tel_1 VARCHAR(15),
@tel_2 VARCHAR(15),
@email VARCHAR(100),
@memo NVARCHAR(255),
@image NVARCHAR(255),
@address_id INT,
@type_id SMALLINT,
@logger_id INT
)
AS
BEGIN
	DECLARE @name_id INT;
	DECLARE @owner_id INT;
	DECLARE @last_id INT;
	DECLARE @prev_id INT;
	DECLARE @count_row SMALLINT;
	
	SET @count_row = (SELECT count(*) FROM tbl_refer);
	SET @prev_id = (SELECT IDENT_CURRENT('tbl_refer'));
	
	EXEC @name_id = insertName @name, 1;
	EXEC @owner_id = insertName @owner, 2;
	
	INSERT INTO tbl_refer(name_id,owner_id,created_at,tel_1,tel_2,email,memo,image,address_id,type_id,logger_id)
	VALUES(@name_id,@owner_id,GETDATE(),@tel_1,@tel_2,@email,@memo,@image,@address_id,@type_id,@logger_id);
	
	SET @last_id = (SELECT IDENT_CURRENT('tbl_refer'));
	
	IF @count_row > 0 BEGIN
		IF @prev_id < @last_id BEGIN
			SELECT @last_id;
		END
		ELSE BEGIN
			SELECT 0;
		END
	END
	ELSE BEGIN
		SELECT @last_id;
	END
END
GO


-- ----------------------------
-- Procedure structure for recordLock
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[recordLock]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[recordLock]
GO

CREATE PROCEDURE [dbo].[recordLock]
(
@table_name VARCHAR(20),
@id INT,
@lock SMALLINT
)
AS
BEGIN
	
	DECLARE @data_sql VARCHAR(100);

	SET @data_sql = CONCAT('UPDATE ', @table_name, ' SET locked = ', @lock, ' WHERE id = ', @id);
	
	EXEC (@data_sql);
	
END
GO


-- ----------------------------
-- Procedure structure for insertAlert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[insertAlert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[insertAlert]
GO

CREATE PROCEDURE [dbo].[insertAlert]
(
@mom_id INT,
@kid_id int=null

)
AS
BEGIN
-- 	DECLARE @m_date DATE;
-- 	
-- 	SET @m_date = (SELECT expected_date FROM tbl_mom WHERE id = @mom_id);
	declare @atdate date;
	declare @type int;
		if @kid_id=null
			 BEGIN
					select @atdate=expected_date from tbl_mom where id=@mom_id;
					set @type=2;
			 END
		Else
			 BEGIN
					declare @ct int;
					select @ct=count(*) from tbl_mdata where mom_id=@mom_id and kid_id=@kid_id;
					
					declare @days int=(
						CASE @ct
							WHEN 0 THEN 7
							When 1 then DATEDIFF(day, Getdate(), DATEADD(month, 6, GETDATE()))
							When 2 then DATEDIFF(day, Getdate(), DATEADD(month, 11, GETDATE()))
							When 3 then DATEDIFF(day, Getdate(), DATEADD(month, 24, GETDATE()))
							When 4 then DATEDIFF(day, Getdate(), DATEADD(month, 35, GETDATE()))
							When 5 then DATEDIFF(day, Getdate(), DATEADD(month, 48, GETDATE()))
						END
					);
					set @atdate=DATEADD(day, @days, GETDATE());
					
					If @ct=0
						BEGIN
							set @type=1;
						end
					else
						begin
							set @type=3;
						end
			 end
		 
		
		
		
		
		
		
		
		
  		insert into tbl_alert("at",mom_id,status,type_id,locked) values(@atdate,@mom_id,0,@type,1);
		
END
GO


-- ----------------------------
-- Procedure structure for insertLocation
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[insertLocation]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[insertLocation]
GO

CREATE PROCEDURE [dbo].[insertLocation]
(
@province nvarchar(50),
@district nvarchar(50),
@commune nvarchar(50),
@other nvarchar(100)
)
AS
BEGIN

	DECLARE @p_id INT, @d_id INT, @c_id INT, @o_id INT;
	DECLARE @id INT;
	
	SET @p_id = (SELECT NULLIF(id,0) FROM locations WHERE name = @province);
	IF @p_id is null BEGIN
		INSERT INTO locations(name,master_id) VALUES (@province,0);
		SET @p_id = (SELECT IDENT_CURRENT('locations'));
	END
	
	SET @d_id = (SELECT NULLIF(id,0) FROM locations WHERE name = @district);
	IF @d_id is null BEGIN
		INSERT INTO locations(name,master_id) VALUES (@district,@p_id);
		SET @d_id = (SELECT IDENT_CURRENT('locations'));
	END
	
	SET @c_id = (SELECT NULLIF(id,0) FROM locations WHERE name = @commune);
	IF @c_id is null BEGIN
		INSERT INTO locations(name,master_id) VALUES (@commune,@d_id);
		SET @c_id = (SELECT IDENT_CURRENT('locations'));
	END
	
	
		INSERT INTO locations(name,master_id) VALUES (@other,@c_id);
		SET @o_id = (SELECT IDENT_CURRENT('locations'));


-- 	
-- 	SET @p_id = 1;
-- 	SET @d_id = 2;
-- 	SET @c_id = 3;
-- 	SET @o_id = 4;
	INSERT INTO tbl_address(pro_id, dist_id, com_id, other_id)
	VALUES(@p_id, @d_id, @c_id, @o_id);
	
END
GO


-- ----------------------------
-- Procedure structure for setLocation
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[setLocation]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[setLocation]
GO

CREATE PROCEDURE [dbo].[setLocation]
(
@location NVARCHAR(50),
@master INT
)
AS
BEGIN
DECLARE @id INT;
	SET @id = (SELECT NULLIF(id,0) FROM locations WHERE name = @location);
	IF @id is null BEGIN
		INSERT INTO locations(name,master_id) VALUES (@location,@master);
		SET @id = (SELECT IDENT_CURRENT('locations'));
	END
	SELECT @id;
END
GO


-- ----------------------------
-- Primary Key structure for table tbl_alert
-- ----------------------------
ALTER TABLE [dbo].[tbl_alert] ADD CONSTRAINT [PK__tbl_aler__3213E83FC2A5052C] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_kid
-- ----------------------------
ALTER TABLE [dbo].[tbl_kid] ADD CONSTRAINT [PK__tbl_kid__3213E83F37BCB718] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_mdata
-- ----------------------------
ALTER TABLE [dbo].[tbl_mdata] ADD CONSTRAINT [PK__tbl_mdat__3213E83F16399689] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_mom
-- ----------------------------
ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [PK__tbl_mom__3213E83F4DCB724B] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_name
-- ----------------------------
ALTER TABLE [dbo].[tbl_name] ADD CONSTRAINT [PK__tbl_name__3213E83F5F57A78D] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_pregnent
-- ----------------------------
ALTER TABLE [dbo].[tbl_pregnent] ADD CONSTRAINT [PK__tbl_preg__3213E83FDF4325AA] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_product
-- ----------------------------
ALTER TABLE [dbo].[tbl_product] ADD CONSTRAINT [PK__tbl_prod__3213E83FAF9CD204] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_refer
-- ----------------------------
ALTER TABLE [dbo].[tbl_refer] ADD CONSTRAINT [PK__tbl_refe__3213E83FF1731D24] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_refer_type
-- ----------------------------
ALTER TABLE [dbo].[tbl_refer_type] ADD CONSTRAINT [PK__tbl_refe__3213E83F66ED5FF1] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table tbl_user
-- ----------------------------
ALTER TABLE [dbo].[tbl_user] ADD CONSTRAINT [UQ__tbl_user__F3DBC572326D4C03] UNIQUE NONCLUSTERED ([username] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_user
-- ----------------------------
ALTER TABLE [dbo].[tbl_user] ADD CONSTRAINT [PK__tbl_user__3213E83F4B751EA0] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


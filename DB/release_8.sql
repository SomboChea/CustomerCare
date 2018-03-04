/*
 Navicat Premium Data Transfer

 Source Server         : SQL Server
 Source Server Type    : SQL Server
 Source Server Version : 14001000
 Source Host           : smlogx:1433
 Source Catalog        : TelMarketing
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14001000
 File Encoding         : 65001

 Date: 04/03/2018 12:09:56
*/


-- ----------------------------
-- Table structure for tbl_kid
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_kid]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_kid]
GO

CREATE TABLE [dbo].[tbl_kid] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [sex] smallint  NULL,
  [dob] date  NULL,
  [order] smallint  NULL,
  [mom_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_kid] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Table structure for tbl_location
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_location]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_location]
GO

CREATE TABLE [dbo].[tbl_location] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [refer_id] int DEFAULT ((0)) NULL
)
GO

ALTER TABLE [dbo].[tbl_location] SET (LOCK_ESCALATION = AUTO)
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
  [created_date] datetime2(7)  NULL,
  [why] nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [memo] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [caller_id] int  NULL,
  [call_status] smallint  NULL
)
GO

ALTER TABLE [dbo].[tbl_mdata] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Table structure for tbl_mom
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_mom]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_mom]
GO

CREATE TABLE [dbo].[tbl_mom] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [created_date] datetime2(7)  NULL,
  [expected_date] date  NULL,
  [tel_1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [tel_2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [email] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [fb] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [logger_id] int  NULL,
  [status] smallint  NULL,
  [refer_id] int  NULL,
  [location_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_mom] SET (LOCK_ESCALATION = AUTO)
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
  [pro_id] int  NULL,
  [created_date] datetime2  NULL,
  [why] nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [memo] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [caller_id] int  NULL,
  [call_status] smallint  NULL
)
GO

ALTER TABLE [dbo].[tbl_pregnent] SET (LOCK_ESCALATION = AUTO)
GO

EXEC sp_addextendedproperty
'MS_Description', N'0: Not call yet
1: Called and Step
2: Called and Stop',
'SCHEMA', N'dbo',
'TABLE', N'tbl_pregnent',
'COLUMN', N'call_status'
GO


-- ----------------------------
-- Table structure for tbl_product
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_product]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_product]
GO

CREATE TABLE [dbo].[tbl_product] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [description] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [owner] smallint  NULL,
  [status] smallint DEFAULT ((0)) NULL
)
GO

ALTER TABLE [dbo].[tbl_product] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Table structure for tbl_refer
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_refer]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_refer]
GO

CREATE TABLE [dbo].[tbl_refer] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [owner] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [created_date] datetime2(7)  NULL,
  [tel_1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [tel_2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [image] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [email] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [memo] nvarchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [type_id] int  NULL,
  [logger_id] int  NULL,
  [status] smallint  NULL,
  [location_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_refer] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Table structure for tbl_refer_type
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_refer_type]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_refer_type]
GO

CREATE TABLE [dbo].[tbl_refer_type] (
  [id] int  IDENTITY(1,1) NOT NULL,
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
  [fullname] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [username] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [password] varchar(35) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [created_date] datetime2  NULL,
  [role_id] smallint  NULL
)
GO

ALTER TABLE [dbo].[tbl_user] SET (LOCK_ESCALATION = AUTO)
GO

EXEC sp_addextendedproperty
'MS_Description', N'0: Admin (All)
1: Standard (Insert / Update / View)
2: Report only (View reports)',
'SCHEMA', N'dbo',
'TABLE', N'tbl_user',
'COLUMN', N'role_id'
GO


-- ----------------------------
-- View structure for viewCommunes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewCommunes]') AND type IN ('V'))
	DROP VIEW [dbo].[viewCommunes]
GO

CREATE VIEW [dbo].[viewCommunes] AS SELECT
c.id ,
 c.name ,
c.refer_id  
FROM
	tbl_location  c
	INNER JOIN viewDistricts d ON  c.refer_id  =  d.id ;
GO


-- ----------------------------
-- View structure for viewDistricts
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewDistricts]') AND type IN ('V'))
	DROP VIEW [dbo].[viewDistricts]
GO

CREATE VIEW [dbo].[viewDistricts] AS SELECT
	d.id,
	d.name,
	d.refer_id 
FROM
	tbl_location d
	INNER JOIN viewProvinces p ON d.refer_id = p.id;
GO


-- ----------------------------
-- View structure for viewLocations
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewLocations]') AND type IN ('V'))
	DROP VIEW [dbo].[viewLocations]
GO

CREATE VIEW [dbo].[viewLocations] AS SELECT
a.id address_id,
a.name Address,
c.name Commune,
d.name District,
p.name Province 
FROM
	tbl_location  a
	INNER JOIN viewCommunes c ON a.refer_id = c.id
	INNER JOIN viewDistricts d ON c.refer_id = d.id
	INNER JOIN viewProvinces p ON d.refer_id = p.id;
GO


-- ----------------------------
-- View structure for viewProvinces
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewProvinces]') AND type IN ('V'))
	DROP VIEW [dbo].[viewProvinces]
GO

CREATE VIEW [dbo].[viewProvinces] AS SELECT
	id,
name 
FROM
	tbl_location 
WHERE
	refer_id = 0;
GO


-- ----------------------------
-- Primary Key structure for table tbl_kid
-- ----------------------------
ALTER TABLE [dbo].[tbl_kid] ADD CONSTRAINT [PK__tbl_kid__3213E83F59C4085F] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_location
-- ----------------------------
ALTER TABLE [dbo].[tbl_location] ADD CONSTRAINT [PK__tbl_loca__3213E83F351EDA11] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_mdata
-- ----------------------------
ALTER TABLE [dbo].[tbl_mdata] ADD CONSTRAINT [PK__tbl_mdat__3213E83FE68D59C6] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table tbl_mom
-- ----------------------------
ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [UQ__tbl_mom__7E1FAC9A0D882649] UNIQUE NONCLUSTERED ([name] ASC, [tel_1] ASC, [tel_2] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_mom
-- ----------------------------
ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [PK__tbl_mom__3213E83F3598543E] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_pregnent
-- ----------------------------
ALTER TABLE [dbo].[tbl_pregnent] ADD CONSTRAINT [PK__tbl_preg__3213E83F886A20C5] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_product
-- ----------------------------
ALTER TABLE [dbo].[tbl_product] ADD CONSTRAINT [PK__tbl_prod__3213E83F0BEFAC37] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table tbl_refer
-- ----------------------------
ALTER TABLE [dbo].[tbl_refer] ADD CONSTRAINT [UQ__tbl_refe__7E1FAC9A8EDB2430] UNIQUE NONCLUSTERED ([name] ASC, [tel_1] ASC, [tel_2] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_refer
-- ----------------------------
ALTER TABLE [dbo].[tbl_refer] ADD CONSTRAINT [PK__tbl_refe__3213E83FA59D9A0E] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_refer_type
-- ----------------------------
ALTER TABLE [dbo].[tbl_refer_type] ADD CONSTRAINT [PK__tbl_refe__3213E83F76C88467] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_user
-- ----------------------------
ALTER TABLE [dbo].[tbl_user] ADD CONSTRAINT [PK__tbl_user__3213E83FA19C2983] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_kid
-- ----------------------------
ALTER TABLE [dbo].[tbl_kid] ADD CONSTRAINT [fk_tbl_kid_tbl_mom_1] FOREIGN KEY ([mom_id]) REFERENCES [dbo].[tbl_mom] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_mdata
-- ----------------------------
ALTER TABLE [dbo].[tbl_mdata] ADD CONSTRAINT [fk_tbl_mdata_tbl_user_1] FOREIGN KEY ([caller_id]) REFERENCES [dbo].[tbl_user] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mdata] ADD CONSTRAINT [fk_tbl_mdata_tbl_kid_1] FOREIGN KEY ([kid_id]) REFERENCES [dbo].[tbl_kid] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mdata] ADD CONSTRAINT [fk_tbl_mdata_tbl_product_1] FOREIGN KEY ([pro_id]) REFERENCES [dbo].[tbl_product] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_mom
-- ----------------------------
ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [fk_tbl_mom_tbl_location_1] FOREIGN KEY ([location_id]) REFERENCES [dbo].[tbl_location] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [fk_tbl_mom_tbl_refer_1] FOREIGN KEY ([refer_id]) REFERENCES [dbo].[tbl_refer] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [fk_tbl_mom_tbl_user_1] FOREIGN KEY ([logger_id]) REFERENCES [dbo].[tbl_user] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_pregnent
-- ----------------------------
ALTER TABLE [dbo].[tbl_pregnent] ADD CONSTRAINT [fk_tbl_pregnent_tbl_mom_1] FOREIGN KEY ([mom_id]) REFERENCES [dbo].[tbl_mom] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_pregnent] ADD CONSTRAINT [fk_tbl_pregnent_tbl_product_1] FOREIGN KEY ([pro_id]) REFERENCES [dbo].[tbl_product] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_pregnent] ADD CONSTRAINT [fk_tbl_pregnent_tbl_user_1] FOREIGN KEY ([caller_id]) REFERENCES [dbo].[tbl_user] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_refer
-- ----------------------------
ALTER TABLE [dbo].[tbl_refer] ADD CONSTRAINT [fk_tbl_refer_tbl_location_1] FOREIGN KEY ([location_id]) REFERENCES [dbo].[tbl_location] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_refer] ADD CONSTRAINT [fk_tbl_refer_tbl_refer_type_1] FOREIGN KEY ([type_id]) REFERENCES [dbo].[tbl_refer_type] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_refer] ADD CONSTRAINT [fk_tbl_refer_tbl_user_1] FOREIGN KEY ([logger_id]) REFERENCES [dbo].[tbl_user] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


/*
 Navicat Premium Data Transfer

 Source Server         : SQL Server
 Source Server Type    : SQL Server
 Source Server Version : 14001000
 Source Host           : localhost:1433
 Source Catalog        : CustomerCare
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14001000
 File Encoding         : 65001

 Date: 24/01/2018 20:15:32
*/


-- ----------------------------
-- Table structure for tbl_access_options
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_access_options]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_access_options]
GO

CREATE TABLE [dbo].[tbl_access_options] (
  [pos_id] int  NOT NULL,
  [option_id] int  NOT NULL
)
GO

ALTER TABLE [dbo].[tbl_access_options] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N' ',
'SCHEMA', N'dbo',
'TABLE', N'tbl_access_options',
'COLUMN', N'pos_id'
GO


-- ----------------------------
-- Table structure for tbl_address
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_address]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_address]
GO

CREATE TABLE [dbo].[tbl_address] (
  [address_id] int  IDENTITY(1,1) NOT NULL,
  [sk_id] int  NULL,
  [st_road] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tbl_address] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_afdelivery
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_afdelivery]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_afdelivery]
GO

CREATE TABLE [dbo].[tbl_afdelivery] (
  [aft_id] int  IDENTITY(1,1) NOT NULL,
  [kid_id] int  NOT NULL,
  [call_date] datetime2(7)  NULL,
  [sec_call] datetime2(7)  NULL,
  [pro_id] int  NULL,
  [memo] nvarchar(100) COLLATE Khmer_100_BIN2  NULL,
  [why] nvarchar(100) COLLATE Khmer_100_BIN2  NULL
)
GO

ALTER TABLE [dbo].[tbl_afdelivery] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_bfdelivery
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_bfdelivery]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_bfdelivery]
GO

CREATE TABLE [dbo].[tbl_bfdelivery] (
  [bef_id] int  IDENTITY(1,1) NOT NULL,
  [bef_exp_date] datetime2(7)  NULL,
  [call_date] datetime2(7)  NULL,
  [pro_id] int  NULL,
  [memo] nvarchar(100) COLLATE Khmer_100_BIN2  NULL,
  [why] nvarchar(100) COLLATE Khmer_100_BIN2  NULL,
  [call_status] smallint  NULL
)
GO

ALTER TABLE [dbo].[tbl_bfdelivery] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'Expected date',
'SCHEMA', N'dbo',
'TABLE', N'tbl_bfdelivery',
'COLUMN', N'bef_exp_date'
GO


-- ----------------------------
-- Table structure for tbl_category
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_category]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_category]
GO

CREATE TABLE [dbo].[tbl_category] (
  [cate_id] int  IDENTITY(1,1) NOT NULL,
  [cate_name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tbl_category] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_hcp
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_hcp]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_hcp]
GO

CREATE TABLE [dbo].[tbl_hcp] (
  [hcp_id] int  IDENTITY(1,1) NOT NULL,
  [hcp_name] nvarchar(50) COLLATE Khmer_100_BIN2  NOT NULL,
  [hcp_owner] nvarchar(50) COLLATE Khmer_100_BIN2  NOT NULL,
  [address_id] int  NULL,
  [hcp_tel1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [hcp_tel2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [hcp_email] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [hcp_fb] nvarchar(100) COLLATE Khmer_100_BIN2  NULL,
  [hcp_memo] nvarchar(100) COLLATE Khmer_100_BIN2  NULL
)
GO

ALTER TABLE [dbo].[tbl_hcp] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_kid
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_kid]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_kid]
GO

CREATE TABLE [dbo].[tbl_kid] (
  [kid_id] int  IDENTITY(1,1) NOT NULL,
  [kid_name] nvarchar(50) COLLATE Khmer_100_BIN2  NOT NULL,
  [kid_dob] datetime2(7)  NOT NULL,
  [kid_sex] nvarchar(10) COLLATE Khmer_100_BIN2  NOT NULL,
  [mom_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_kid] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_kiddetails
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_kiddetails]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_kiddetails]
GO

CREATE TABLE [dbo].[tbl_kiddetails] (
  [kid_id] int  NULL,
  [pro_id] int  NULL,
  [kid_why] nvarchar(255) COLLATE Khmer_100_BIN2  NULL
)
GO

ALTER TABLE [dbo].[tbl_kiddetails] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_ks
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_ks]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_ks]
GO

CREATE TABLE [dbo].[tbl_ks] (
  [ks_id] int  IDENTITY(1,1) NOT NULL,
  [ks_name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [pc_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_ks] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_mom
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_mom]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_mom]
GO

CREATE TABLE [dbo].[tbl_mom] (
  [mom_id] int  IDENTITY(1,1) NOT NULL,
  [mom_name] nvarchar(50) COLLATE Khmer_100_BIN2  NOT NULL,
  [mom_rec_date] datetime2(7)  NULL,
  [mom_tel1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [mom_tel2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [mom_tel3] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [mom_call_date] datetime2(7)  NULL,
  [mom_ept_date] date  NULL,
  [pro_id] int  NULL,
  [mom_fb] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [mom_email] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [mom_location] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [staff_id] int  NULL,
  [hcp_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_mom] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_mstretail
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_mstretail]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_mstretail]
GO

CREATE TABLE [dbo].[tbl_mstretail] (
  [ret_id] int  IDENTITY(1,1) NOT NULL,
  [ret_name] nvarchar(50) COLLATE Khmer_100_BIN2  NOT NULL,
  [owner] nvarchar(50) COLLATE Khmer_100_BIN2  NULL,
  [pc_id] int  NULL,
  [address_id] int  NULL,
  [tel1] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [tel2] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [tel3] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [side] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [staff_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_mstretail] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_mststaff
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_mststaff]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_mststaff]
GO

CREATE TABLE [dbo].[tbl_mststaff] (
  [staff_id] int  IDENTITY(1,1) NOT NULL,
  [name_en] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [name_kh] nvarchar(50) COLLATE Khmer_100_BIN2  NULL,
  [pos_id] int  NULL,
  [emp_date] datetime2(7)  NULL,
  [tel_per1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [tel_per2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [tel_com] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [email] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [photo] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [emp_note] nvarchar(255) COLLATE Khmer_100_BIN2  NULL
)
GO

ALTER TABLE [dbo].[tbl_mststaff] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_options
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_options]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_options]
GO

CREATE TABLE [dbo].[tbl_options] (
  [option_id] int  IDENTITY(1,1) NOT NULL,
  [option_name] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [tag] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tbl_options] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_pos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_pos]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_pos]
GO

CREATE TABLE [dbo].[tbl_pos] (
  [pos_id] int  IDENTITY(1,1) NOT NULL,
  [pos_en] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [pos_kh] nvarchar(50) COLLATE Khmer_100_BIN2  NULL
)
GO

ALTER TABLE [dbo].[tbl_pos] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_product
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_product]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_product]
GO

CREATE TABLE [dbo].[tbl_product] (
  [pro_id] int  IDENTITY(1,1) NOT NULL,
  [pro_name] nvarchar(50) COLLATE Khmer_100_BIN  NOT NULL,
  [description] nvarchar(100) COLLATE Khmer_100_BIN  NULL,
  [cate_id] int  NULL,
  [owner] smallint  NULL,
  [status] smallint  NULL
)
GO

ALTER TABLE [dbo].[tbl_product] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'If 1 owner product and 0 other product',
'SCHEMA', N'dbo',
'TABLE', N'tbl_product',
'COLUMN', N'owner'
GO


-- ----------------------------
-- Table structure for tbl_provinces
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_provinces]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_provinces]
GO

CREATE TABLE [dbo].[tbl_provinces] (
  [pc_id] int  IDENTITY(1,1) NOT NULL,
  [pc_name] nvarchar(50) COLLATE Khmer_100_BIN2  NULL
)
GO

ALTER TABLE [dbo].[tbl_provinces] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_sk
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_sk]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_sk]
GO

CREATE TABLE [dbo].[tbl_sk] (
  [sk_id] int  IDENTITY(1,1) NOT NULL,
  [sk_name] nvarchar(50) COLLATE Khmer_100_BIN2  NULL,
  [ks_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_sk] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_users
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_users]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_users]
GO

CREATE TABLE [dbo].[tbl_users] (
  [user_id] int  IDENTITY(1,1) NOT NULL,
  [username] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [password] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [staff_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_users] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- View structure for viewAddresses
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewAddresses]') AND type IN ('V'))
	DROP VIEW [dbo].[viewAddresses]
GO

CREATE VIEW [dbo].[viewAddresses] AS SELECT
dbo.tbl_address.address_id [id],
dbo.tbl_address.st_road [st_info],
dbo.tbl_sk.sk_name [commue],
dbo.tbl_ks.ks_name [district],
dbo.tbl_provinces.pc_name [province]

FROM
dbo.tbl_address
INNER JOIN dbo.tbl_sk ON dbo.tbl_address.sk_id = dbo.tbl_sk.sk_id
INNER JOIN dbo.tbl_ks ON dbo.tbl_sk.ks_id = dbo.tbl_ks.ks_id
INNER JOIN dbo.tbl_provinces ON dbo.tbl_ks.pc_id = dbo.tbl_provinces.pc_id
GO


-- ----------------------------
-- View structure for viewHcp
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewHcp]') AND type IN ('V'))
	DROP VIEW [dbo].[viewHcp]
GO

CREATE VIEW [dbo].[viewHcp] AS SELECT
	h.hcp_id AS ID,
	h.hcp_memo AS Memo,
	h.hcp_name AS hcpName,
	h.hcp_owner AS Owner,
	h.hcp_tel1 AS Tel,
	h.hcp_tel2 AS Tel2,
	h.hcp_email AS Email,
	h.hcp_fb AS Facebook,
	dbo.tbl_provinces.pc_name AS Location,
	dbo.tbl_ks.ks_name AS District,
	dbo.tbl_sk.sk_name AS Commune,
	dbo.tbl_address.st_road AS ST,
	h.address_id AS AddrID 
FROM
	dbo.tbl_hcp AS h
	INNER JOIN dbo.tbl_address ON h.address_id = dbo.tbl_address.address_id
	INNER JOIN dbo.tbl_sk ON dbo.tbl_address.sk_id = dbo.tbl_sk.sk_id
	INNER JOIN dbo.tbl_ks ON dbo.tbl_sk.ks_id = dbo.tbl_ks.ks_id
	INNER JOIN dbo.tbl_provinces ON dbo.tbl_ks.pc_id = dbo.tbl_provinces.pc_id
GO


-- ----------------------------
-- View structure for viewKid
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewKid]') AND type IN ('V'))
	DROP VIEW [dbo].[viewKid]
GO

CREATE VIEW [dbo].[viewKid] AS SELECT
dbo.tbl_kid.kid_id AS ID,
dbo.tbl_kid.kid_name AS Name,
dbo.tbl_kid.kid_dob AS [Date of Birth],
dbo.tbl_kid.kid_sex AS Gender,
dbo.tbl_kid.mom_id AS Mom_ID

FROM
dbo.tbl_kid
GO


-- ----------------------------
-- View structure for viewRoleAccessOptions
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewRoleAccessOptions]') AND type IN ('V'))
	DROP VIEW [dbo].[viewRoleAccessOptions]
GO

CREATE VIEW [dbo].[viewRoleAccessOptions] AS SELECT
dbo.tbl_pos.pos_id,
dbo.tbl_pos.pos_en,
dbo.tbl_options.option_name,
dbo.tbl_options.tag

FROM
dbo.tbl_options
INNER JOIN dbo.tbl_access_options ON dbo.tbl_access_options.option_id = dbo.tbl_options.option_id
INNER JOIN dbo.tbl_pos ON dbo.tbl_access_options.pos_id = dbo.tbl_pos.pos_id
GO


-- ----------------------------
-- View structure for viewStaff
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewStaff]') AND type IN ('V'))
	DROP VIEW [dbo].[viewStaff]
GO

CREATE VIEW [dbo].[viewStaff] AS SELECT
dbo.tbl_mststaff.staff_id AS ID,
dbo.tbl_mststaff.name_en AS [Name in English],
dbo.tbl_mststaff.name_kh AS [Name in Khmer],
dbo.tbl_pos.pos_en AS Position,
dbo.tbl_mststaff.email AS Email,
dbo.tbl_mststaff.emp_date AS [Hire Date],

dbo.tbl_mststaff.tel_per1 AS [Tel 1],
dbo.tbl_mststaff.tel_per2 AS [Tel 2],
dbo.tbl_mststaff.tel_com AS [Tel Com],
dbo.tbl_mststaff.emp_note AS Note,
dbo.tbl_mststaff.photo AS Photo

FROM
dbo.tbl_mststaff
INNER JOIN dbo.tbl_pos ON dbo.tbl_mststaff.pos_id = dbo.tbl_pos.pos_id
GO


-- ----------------------------
-- Procedure structure for getRoleOptionsById
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[getRoleOptionsById]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[getRoleOptionsById]
GO

CREATE PROCEDURE [dbo].[getRoleOptionsById] (@id INT)
	AS
BEGIN
	SELECT * FROM viewRoleAccessOptions WHERE pos_id = @id;
END
GO


-- ----------------------------
-- Primary Key structure for table tbl_access_options
-- ----------------------------
ALTER TABLE [dbo].[tbl_access_options] ADD CONSTRAINT [PK__tbl_acce__D947C92D498E6E7C] PRIMARY KEY CLUSTERED ([pos_id], [option_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_address
-- ----------------------------
ALTER TABLE [dbo].[tbl_address] ADD CONSTRAINT [PK__tbl_addr__CAA247C820739773] PRIMARY KEY CLUSTERED ([address_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_afdelivery
-- ----------------------------
ALTER TABLE [dbo].[tbl_afdelivery] ADD CONSTRAINT [PK__tbl_afde__EE6E1CBF09EBEF71] PRIMARY KEY CLUSTERED ([aft_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_bfdelivery
-- ----------------------------
ALTER TABLE [dbo].[tbl_bfdelivery] ADD CONSTRAINT [PK__tbl_bfde__31AE7E09FB23E68E] PRIMARY KEY CLUSTERED ([bef_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_category
-- ----------------------------
ALTER TABLE [dbo].[tbl_category] ADD CONSTRAINT [PK__tbl_cate__34EAD17365C9DF39] PRIMARY KEY CLUSTERED ([cate_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table tbl_hcp
-- ----------------------------
ALTER TABLE [dbo].[tbl_hcp] ADD CONSTRAINT [UQ__tbl_hcp__B5C4F776EB64E3C0] UNIQUE NONCLUSTERED ([hcp_tel1] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_hcp
-- ----------------------------
ALTER TABLE [dbo].[tbl_hcp] ADD CONSTRAINT [PK__tbl_hcp__6DB840221FB8CDEE] PRIMARY KEY CLUSTERED ([hcp_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_kid
-- ----------------------------
ALTER TABLE [dbo].[tbl_kid] ADD CONSTRAINT [PK__tbl_kid__F163BDD806746456] PRIMARY KEY CLUSTERED ([kid_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_ks
-- ----------------------------
ALTER TABLE [dbo].[tbl_ks] ADD CONSTRAINT [PK__tbl_ks__09A1E1E049DDABB0] PRIMARY KEY CLUSTERED ([ks_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table tbl_mom
-- ----------------------------
ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [UQ__tbl_mom__30EDD7918196A84D] UNIQUE NONCLUSTERED ([mom_tel1] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_mom
-- ----------------------------
ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [PK__tbl_mum__C80717EB1510317A] PRIMARY KEY CLUSTERED ([mom_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table tbl_mstretail
-- ----------------------------
ALTER TABLE [dbo].[tbl_mstretail] ADD CONSTRAINT [UQ__tbl_mstr__E0F9778E8F652E85] UNIQUE NONCLUSTERED ([tel1] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_mstretail
-- ----------------------------
ALTER TABLE [dbo].[tbl_mstretail] ADD CONSTRAINT [PK__tbl_mstr__E9F34A40E428F0C0] PRIMARY KEY CLUSTERED ([ret_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_mststaff
-- ----------------------------
ALTER TABLE [dbo].[tbl_mststaff] ADD CONSTRAINT [PK__tbl_msts__1963DD9C52218D3B] PRIMARY KEY CLUSTERED ([staff_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_options
-- ----------------------------
ALTER TABLE [dbo].[tbl_options] ADD CONSTRAINT [PK__tbl_opti__F4EACE1B304A1DFD] PRIMARY KEY CLUSTERED ([option_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table tbl_pos
-- ----------------------------
ALTER TABLE [dbo].[tbl_pos] ADD CONSTRAINT [UQ__tbl_pos__D1A4B8DA70EF7B6B] UNIQUE NONCLUSTERED ([pos_en] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_pos
-- ----------------------------
ALTER TABLE [dbo].[tbl_pos] ADD CONSTRAINT [PK__tbl_pos__D1A4EB127A498A22] PRIMARY KEY CLUSTERED ([pos_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_product
-- ----------------------------
ALTER TABLE [dbo].[tbl_product] ADD CONSTRAINT [PK__tbl_prod__335E4CA69EA62605] PRIMARY KEY CLUSTERED ([pro_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_provinces
-- ----------------------------
ALTER TABLE [dbo].[tbl_provinces] ADD CONSTRAINT [PK__tbl_prov__1D3A69C0432715D6] PRIMARY KEY CLUSTERED ([pc_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_sk
-- ----------------------------
ALTER TABLE [dbo].[tbl_sk] ADD CONSTRAINT [PK__tbl_sk__60CD9F26DC0A85EF] PRIMARY KEY CLUSTERED ([sk_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Uniques structure for table tbl_users
-- ----------------------------
ALTER TABLE [dbo].[tbl_users] ADD CONSTRAINT [UQ__tbl_user__F3DBC5725ADD2F82] UNIQUE NONCLUSTERED ([username] ASC)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_users
-- ----------------------------
ALTER TABLE [dbo].[tbl_users] ADD CONSTRAINT [PK__tbl_user__B9BE370FB64541BF] PRIMARY KEY CLUSTERED ([user_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_access_options
-- ----------------------------
ALTER TABLE [dbo].[tbl_access_options] ADD CONSTRAINT [FK__tbl_acces__optio__30C33EC3] FOREIGN KEY ([option_id]) REFERENCES [dbo].[tbl_options] ([option_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_access_options] ADD CONSTRAINT [FK__tbl_acces__pos_i__5D95E53A] FOREIGN KEY ([pos_id]) REFERENCES [dbo].[tbl_pos] ([pos_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_address
-- ----------------------------
ALTER TABLE [dbo].[tbl_address] ADD CONSTRAINT [FK__tbl_addre__sk_id__73852659] FOREIGN KEY ([sk_id]) REFERENCES [dbo].[tbl_sk] ([sk_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_afdelivery
-- ----------------------------
ALTER TABLE [dbo].[tbl_afdelivery] ADD CONSTRAINT [FK__tbl_afdel__kid_i__693CA210] FOREIGN KEY ([kid_id]) REFERENCES [dbo].[tbl_kid] ([kid_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_afdelivery] ADD CONSTRAINT [FK__tbl_afdel__pro_i__74AE54BC] FOREIGN KEY ([pro_id]) REFERENCES [dbo].[tbl_product] ([pro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_bfdelivery
-- ----------------------------
ALTER TABLE [dbo].[tbl_bfdelivery] ADD CONSTRAINT [FK__tbl_bfdel__pro_i__72C60C4A] FOREIGN KEY ([pro_id]) REFERENCES [dbo].[tbl_product] ([pro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_hcp
-- ----------------------------
ALTER TABLE [dbo].[tbl_hcp] ADD CONSTRAINT [FK__tbl_hcp__address__44CA3770] FOREIGN KEY ([address_id]) REFERENCES [dbo].[tbl_address] ([address_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_kid
-- ----------------------------
ALTER TABLE [dbo].[tbl_kid] ADD CONSTRAINT [FK__tbl_kid__mom_id__41B8C09B] FOREIGN KEY ([mom_id]) REFERENCES [dbo].[tbl_mom] ([mom_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_kiddetails
-- ----------------------------
ALTER TABLE [dbo].[tbl_kiddetails] ADD CONSTRAINT [FK__tbl_kidde__kid_i__6A30C649] FOREIGN KEY ([kid_id]) REFERENCES [dbo].[tbl_kid] ([kid_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_kiddetails] ADD CONSTRAINT [FK__tbl_kidde__pro_i__6B24EA82] FOREIGN KEY ([pro_id]) REFERENCES [dbo].[tbl_product] ([pro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_ks
-- ----------------------------
ALTER TABLE [dbo].[tbl_ks] ADD CONSTRAINT [FK__tbl_ks__pc_id__3E1D39E1] FOREIGN KEY ([pc_id]) REFERENCES [dbo].[tbl_provinces] ([pc_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_mom
-- ----------------------------
ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [FK__tbl_mom__pro_id__2CBDA3B5] FOREIGN KEY ([pro_id]) REFERENCES [dbo].[tbl_product] ([pro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [FK__tbl_mom__staff_i__2DB1C7EE] FOREIGN KEY ([staff_id]) REFERENCES [dbo].[tbl_mststaff] ([staff_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [FK__tbl_mom__hcp_id__2EA5EC27] FOREIGN KEY ([hcp_id]) REFERENCES [dbo].[tbl_hcp] ([hcp_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_mstretail
-- ----------------------------
ALTER TABLE [dbo].[tbl_mstretail] ADD CONSTRAINT [FK__tbl_mstre__staff__18EBB532] FOREIGN KEY ([staff_id]) REFERENCES [dbo].[tbl_mststaff] ([staff_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mstretail] ADD CONSTRAINT [FK__tbl_mstre__addre__42E1EEFE] FOREIGN KEY ([address_id]) REFERENCES [dbo].[tbl_address] ([address_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_mststaff
-- ----------------------------
ALTER TABLE [dbo].[tbl_mststaff] ADD CONSTRAINT [FK__tbl_mstst__pos_i__5CA1C101] FOREIGN KEY ([pos_id]) REFERENCES [dbo].[tbl_pos] ([pos_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_product
-- ----------------------------
ALTER TABLE [dbo].[tbl_product] ADD CONSTRAINT [FK__tbl_produ__cate___6EF57B66] FOREIGN KEY ([cate_id]) REFERENCES [dbo].[tbl_category] ([cate_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_sk
-- ----------------------------
ALTER TABLE [dbo].[tbl_sk] ADD CONSTRAINT [FK__tbl_sk__ks_id__3F115E1A] FOREIGN KEY ([ks_id]) REFERENCES [dbo].[tbl_ks] ([ks_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_users
-- ----------------------------
ALTER TABLE [dbo].[tbl_users] ADD CONSTRAINT [FK__tbl_users__staff__3D2915A8] FOREIGN KEY ([staff_id]) REFERENCES [dbo].[tbl_mststaff] ([staff_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


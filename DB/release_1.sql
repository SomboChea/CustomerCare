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

 Date: 08/01/2018 13:22:05
*/


-- ----------------------------
-- Table structure for tbl_afdelivery
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_afdelivery]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_afdelivery]
GO

CREATE TABLE [dbo].[tbl_afdelivery] (
  [aft_id] int IDENTITY(1,1) NOT NULL,
  [kid_id] int NOT NULL,
  [call_date] datetime2(7) NULL,
  [sec_call] datetime2(7) NULL,
  [pro_id] int NULL,
  [opro_id] int NULL,
  [memo2] nvarchar(100) COLLATE Khmer_100_BIN2 NULL,
  [why] nvarchar(100) COLLATE Khmer_100_BIN2 NULL
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
  [bef_id] int IDENTITY(1,1) NOT NULL,
  [bef_exp_date] datetime2(7) NULL,
  [call_date] datetime2(7) NULL,
  [pro_id] int NULL,
  [opro_id] int NULL,
  [memo1] nvarchar(100) COLLATE Khmer_100_BIN2 NULL,
  [why] nvarchar(100) COLLATE Khmer_100_BIN2 NULL,
  [call_status] smallint NULL
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
  [cate_id] int IDENTITY(1,1) NOT NULL,
  [cate_name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
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
  [hcp_id] int IDENTITY(1,1) NOT NULL,
  [hcp_name] nvarchar(50) COLLATE Khmer_100_BIN2 NULL,
  [hcp_owner] nvarchar(50) COLLATE Khmer_100_BIN2 NULL,
  [hcp_location] nvarchar(50) COLLATE Khmer_100_BIN2 NULL,
  [hcp_srok] nvarchar(50) COLLATE Khmer_100_BIN2 NULL,
  [hcp_comm] nvarchar(50) COLLATE Khmer_100_BIN2 NULL,
  [hcp_st] nvarchar(50) COLLATE Khmer_100_BIN2 NULL,
  [hcp_tel1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [hcp_tel2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [hcp_email] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [hcp_fb] nvarchar(100) COLLATE Khmer_100_BIN2 NULL,
  [hcp_memo] nvarchar(100) COLLATE Khmer_100_BIN2 NULL
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
  [kid_id] int IDENTITY(1,1) NOT NULL,
  [kid_name] nvarchar(50) COLLATE Khmer_100_BIN2 NOT NULL,
  [kid_dob] datetime2(7) NOT NULL,
  [kid_sex] nvarchar(10) COLLATE Khmer_100_BIN2 NOT NULL,
  [kid_order] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
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
  [kid_id] int NULL,
  [pro_id] int NULL,
  [opro_id] int NULL,
  [kid_why] nvarchar(255) COLLATE Khmer_100_BIN2 NULL
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
  [ks_id] int IDENTITY(1,1) NOT NULL,
  [ks_name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO

ALTER TABLE [dbo].[tbl_ks] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_mstretail
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_mstretail]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_mstretail]
GO

CREATE TABLE [dbo].[tbl_mstretail] (
  [ret_id] int IDENTITY(1,1) NOT NULL,
  [ret_name] nvarchar(50) COLLATE Khmer_100_BIN2 NOT NULL,
  [owner] nvarchar(50) COLLATE Khmer_100_BIN2 NULL,
  [pc_id] int NULL,
  [sk_id] int NULL,
  [ks_id] int NULL,
  [st] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [tel1] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [tel2] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [tel3] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [side] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [staff_id] int NULL
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
  [staff_id] int IDENTITY(1,1) NOT NULL,
  [name_en] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [name_kh] nvarchar(50) COLLATE Khmer_100_BIN2 NULL,
  [pos_id] int NULL,
  [emp_date] datetime2(7) NULL,
  [tel_per1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [tel_per2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [tel_com] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [email] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [photo] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [emp_note] nvarchar(255) COLLATE Khmer_100_BIN2 NULL,
  [line_id] int NULL,
  [other] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO

ALTER TABLE [dbo].[tbl_mststaff] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_mum
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_mum]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_mum]
GO

CREATE TABLE [dbo].[tbl_mum] (
  [mum_id] int IDENTITY(1,1) NOT NULL,
  [mum_name] nvarchar(50) COLLATE Khmer_100_BIN2 NULL,
  [mum_rec_date] datetime2(7) NULL,
  [mum_tel1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [mum_tel2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [mum_tel3] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [mum_call_date] datetime2(7) NULL,
  [mum_frm_source] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [mum_ept_date] datetime2(7) NULL,
  [pro_id] int NULL,
  [mum_fb] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [mum_email] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [mum_location] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [kid_id] int NULL,
  [staff_id] int NULL,
  [hcp_id] int NULL
)
GO

ALTER TABLE [dbo].[tbl_mum] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_otherpro
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_otherpro]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_otherpro]
GO

CREATE TABLE [dbo].[tbl_otherpro] (
  [opro_id] int IDENTITY(1,1) NOT NULL,
  [opro_name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [description] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [cate_id] int NULL
)
GO

ALTER TABLE [dbo].[tbl_otherpro] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_pos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_pos]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_pos]
GO

CREATE TABLE [dbo].[tbl_pos] (
  [pos_id] int IDENTITY(1,1) NOT NULL,
  [pos_en] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [pos_kh] nvarchar(50) COLLATE Khmer_100_BIN2 NULL
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
  [pro_id] int IDENTITY(1,1) NOT NULL,
  [pro_name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
  [description] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [cate_id] int NULL
)
GO

ALTER TABLE [dbo].[tbl_product] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tbl_provinces
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_provinces]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_provinces]
GO

CREATE TABLE [dbo].[tbl_provinces] (
  [pc_id] int IDENTITY(1,1) NOT NULL,
  [pc_name] nvarchar(50) COLLATE Khmer_100_BIN2 NULL
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
  [sk_id] int IDENTITY(1,1) NOT NULL,
  [sk_name] nvarchar(50) COLLATE Khmer_100_BIN2 NULL
)
GO

ALTER TABLE [dbo].[tbl_sk] SET (LOCK_ESCALATION = TABLE)
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
-- Primary Key structure for table tbl_mum
-- ----------------------------
ALTER TABLE [dbo].[tbl_mum] ADD CONSTRAINT [PK__tbl_mum__C80717EB1510317A] PRIMARY KEY CLUSTERED ([mum_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_otherpro
-- ----------------------------
ALTER TABLE [dbo].[tbl_otherpro] ADD CONSTRAINT [PK__tbl_othe__AE382861285C73EA] PRIMARY KEY CLUSTERED ([opro_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
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
-- Foreign Keys structure for table tbl_afdelivery
-- ----------------------------
ALTER TABLE [dbo].[tbl_afdelivery] ADD CONSTRAINT [FK__tbl_afdel__kid_i__693CA210] FOREIGN KEY ([kid_id]) REFERENCES [tbl_kid] ([kid_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_afdelivery] ADD CONSTRAINT [FK__tbl_afdel__pro_i__74AE54BC] FOREIGN KEY ([pro_id]) REFERENCES [tbl_product] ([pro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_afdelivery] ADD CONSTRAINT [FK__tbl_afdel__opro___75A278F5] FOREIGN KEY ([opro_id]) REFERENCES [tbl_otherpro] ([opro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_bfdelivery
-- ----------------------------
ALTER TABLE [dbo].[tbl_bfdelivery] ADD CONSTRAINT [FK__tbl_bfdel__pro_i__72C60C4A] FOREIGN KEY ([pro_id]) REFERENCES [tbl_product] ([pro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_bfdelivery] ADD CONSTRAINT [FK__tbl_bfdel__opro___73BA3083] FOREIGN KEY ([opro_id]) REFERENCES [tbl_otherpro] ([opro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_kiddetails
-- ----------------------------
ALTER TABLE [dbo].[tbl_kiddetails] ADD CONSTRAINT [FK__tbl_kidde__kid_i__6A30C649] FOREIGN KEY ([kid_id]) REFERENCES [tbl_kid] ([kid_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_kiddetails] ADD CONSTRAINT [FK__tbl_kidde__pro_i__6B24EA82] FOREIGN KEY ([pro_id]) REFERENCES [tbl_product] ([pro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_kiddetails] ADD CONSTRAINT [FK__tbl_kidde__opro___6C190EBB] FOREIGN KEY ([opro_id]) REFERENCES [tbl_otherpro] ([opro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_mstretail
-- ----------------------------
ALTER TABLE [dbo].[tbl_mstretail] ADD CONSTRAINT [FK__tbl_mstre__ks_id__160F4887] FOREIGN KEY ([ks_id]) REFERENCES [tbl_ks] ([ks_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mstretail] ADD CONSTRAINT [FK__tbl_mstre__pc_id__17036CC0] FOREIGN KEY ([pc_id]) REFERENCES [tbl_provinces] ([pc_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mstretail] ADD CONSTRAINT [FK__tbl_mstre__sk_id__17F790F9] FOREIGN KEY ([sk_id]) REFERENCES [tbl_sk] ([sk_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mstretail] ADD CONSTRAINT [FK__tbl_mstre__staff__18EBB532] FOREIGN KEY ([staff_id]) REFERENCES [tbl_mststaff] ([staff_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_mststaff
-- ----------------------------
ALTER TABLE [dbo].[tbl_mststaff] ADD CONSTRAINT [FK__tbl_mstst__pos_i__70DDC3D8] FOREIGN KEY ([pos_id]) REFERENCES [tbl_pos] ([pos_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_mum
-- ----------------------------
ALTER TABLE [dbo].[tbl_mum] ADD CONSTRAINT [FK__tbl_mum__kid_id__76969D2E] FOREIGN KEY ([kid_id]) REFERENCES [tbl_kid] ([kid_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mum] ADD CONSTRAINT [FK__tbl_mum__staff_i__778AC167] FOREIGN KEY ([staff_id]) REFERENCES [tbl_mststaff] ([staff_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mum] ADD CONSTRAINT [FK__tbl_mum__hcp_id__787EE5A0] FOREIGN KEY ([hcp_id]) REFERENCES [tbl_hcp] ([hcp_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_mum] ADD CONSTRAINT [FK__tbl_mum__pro_id__797309D9] FOREIGN KEY ([pro_id]) REFERENCES [tbl_product] ([pro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_otherpro
-- ----------------------------
ALTER TABLE [dbo].[tbl_otherpro] ADD CONSTRAINT [FK__tbl_other__cate___6FE99F9F] FOREIGN KEY ([cate_id]) REFERENCES [tbl_category] ([cate_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_product
-- ----------------------------
ALTER TABLE [dbo].[tbl_product] ADD CONSTRAINT [FK__tbl_produ__cate___6EF57B66] FOREIGN KEY ([cate_id]) REFERENCES [tbl_category] ([cate_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


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

 Date: 22/01/2018 10:01:11
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
-- Records of tbl_access_options
-- ----------------------------
INSERT INTO [dbo].[tbl_access_options]  VALUES (N'28', N'2')
GO

INSERT INTO [dbo].[tbl_access_options]  VALUES (N'28', N'3')
GO

INSERT INTO [dbo].[tbl_access_options]  VALUES (N'28', N'4')
GO

INSERT INTO [dbo].[tbl_access_options]  VALUES (N'28', N'5')
GO

INSERT INTO [dbo].[tbl_access_options]  VALUES (N'28', N'6')
GO

INSERT INTO [dbo].[tbl_access_options]  VALUES (N'28', N'7')
GO

INSERT INTO [dbo].[tbl_access_options]  VALUES (N'28', N'8')
GO

INSERT INTO [dbo].[tbl_access_options]  VALUES (N'28', N'10')
GO

INSERT INTO [dbo].[tbl_access_options]  VALUES (N'28', N'11')
GO

INSERT INTO [dbo].[tbl_access_options]  VALUES (N'28', N'12')
GO

INSERT INTO [dbo].[tbl_access_options]  VALUES (N'28', N'13')
GO

INSERT INTO [dbo].[tbl_access_options]  VALUES (N'29', N'2')
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
-- Records of tbl_address
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_address] ON
GO

INSERT INTO [dbo].[tbl_address] ([address_id], [sk_id], [st_road]) VALUES (N'1', N'2', N'St110, CPC')
GO

INSERT INTO [dbo].[tbl_address] ([address_id], [sk_id], [st_road]) VALUES (N'2', N'3', N'St110, SPL')
GO

SET IDENTITY_INSERT [dbo].[tbl_address] OFF
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
  [opro_id] int  NULL,
  [memo2] nvarchar(100) COLLATE Khmer_100_BIN2  NULL,
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
  [opro_id] int  NULL,
  [memo1] nvarchar(100) COLLATE Khmer_100_BIN2  NULL,
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
-- Records of tbl_category
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_category] ON
GO

INSERT INTO [dbo].[tbl_category] ([cate_id], [cate_name]) VALUES (N'1', N'Baby Care S')
GO

INSERT INTO [dbo].[tbl_category] ([cate_id], [cate_name]) VALUES (N'2', N'Baby Care M')
GO

INSERT INTO [dbo].[tbl_category] ([cate_id], [cate_name]) VALUES (N'3', N'Baby Care L')
GO

SET IDENTITY_INSERT [dbo].[tbl_category] OFF
GO


-- ----------------------------
-- Table structure for tbl_hcp
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_hcp]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_hcp]
GO

CREATE TABLE [dbo].[tbl_hcp] (
  [hcp_id] int  IDENTITY(1,1) NOT NULL,
  [hcp_name] nvarchar(50) COLLATE Khmer_100_BIN2  NULL,
  [hcp_owner] nvarchar(50) COLLATE Khmer_100_BIN2  NULL,
  [address_id] int  NULL,
  [hcp_tel1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [hcp_tel2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [hcp_email] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [hcp_fb] nvarchar(100) COLLATE Khmer_100_BIN2  NULL,
  [hcp_memo] nvarchar(100) COLLATE Khmer_100_BIN2  NULL
)
GO

ALTER TABLE [dbo].[tbl_hcp] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tbl_hcp
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_hcp] ON
GO

INSERT INTO [dbo].[tbl_hcp] ([hcp_id], [hcp_name], [hcp_owner], [address_id], [hcp_tel1], [hcp_tel2], [hcp_email], [hcp_fb], [hcp_memo]) VALUES (N'1', N'HP Fast II', N'VK Com', N'2', N'0769995149', N'012343434', N'sombochea100@gmail.com', N'sombodev', N'Halo, Public 2')
GO

INSERT INTO [dbo].[tbl_hcp] ([hcp_id], [hcp_name], [hcp_owner], [address_id], [hcp_tel1], [hcp_tel2], [hcp_email], [hcp_fb], [hcp_memo]) VALUES (N'2', N'asas', N'asas', N'2', N'asas', N'asa', N'as', N'asas', N'asa')
GO

INSERT INTO [dbo].[tbl_hcp] ([hcp_id], [hcp_name], [hcp_owner], [address_id], [hcp_tel1], [hcp_tel2], [hcp_email], [hcp_fb], [hcp_memo]) VALUES (N'3', N'ជា សំបូរ', N'asas', N'2', N'asasa', N'asas', N'asas', N'asas', N'asas')
GO

SET IDENTITY_INSERT [dbo].[tbl_hcp] OFF
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
-- Records of tbl_kid
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_kid] ON
GO

INSERT INTO [dbo].[tbl_kid] ([kid_id], [kid_name], [kid_dob], [kid_sex], [mom_id]) VALUES (N'1', N'My Baby', N'2018-01-21 12:51:54.0000000', N'Female', N'2')
GO

SET IDENTITY_INSERT [dbo].[tbl_kid] OFF
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
  [opro_id] int  NULL,
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
-- Records of tbl_ks
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_ks] ON
GO

INSERT INTO [dbo].[tbl_ks] ([ks_id], [ks_name], [pc_id]) VALUES (N'1', N'Boreycholsa', N'1')
GO

INSERT INTO [dbo].[tbl_ks] ([ks_id], [ks_name], [pc_id]) VALUES (N'2', N'Mean Chy', N'2')
GO

INSERT INTO [dbo].[tbl_ks] ([ks_id], [ks_name], [pc_id]) VALUES (N'3', N'Sen Sok', N'2')
GO

INSERT INTO [dbo].[tbl_ks] ([ks_id], [ks_name], [pc_id]) VALUES (N'4', N'Toul Kork', N'2')
GO

SET IDENTITY_INSERT [dbo].[tbl_ks] OFF
GO


-- ----------------------------
-- Table structure for tbl_mom
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_mom]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_mom]
GO

CREATE TABLE [dbo].[tbl_mom] (
  [mom_id] int  IDENTITY(1,1) NOT NULL,
  [mom_name] nvarchar(50) COLLATE Khmer_100_BIN2  NULL,
  [mom_rec_date] datetime2(7)  NULL,
  [mom_tel1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [mom_tel2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [mom_tel3] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [mom_call_date] datetime2(7)  NULL,
  [mom_frm_source] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [mom_ept_date] datetime2(7)  NULL,
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
  [name_en] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [name_kh] nvarchar(50) COLLATE Khmer_100_BIN2  NULL,
  [pos_id] int  NULL,
  [emp_date] datetime2(7)  NULL,
  [tel_per1] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [tel_per2] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [tel_com] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [email] varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [photo] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [emp_note] nvarchar(255) COLLATE Khmer_100_BIN2  NULL,
  [other] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tbl_mststaff] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tbl_mststaff
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_mststaff] ON
GO

INSERT INTO [dbo].[tbl_mststaff] ([staff_id], [name_en], [name_kh], [pos_id], [emp_date], [tel_per1], [tel_per2], [tel_com], [email], [photo], [emp_note], [other]) VALUES (N'1', N'Sombo Chea', N'ជា សំបូរ', NULL, N'2018-01-11 15:24:18.0000000', N'0769995149', NULL, NULL, N'sombochea100@gmail.com', NULL, NULL, NULL)
GO

INSERT INTO [dbo].[tbl_mststaff] ([staff_id], [name_en], [name_kh], [pos_id], [emp_date], [tel_per1], [tel_per2], [tel_com], [email], [photo], [emp_note], [other]) VALUES (N'2', N'Sambo Chea', N'?? ?????', N'28', N'2018-01-22 09:16:13.0000000', N'769995149', N'', N'', N'sombochea100@gmail.com', N'api-services.png', N'Thus', N'Assistanse')
GO

SET IDENTITY_INSERT [dbo].[tbl_mststaff] OFF
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
-- Records of tbl_options
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_options] ON
GO

INSERT INTO [dbo].[tbl_options] ([option_id], [option_name], [tag]) VALUES (N'2', N'Hospital', N'hcp')
GO

INSERT INTO [dbo].[tbl_options] ([option_id], [option_name], [tag]) VALUES (N'3', N'Retail', N'retail')
GO

INSERT INTO [dbo].[tbl_options] ([option_id], [option_name], [tag]) VALUES (N'4', N'Mom', N'mom')
GO

INSERT INTO [dbo].[tbl_options] ([option_id], [option_name], [tag]) VALUES (N'5', N'Kid', N'kid')
GO

INSERT INTO [dbo].[tbl_options] ([option_id], [option_name], [tag]) VALUES (N'6', N'Staff', N'staff')
GO

INSERT INTO [dbo].[tbl_options] ([option_id], [option_name], [tag]) VALUES (N'7', N'Address', N'address')
GO

INSERT INTO [dbo].[tbl_options] ([option_id], [option_name], [tag]) VALUES (N'8', N'Product', N'product')
GO

INSERT INTO [dbo].[tbl_options] ([option_id], [option_name], [tag]) VALUES (N'10', N'Position', N'position')
GO

INSERT INTO [dbo].[tbl_options] ([option_id], [option_name], [tag]) VALUES (N'11', N'User', N'user')
GO

INSERT INTO [dbo].[tbl_options] ([option_id], [option_name], [tag]) VALUES (N'12', N'Call List', N'call_list')
GO

INSERT INTO [dbo].[tbl_options] ([option_id], [option_name], [tag]) VALUES (N'13', N'Help', N'help')
GO

SET IDENTITY_INSERT [dbo].[tbl_options] OFF
GO


-- ----------------------------
-- Table structure for tbl_otherpro
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_otherpro]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_otherpro]
GO

CREATE TABLE [dbo].[tbl_otherpro] (
  [opro_id] int  IDENTITY(1,1) NOT NULL,
  [opro_name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [description] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [cate_id] int  NULL
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
  [pos_id] int  IDENTITY(1,1) NOT NULL,
  [pos_en] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [pos_kh] nvarchar(50) COLLATE Khmer_100_BIN2  NULL
)
GO

ALTER TABLE [dbo].[tbl_pos] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tbl_pos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_pos] ON
GO

INSERT INTO [dbo].[tbl_pos] ([pos_id], [pos_en], [pos_kh]) VALUES (N'28', N'Admin', NULL)
GO

INSERT INTO [dbo].[tbl_pos] ([pos_id], [pos_en], [pos_kh]) VALUES (N'29', N'User', NULL)
GO

INSERT INTO [dbo].[tbl_pos] ([pos_id], [pos_en], [pos_kh]) VALUES (N'31', N'NewUser', NULL)
GO

SET IDENTITY_INSERT [dbo].[tbl_pos] OFF
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
  [cate_id] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_product] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tbl_product
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_product] ON
GO

INSERT INTO [dbo].[tbl_product] ([pro_id], [pro_name], [description], [cate_id]) VALUES (N'1', N'Leben 2', N'This is a leben 2', N'2')
GO

INSERT INTO [dbo].[tbl_product] ([pro_id], [pro_name], [description], [cate_id]) VALUES (N'2', N'???????', N'???????????????', N'2')
GO

INSERT INTO [dbo].[tbl_product] ([pro_id], [pro_name], [description], [cate_id]) VALUES (N'3', N'??????', N'???????????????', N'3')
GO

SET IDENTITY_INSERT [dbo].[tbl_product] OFF
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
-- Records of tbl_provinces
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_provinces] ON
GO

INSERT INTO [dbo].[tbl_provinces] ([pc_id], [pc_name]) VALUES (N'1', N'Takeo')
GO

INSERT INTO [dbo].[tbl_provinces] ([pc_id], [pc_name]) VALUES (N'2', N'Phnom Penh')
GO

SET IDENTITY_INSERT [dbo].[tbl_provinces] OFF
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
-- Records of tbl_sk
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_sk] ON
GO

INSERT INTO [dbo].[tbl_sk] ([sk_id], [sk_name], [ks_id]) VALUES (N'1', N'Kouk Pou', N'1')
GO

INSERT INTO [dbo].[tbl_sk] ([sk_id], [sk_name], [ks_id]) VALUES (N'2', N'Teuk Thla', N'3')
GO

INSERT INTO [dbo].[tbl_sk] ([sk_id], [sk_name], [ks_id]) VALUES (N'3', N'Teuk Lork II', N'4')
GO

SET IDENTITY_INSERT [dbo].[tbl_sk] OFF
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
-- Records of tbl_users
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tbl_users] ON
GO

INSERT INTO [dbo].[tbl_users] ([user_id], [username], [password], [staff_id]) VALUES (N'1', N'sombochea', N'ms', N'1')
GO

SET IDENTITY_INSERT [dbo].[tbl_users] OFF
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
dbo.tbl_mststaff.other AS Other,
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
-- Primary Key structure for table tbl_mom
-- ----------------------------
ALTER TABLE [dbo].[tbl_mom] ADD CONSTRAINT [PK__tbl_mum__C80717EB1510317A] PRIMARY KEY CLUSTERED ([mom_id])
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
-- Primary Key structure for table tbl_options
-- ----------------------------
ALTER TABLE [dbo].[tbl_options] ADD CONSTRAINT [PK__tbl_opti__F4EACE1B304A1DFD] PRIMARY KEY CLUSTERED ([option_id])
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

ALTER TABLE [dbo].[tbl_afdelivery] ADD CONSTRAINT [FK__tbl_afdel__opro___75A278F5] FOREIGN KEY ([opro_id]) REFERENCES [dbo].[tbl_otherpro] ([opro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_bfdelivery
-- ----------------------------
ALTER TABLE [dbo].[tbl_bfdelivery] ADD CONSTRAINT [FK__tbl_bfdel__pro_i__72C60C4A] FOREIGN KEY ([pro_id]) REFERENCES [dbo].[tbl_product] ([pro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_bfdelivery] ADD CONSTRAINT [FK__tbl_bfdel__opro___73BA3083] FOREIGN KEY ([opro_id]) REFERENCES [dbo].[tbl_otherpro] ([opro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_hcp
-- ----------------------------
ALTER TABLE [dbo].[tbl_hcp] ADD CONSTRAINT [FK__tbl_hcp__address__44CA3770] FOREIGN KEY ([address_id]) REFERENCES [dbo].[tbl_address] ([address_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_kiddetails
-- ----------------------------
ALTER TABLE [dbo].[tbl_kiddetails] ADD CONSTRAINT [FK__tbl_kidde__kid_i__6A30C649] FOREIGN KEY ([kid_id]) REFERENCES [dbo].[tbl_kid] ([kid_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_kiddetails] ADD CONSTRAINT [FK__tbl_kidde__pro_i__6B24EA82] FOREIGN KEY ([pro_id]) REFERENCES [dbo].[tbl_product] ([pro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[tbl_kiddetails] ADD CONSTRAINT [FK__tbl_kidde__opro___6C190EBB] FOREIGN KEY ([opro_id]) REFERENCES [dbo].[tbl_otherpro] ([opro_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table tbl_ks
-- ----------------------------
ALTER TABLE [dbo].[tbl_ks] ADD CONSTRAINT [FK__tbl_ks__pc_id__3E1D39E1] FOREIGN KEY ([pc_id]) REFERENCES [dbo].[tbl_provinces] ([pc_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
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
-- Foreign Keys structure for table tbl_otherpro
-- ----------------------------
ALTER TABLE [dbo].[tbl_otherpro] ADD CONSTRAINT [FK__tbl_other__cate___6FE99F9F] FOREIGN KEY ([cate_id]) REFERENCES [dbo].[tbl_category] ([cate_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
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


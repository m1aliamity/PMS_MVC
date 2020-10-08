USE [PMS_Core]
GO
/****** Object:  Table [dbo].[tbl_TestMaster]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_TestMaster](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TestReferenceNo] [varchar](50) NULL,
	[DepartmentId] [bigint] NOT NULL,
	[TestHeadId] [bigint] NOT NULL,
	[TestName] [varchar](50) NOT NULL,
	[TestRate] [decimal](18, 2) NULL,
	[TestDefaultValue] [varchar](50) NULL,
	[RangeFrom] [varchar](50) NULL,
	[RangeTo] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[Fourmula] [varchar](50) NULL,
	[Method] [varchar](50) NULL,
	[Interpretations] [varchar](max) NULL,
	[Precautions] [varchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[LastModifiedBy] [bigint] NULL,
	[CID] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
 CONSTRAINT [PK_tbl_TestMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_TestBookingDetails]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TestBookingDetails](
	[Id] [bigint] NOT NULL,
	[BookingId] [bigint] NOT NULL,
	[TestId] [bigint] NOT NULL,
	[ProfileId] [bigint] NULL,
	[Rate] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[PrintOrder] [int] NULL,
	[CID] [bigint] NOT NULL,
	[UserId] [bigint] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_TestBooking]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_TestBooking](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[PatientId] [bigint] NOT NULL,
	[DoctorId] [bigint] NOT NULL,
	[BookingReferenceNo] [varchar](50) NOT NULL,
	[SampleBy] [bigint] NULL,
	[SampleType] [varchar](50) NULL,
	[BookingDate] [datetime] NULL,
	[ReportDate] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ReportHandover] [bit] NULL,
	[ReportMail] [bit] NULL,
	[CID] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
 CONSTRAINT [PK_tbl_TestBooking] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ProfileDetails]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ProfileDetails](
	[Id] [bigint] NOT NULL,
	[ProfileId] [bigint] NULL,
	[TestId] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CID] [bigint] NULL,
	[UserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ProcessUrl]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ProcessUrl](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProcessCode] [varchar](20) NULL,
	[ProcessUrl] [varchar](max) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tbl_ProcessUrl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ProcessPermission]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ProcessPermission](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeId] [bigint] NULL,
	[ProcessCode] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Payment]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Payment](
	[Id] [bigint] NOT NULL,
	[BookingId] [bigint] NOT NULL,
	[DepartmentId] [bigint] NULL,
	[GSTAmount] [decimal](18, 2) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[PaidAmount] [decimal](18, 2) NULL,
	[BalanceAmount] [decimal](18, 2) NULL,
	[RefundAmount] [decimal](18, 2) NULL,
	[DepositDate] [datetime] NULL,
	[PaymentType] [int] NULL,
	[BankName] [varchar](255) NULL,
	[ChequeNo] [varchar](50) NULL,
	[ChequeDate] [datetime] NULL,
	[CardTransactionNo] [varchar](50) NULL,
	[ConfirmAmount] [varchar](255) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CID] [bigint] NULL,
	[UserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Patient]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Patient](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ReferenceNo] [varchar](50) NOT NULL,
	[Title] [int] NOT NULL,
	[PatientName] [varchar](50) NOT NULL,
	[Age] [datetime] NOT NULL,
	[Gandar] [nchar](10) NOT NULL,
	[MobileNo] [int] NULL,
	[Email] [varchar](50) NULL,
	[Address] [varchar](250) NULL,
	[MaritalStatus] [bigint] NULL,
	[Relation] [bigint] NULL,
	[RelationName] [varchar](50) NULL,
	[Relision] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CID] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
 CONSTRAINT [PK_tbl_Patient] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_MasterDetails]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_MasterDetails](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Master_Id] [bigint] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Rate] [decimal](18, 2) NULL,
	[PrintName] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CID] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
 CONSTRAINT [PK_tbl_MasterDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_MasterDetails] ON
INSERT [dbo].[tbl_MasterDetails] ([Id], [Master_Id], [Name], [Rate], [PrintName], [IsActive], [CreatedDate], [CreatedBy], [LastModifiedDate], [ModifiedBy], [CID], [UserId]) VALUES (1, 1, N'Male', CAST(0.00 AS Decimal(18, 2)), N'Male', 0, CAST(0x0000AC470012492D AS DateTime), 0, NULL, NULL, 1, 0)
INSERT [dbo].[tbl_MasterDetails] ([Id], [Master_Id], [Name], [Rate], [PrintName], [IsActive], [CreatedDate], [CreatedBy], [LastModifiedDate], [ModifiedBy], [CID], [UserId]) VALUES (2, 1, N'Female', CAST(0.00 AS Decimal(18, 2)), N'F', 0, CAST(0x0000AC470014A42B AS DateTime), 0, NULL, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[tbl_MasterDetails] OFF
/****** Object:  Table [dbo].[tbl_Master]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Master](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[MasterName] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Master] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Master] ON
INSERT [dbo].[tbl_Master] ([Id], [MasterName], [IsActive], [CreatedDate], [CreatedBy]) VALUES (1, N'Gender    ', 1, CAST(0x0000AC42007318D9 AS DateTime), N'Developer')
INSERT [dbo].[tbl_Master] ([Id], [MasterName], [IsActive], [CreatedDate], [CreatedBy]) VALUES (2, N'Relation  ', 1, CAST(0x0000AC420073B8F3 AS DateTime), N'Developer')
INSERT [dbo].[tbl_Master] ([Id], [MasterName], [IsActive], [CreatedDate], [CreatedBy]) VALUES (3, N'Religion  ', 1, CAST(0x0000AC420073C86A AS DateTime), N'Developer')
INSERT [dbo].[tbl_Master] ([Id], [MasterName], [IsActive], [CreatedDate], [CreatedBy]) VALUES (4, N'Name Prefix', 1, CAST(0x0000AC42007421A3 AS DateTime), N'Developer')
INSERT [dbo].[tbl_Master] ([Id], [MasterName], [IsActive], [CreatedDate], [CreatedBy]) VALUES (5, N'Specialization', 1, CAST(0x0000AC4200747468 AS DateTime), N'Developer')
INSERT [dbo].[tbl_Master] ([Id], [MasterName], [IsActive], [CreatedDate], [CreatedBy]) VALUES (6, N'Employee Type', 1, CAST(0x0000AC4200749628 AS DateTime), N'Developer')
INSERT [dbo].[tbl_Master] ([Id], [MasterName], [IsActive], [CreatedDate], [CreatedBy]) VALUES (7, N'Test Profile', 1, CAST(0x0000AC420074DA69 AS DateTime), N'Developer')
INSERT [dbo].[tbl_Master] ([Id], [MasterName], [IsActive], [CreatedDate], [CreatedBy]) VALUES (8, N'Pathology Department', 1, CAST(0x0000AC420074F834 AS DateTime), N'Developer')
INSERT [dbo].[tbl_Master] ([Id], [MasterName], [IsActive], [CreatedDate], [CreatedBy]) VALUES (9, N'Test Head', 1, CAST(0x0000AC420075285B AS DateTime), N'Developer')
INSERT [dbo].[tbl_Master] ([Id], [MasterName], [IsActive], [CreatedDate], [CreatedBy]) VALUES (10, N'Expense Type', 1, CAST(0x0000AC42007571A8 AS DateTime), N'Developer')
SET IDENTITY_INSERT [dbo].[tbl_Master] OFF
/****** Object:  Table [dbo].[tbl_LabStaff]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_LabStaff](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[StaffReferenceId] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NULL,
	[MobileNo] [int] NOT NULL,
	[EmailId] [varchar](50) NULL,
	[Gandar] [int] NULL,
	[MritalStatus] [int] NULL,
	[SpauseName] [varchar](100) NULL,
	[DateOfBirth] [datetime] NULL,
	[AnniversaryDate] [datetime] NULL,
	[StaffType] [bigint] NULL,
	[Address] [varchar](500) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CID] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Expense]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Expense](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ExpenseReferenceNo] [varchar](50) NOT NULL,
	[ExpenseType] [bigint] NOT NULL,
	[PaidTo] [varchar](100) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Date] [datetime] NULL,
	[PaymentType] [int] NULL,
	[BankName] [varchar](50) NULL,
	[ChequeNo] [varchar](50) NULL,
	[CardTransactionNo] [varchar](50) NULL,
	[ConfirmAmount] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CID] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
 CONSTRAINT [PK_tbl_Expense] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Doctors]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Doctors](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DoctorReferenceNo] [varchar](50) NOT NULL,
	[Title] [int] NOT NULL,
	[DoctorName] [nchar](10) NOT NULL,
	[MobileNo] [int] NULL,
	[Gender] [int] NOT NULL,
	[EmailId] [varchar](20) NULL,
	[Address] [varchar](200) NULL,
	[Specialization] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CID] [bigint] NULL,
	[UserId] [bigint] NULL,
 CONSTRAINT [PK_tbl_Doctors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_DoctorCommission]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DoctorCommission](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DoctorId] [bigint] NULL,
	[DepartmentId] [bigint] NULL,
	[CommissionInRupees] [decimal](18, 2) NULL,
	[CommissionInPercentage] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CID] [bigint] NULL,
	[UserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_DoctorCommisonDetails]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_DoctorCommisonDetails](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DoctorId] [bigint] NULL,
	[DepartmentId] [bigint] NULL,
	[BookingId] [bigint] NULL,
	[CommissionAmount] [decimal](18, 2) NULL,
	[PaidAmount] [decimal](18, 2) NULL,
	[CommissonCreatedDate] [datetime] NULL,
	[CommissionPaidDate] [datetime] NULL,
	[PaidStatus] [varchar](255) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CID] [bigint] NULL,
	[UserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Company]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Company](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](100) NOT NULL,
	[StreetAddress] [varchar](500) NULL,
	[SloganName] [varchar](100) NOT NULL,
	[PhoneNo] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[WebSite] [varchar](50) NULL,
	[ShowDetail] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Logo] [varchar](500) NULL,
 CONSTRAINT [PK_tbl_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Company] ON
INSERT [dbo].[tbl_Company] ([Id], [CompanyName], [StreetAddress], [SloganName], [PhoneNo], [Email], [WebSite], [ShowDetail], [IsActive], [CreatedDate], [CreatedBy], [LastModifiedDate], [ModifiedBy], [Logo]) VALUES (1, N'Demo', N'Moradabad', N'Demo company', N'm1aliamity@gmail.com', N'www.email.com', N'www.mail.com', 1, 1, CAST(0x0000AC3E016ED6AA AS DateTime), N'Developer', CAST(0x0000AC3F007A0CFD AS DateTime), N'Developer', NULL)
INSERT [dbo].[tbl_Company] ([Id], [CompanyName], [StreetAddress], [SloganName], [PhoneNo], [Email], [WebSite], [ShowDetail], [IsActive], [CreatedDate], [CreatedBy], [LastModifiedDate], [ModifiedBy], [Logo]) VALUES (9, N'Demo', N'ewfgrgtrewtgwdcvsdf', N'Demo company', N'9015505890', N'www.email.com', N'www.email.com', 1, 1, CAST(0x0000AC4101763001 AS DateTime), N'Developer', CAST(0x0000AC4101764C39 AS DateTime), N'Developer', NULL)
SET IDENTITY_INSERT [dbo].[tbl_Company] OFF
/****** Object:  Table [dbo].[tbl_UserLogin]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_UserLogin](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[StafId] [bigint] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[UserType] [bigint] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[LastModifiedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[CID] [bigint] NOT NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_UserLogin] ON
INSERT [dbo].[tbl_UserLogin] ([Id], [StafId], [UserName], [Password], [UserType], [CreatedDate], [CreatedBy], [LastModifiedDate], [ModifiedBy], [CID], [IsActive]) VALUES (1, 0, N'admin', N'admin', 0, NULL, NULL, NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[tbl_UserLogin] OFF
/****** Object:  Table [dbo].[tbl_TestResult]    Script Date: 10/08/2020 08:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_TestResult](
	[Id] [bigint] NOT NULL,
	[BookingId] [bigint] NULL,
	[TestId] [bigint] NULL,
	[TestName] [varchar](50) NULL,
	[Result] [varchar](50) NULL,
	[RangeFrom] [varchar](50) NULL,
	[RangeTo] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[Note] [varchar](max) NULL,
	[InterPretation] [varchar](max) NULL,
	[Precaution] [varchar](max) NULL,
	[PrintOrder] [int] NULL,
	[CID] [bigint] NULL,
	[UserId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_MasterDetails]    Script Date: 10/08/2020 08:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MasterDetails]
(
@Id bigint=0,
@MID bigint=0,
@Name Varchar(50)='',
@Rate decimal(18,2)=0.00,
@PrintName Varchar(50)='',
@IsActive bit =false,
@CID bigint=0,
@UserId bigint=0,
@Action Varchar(3)
)
AS BEGIN
IF(@Action='I')
BEGIN
INSERT INTO tbl_MasterDetails(Master_Id,Name,Rate,PrintName,IsActive,CreatedDate,CreatedBy,CID,UserId)
Values(@MID,@Name,@Rate,@PrintName,@IsActive,GETDATE(),@UserId,@CID,@UserId)
END
IF(@Action='U')
BEGIN
update tbl_MasterDetails SET Name=@Name,Rate=@Rate,PrintName=@PrintName,IsActive=@IsActive,LastModifiedDate=GETDATE(),ModifiedBy=@UserId,CID=@CID WHERE Id=@Id
END
IF(@Action='D')
BEGIN
Delete from tbl_MasterDetails WHERE Id=@Id
END
Select * from tbl_MasterDetails where Master_Id=@MID AND CID=@CID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetUser]    Script Date: 10/08/2020 08:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_GetUser]  
(  
@UserName varchar(50)='',  
@Password Varchar(50)='',  
@Action Varchar(3)  
)  
AS  
BEGIN  
IF(@Action='I')  
BEGIN  
Select * from tbl_UserLogin where UserName=@UserName AND Password=@Password AND IsActive=1  
END  
ELSE IF(@Action=2)  
BEGIN  
Select * from tbl_UserLogin  
END  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetMaster]    Script Date: 10/08/2020 08:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetMaster]
AS BEGIN
Select Id,MasterName From tbl_Master where IsActive=1
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Company]    Script Date: 10/08/2020 08:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Company] (
	@Id BIGINT =0
	,@CompanyName VARCHAR(50)=''
	,@StreetAddress VARCHAR(500)=''
	,@SloganName VARCHAR(50)=''
	,@PhoneNo VARCHAR(50)=''
	,@Email VARCHAR(50)=''
	,@WebSite VARCHAR(50)=''
	,@ShowDetail BIT=true
	,@IsActive BIT=true
	,@Logo VARCHAR(500)=''
	,@Action VARCHAR(3)=''
	)
AS
BEGIN
	IF (@Action = 'I')
	BEGIN
		INSERT INTO tbl_Company (
			CompanyName
			,StreetAddress
			,SloganName
			,PhoneNo
			,Email
			,WebSite
			,ShowDetail
			,IsActive
			,CreatedDate
			,CreatedBy
			,Logo
			)
		VALUES (
			@CompanyName
			,@StreetAddress
			,@SloganName
			,@PhoneNo
			,@Email
			,@WebSite
			,@ShowDetail
			,@IsActive
			,GETDATE()
			,'Developer'
			,@Logo
			)
	END
	ELSE IF (@Action = 'U')
	BEGIN
		UPDATE tbl_Company
		SET CompanyName = @CompanyName
			,StreetAddress = @StreetAddress
			,SloganName = @SloganName
			,PhoneNo = @PhoneNo
			,Email = @Email
			,WebSite = @WebSite
			,ShowDetail = @ShowDetail
			,IsActive = @IsActive
			,LastModifiedDate=GETDATE()
			,ModifiedBy='Developer'
			,Logo = @Logo
		WHERE Id = @Id
	END
	ELSE IF (@Action = 'G')
	BEGIN
		SELECT *
		FROM tbl_Company
		WHERE Id = @Id
	END
	ELSE IF (@Action = 'S')
	BEGIN
		SELECT *
		FROM tbl_Company
	END
	ELSE IF (@Action = 'D')
	BEGIN
		DELETE
		FROM tbl_Company
		WHERE Id = @Id
	END
END
GO
/****** Object:  ForeignKey [FK_BookingId_Result]    Script Date: 10/08/2020 08:02:14 ******/
ALTER TABLE [dbo].[tbl_TestResult]  WITH CHECK ADD  CONSTRAINT [FK_BookingId_Result] FOREIGN KEY([BookingId])
REFERENCES [dbo].[tbl_TestBooking] ([Id])
GO
ALTER TABLE [dbo].[tbl_TestResult] CHECK CONSTRAINT [FK_BookingId_Result]
GO

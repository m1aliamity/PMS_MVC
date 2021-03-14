USE [IBCM]
GO

/****** Object:  Table [dbo].[tbl_LabStaff]    Script Date: 23-10-2020 15:24:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_LabStaff](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Title] [bigint] NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NULL,
	[MobileNo] [varchar](15) NOT NULL,
	[EmailId] [varchar](50) NULL,
	[Gander] [bigint] NULL,
	[Religion] [bigint] NULL,
	[MritalStatus] [bigint] NULL,
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
 CONSTRAINT [PK__tbl_LabS__3214EC07300424B4] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



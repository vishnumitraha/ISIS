USE [EventStore] 
GO

TRUNCATE TABLE Events
TRUNCATE TABLE EventSources
TRUNCATE TABLE PipelineState
TRUNCATE TABLE Snapshots
GO

USE [ReadModel]
GO
/****** Object:  Table [dbo].[CourseDetails]    Script Date: 03/09/2011 13:23:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourseDetails]') AND type in (N'U'))
DROP TABLE [dbo].[CourseDetails]
GO
/****** Object:  Table [dbo].[CourseList]    Script Date: 03/09/2011 13:23:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourseList]') AND type in (N'U'))
DROP TABLE [dbo].[CourseList]
GO
/****** Object:  Table [dbo].[CourseSet]    Script Date: 03/09/2011 13:23:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourseSet]') AND type in (N'U'))
DROP TABLE [dbo].[CourseSet]
GO
/****** Object:  Table [dbo].[CourseTypesList]    Script Date: 03/09/2011 13:23:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourseTypesList]') AND type in (N'U'))
DROP TABLE [dbo].[CourseTypesList]
GO
/****** Object:  Table [dbo].[CourseTypesList]    Script Date: 03/09/2011 13:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourseTypesList]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CourseTypesList](
	[Id] [uniqueidentifier] NOT NULL,
	[CourseId] [uniqueidentifier] NULL,
	[CourseType] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CourseSet]    Script Date: 03/09/2011 13:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourseSet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CourseSet](
	[CourseId] [uniqueidentifier] NOT NULL,
	[Rubric] [nvarchar](255) NULL,
	[Number] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CourseList]    Script Date: 03/09/2011 13:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourseList]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CourseList](
	[CourseId] [uniqueidentifier] NOT NULL,
	[Rubric] [nvarchar](255) NULL,
	[Number] [nvarchar](255) NULL,
	[Title] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CourseDetails]    Script Date: 03/09/2011 13:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourseDetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CourseDetails](
	[CourseId] [uniqueidentifier] NOT NULL,
	[Rubric] [nvarchar](255) NULL,
	[Number] [nvarchar](255) NULL,
	[Title] [nvarchar](255) NULL,
	[LongTitle] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CIP] [nvarchar](255) NULL,
	[ApprovalNumber] [nvarchar](255) NULL,
	[Status] [int] NULL,
	[CourseTypes] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

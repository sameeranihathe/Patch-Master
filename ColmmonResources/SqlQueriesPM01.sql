USE [master]
GO
/****** Object:  Database [PatchMaster]    Script Date: 6/5/2021 12:34:51 PM ******/
CREATE DATABASE [PatchMaster]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PatchMaster', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PatchMaster.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PatchMaster_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PatchMaster_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PatchMaster] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PatchMaster].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PatchMaster] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PatchMaster] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PatchMaster] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PatchMaster] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PatchMaster] SET ARITHABORT OFF 
GO
ALTER DATABASE [PatchMaster] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PatchMaster] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PatchMaster] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PatchMaster] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PatchMaster] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PatchMaster] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PatchMaster] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PatchMaster] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PatchMaster] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PatchMaster] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PatchMaster] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PatchMaster] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PatchMaster] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PatchMaster] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PatchMaster] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PatchMaster] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PatchMaster] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PatchMaster] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PatchMaster] SET  MULTI_USER 
GO
ALTER DATABASE [PatchMaster] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PatchMaster] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PatchMaster] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PatchMaster] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PatchMaster] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PatchMaster] SET QUERY_STORE = OFF
GO
USE [PatchMaster]
GO
/****** Object:  Table [dbo].[PM_AuditQueryTable]    Script Date: 6/5/2021 12:34:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PM_AuditQueryTable](
	[AuditQueryid] [int] NOT NULL,
	[TableName] [nvarchar](max) NULL,
	[TableRow_key] [nvarchar](max) NULL,
	[ColumnName] [nvarchar](max) NULL,
	[PreviousValue] [nvarchar](max) NULL,
	[NewValue] [nvarchar](max) NULL,
	[SubQueryId] [int] NULL,
	[CrreatedDate] [datetime2](7) NULL,
	[CreatedBy] [datetime2](7) NULL,
	[QueryType] [int] NULL,
 CONSTRAINT [PK_PM_AuditQueryTable] PRIMARY KEY CLUSTERED 
(
	[AuditQueryid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PM_BuiltQueries]    Script Date: 6/5/2021 12:34:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PM_BuiltQueries](
	[QueryId] [int] NOT NULL,
	[QueryCatogary] [varchar](50) NOT NULL,
	[QueryString] [nvarchar](max) NULL,
	[SubQueryId] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_PM_BuiltQueries] PRIMARY KEY CLUSTERED 
(
	[QueryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PM_Databases]    Script Date: 6/5/2021 12:34:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PM_Databases](
	[DB_Id] [int] NOT NULL,
	[DBName] [nvarchar](max) NOT NULL,
	[ServerName] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
	[Is_Intregatedsecurity] [bit] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_PM_Databases] PRIMARY KEY CLUSTERED 
(
	[DB_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PM_QueryRequairement]    Script Date: 6/5/2021 12:34:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PM_QueryRequairement](
	[Requairement_Id] [int] NOT NULL,
	[RequairementName] [nvarchar](max) NULL,
	[SubQueryId] [int] NULL,
	[Database_Id] [int] NULL,
	[IsApproved] [bit] NULL,
	[CreatedBy] [int] NULL,
	[ApprovedBy] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[ApprovedDate] [datetime2](7) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_PM_QueryRequairement] PRIMARY KEY CLUSTERED 
(
	[Requairement_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PM_SubQuery]    Script Date: 6/5/2021 12:34:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PM_SubQuery](
	[SubQueryId] [int] NOT NULL,
	[SubQueryName] [nvarchar](max) NULL,
	[Createdby] [int] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_PM_SubQuery] PRIMARY KEY CLUSTERED 
(
	[SubQueryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PM_User_role]    Script Date: 6/5/2021 12:34:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PM_User_role](
	[RoleId] [int] NOT NULL,
	[RoleName] [nvarchar](100) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_PM_User_role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PM_Users]    Script Date: 6/5/2021 12:34:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PM_Users](
	[User_Id] [int] NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[First_Name] [nvarchar](100) NULL,
	[Last_Name] [nvarchar](100) NOT NULL,
	[RoleId] [int] NULL,
	[Createddate] [datetime2](7) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_PM_Users] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[PM_AuditQueryTable]  WITH CHECK ADD  CONSTRAINT [FK_PM_AuditQueryTable_PM_SubQuery] FOREIGN KEY([SubQueryId])
REFERENCES [dbo].[PM_SubQuery] ([SubQueryId])
GO
ALTER TABLE [dbo].[PM_AuditQueryTable] CHECK CONSTRAINT [FK_PM_AuditQueryTable_PM_SubQuery]
GO
ALTER TABLE [dbo].[PM_BuiltQueries]  WITH CHECK ADD  CONSTRAINT [FK_PM_BuiltQueries_PM_SubQuery] FOREIGN KEY([SubQueryId])
REFERENCES [dbo].[PM_SubQuery] ([SubQueryId])
GO
ALTER TABLE [dbo].[PM_BuiltQueries] CHECK CONSTRAINT [FK_PM_BuiltQueries_PM_SubQuery]
GO
ALTER TABLE [dbo].[PM_QueryRequairement]  WITH CHECK ADD  CONSTRAINT [FK_PM_QueryRequairement_PM_Databases] FOREIGN KEY([Database_Id])
REFERENCES [dbo].[PM_Databases] ([DB_Id])
GO
ALTER TABLE [dbo].[PM_QueryRequairement] CHECK CONSTRAINT [FK_PM_QueryRequairement_PM_Databases]
GO
ALTER TABLE [dbo].[PM_QueryRequairement]  WITH CHECK ADD  CONSTRAINT [FK_PM_QueryRequairement_PM_SubQuery] FOREIGN KEY([SubQueryId])
REFERENCES [dbo].[PM_SubQuery] ([SubQueryId])
GO
ALTER TABLE [dbo].[PM_QueryRequairement] CHECK CONSTRAINT [FK_PM_QueryRequairement_PM_SubQuery]
GO
ALTER TABLE [dbo].[PM_Users]  WITH CHECK ADD  CONSTRAINT [FK_PM_Users_PM_User_role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[PM_User_role] ([RoleId])
GO
ALTER TABLE [dbo].[PM_Users] CHECK CONSTRAINT [FK_PM_Users_PM_User_role]
GO
USE [master]
GO
ALTER DATABASE [PatchMaster] SET  READ_WRITE 
GO

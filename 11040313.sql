USE [master]
GO
/****** Object:  Database [mymomo]    Script Date: 2022/11/4 上午 03:13:40 ******/
CREATE DATABASE [mymomo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mymomo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\mymomo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mymomo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\mymomo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [mymomo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mymomo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mymomo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mymomo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mymomo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mymomo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mymomo] SET ARITHABORT OFF 
GO
ALTER DATABASE [mymomo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mymomo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mymomo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mymomo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mymomo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mymomo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mymomo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mymomo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mymomo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mymomo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [mymomo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mymomo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mymomo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mymomo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mymomo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mymomo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mymomo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mymomo] SET RECOVERY FULL 
GO
ALTER DATABASE [mymomo] SET  MULTI_USER 
GO
ALTER DATABASE [mymomo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mymomo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mymomo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mymomo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [mymomo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [mymomo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'mymomo', N'ON'
GO
ALTER DATABASE [mymomo] SET QUERY_STORE = OFF
GO
USE [mymomo]
GO
/****** Object:  Table [dbo].[dessert]    Script Date: 2022/11/4 上午 03:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dessert](
	[dessert_ID] [int] IDENTITY(101,1) NOT NULL,
	[dessert_category] [varchar](30) NULL,
	[dessert_name] [nvarchar](80) NULL,
	[dessert_price] [int] NULL,
	[dessert_description] [nvarchar](250) NULL,
	[dessert_image] [varchar](100) NULL,
	[dessert_available] [bit] NULL,
 CONSTRAINT [PK_dessert_ID] PRIMARY KEY CLUSTERED 
(
	[dessert_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dessertOrder]    Script Date: 2022/11/4 上午 03:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dessertOrder](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[dessertOrder_ID] [varchar](20) NULL,
	[member_ID] [int] NULL,
	[dessert_ID] [int] NULL,
	[dessert_amount] [int] NULL,
	[dessert_dis_price] [int] NULL,
	[dessertOrder_time] [datetime2](7) NULL,
	[dessertOrder_state] [int] NULL,
 CONSTRAINT [PK_DO_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[memberOrder]    Script Date: 2022/11/4 上午 03:13:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[memberOrder](
	[memberOrder_ID] [varchar](20) NOT NULL,
	[member_ID] [int] NULL,
	[memberOrder_delivery] [varchar](20) NULL,
	[memberOrder_address] [nvarchar](300) NULL,
	[memberOrder_payment] [varchar](20) NULL,
	[memberOrder_package] [varchar](20) NULL,
	[memberOrder_time] [datetime2](7) NULL,
	[memberOrder_totalPrice] [int] NULL,
	[memberOrder_available] [bit] NULL,
	[memberOrder_state] [int] NULL,
	[mid] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_memberOrder_ID] PRIMARY KEY CLUSTERED 
(
	[memberOrder_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[momo_clerk_account]    Script Date: 2022/11/4 上午 03:13:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[momo_clerk_account](
	[clerk_ID] [int] IDENTITY(2001,1) NOT NULL,
	[clerk_account] [varchar](20) NOT NULL,
	[clerk_password] [varchar](20) NULL,
	[clerk_available] [bit] NULL,
 CONSTRAINT [PK_clerk_account] PRIMARY KEY CLUSTERED 
(
	[clerk_account] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[momo_member]    Script Date: 2022/11/4 上午 03:13:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[momo_member](
	[member_ID] [int] IDENTITY(1001,1) NOT NULL,
	[member_account] [varchar](20) NULL,
	[member_password] [varchar](20) NULL,
	[member_name] [nvarchar](80) NULL,
	[member_phone] [varchar](20) NULL,
	[member_birthday] [date] NULL,
	[member_email] [varchar](50) NULL,
	[member_address] [nvarchar](100) NULL,
	[member_marriage] [bit] NULL,
	[member_point] [int] NULL,
	[member_available] [bit] NULL,
 CONSTRAINT [PK_member_ID] PRIMARY KEY CLUSTERED 
(
	[member_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puffFlavor]    Script Date: 2022/11/4 上午 03:13:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puffFlavor](
	[puffFlavor_ID] [int] IDENTITY(700,1) NOT NULL,
	[puffFlavor_name] [nvarchar](80) NULL,
	[puffFlavor_price] [int] NULL,
	[puffFlavor_amount] [int] NULL,
	[puffFlavor_time] [datetime2](7) NULL,
	[puffFlavor_image] [varchar](100) NULL,
	[puffFlavor_available] [bit] NULL,
 CONSTRAINT [PK_puffFlavor_ID] PRIMARY KEY CLUSTERED 
(
	[puffFlavor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puffOrder]    Script Date: 2022/11/4 上午 03:13:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puffOrder](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[puffOrder_ID] [varchar](20) NULL,
	[member_ID] [int] NULL,
	[puffFlavor_ID] [int] NULL,
	[puffOrder_flavor] [varchar](40) NULL,
	[puffOrder_dis_price] [int] NULL,
	[puffOrder_time] [datetime2](7) NULL,
	[puffOrder_state] [int] NULL,
 CONSTRAINT [PK_PO_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[dessert] ON 

INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (101, N'puff', N'泡芙（綜合）', 400, N'', N'C8A03347-A5E0-480E-A095-84E9AF28E658.jpg', 0)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (102, N'cookie', N'起司餅餅（小）', 120, N'可以當狗狗零食喔～', N'CheeseStick.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (103, N'cookie', N'起司餅餅（大）', 220, N'狗狗可食', N'CheeseStick.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (104, N'cookie', N'波卡米餅', 200, N'隨機兩種口味', N'BokaRiceCookie.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (105, N'cookie', N'舔嘴杏仁餅', 300, N'11入/罐', N'almondCookie.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (106, N'bread', N'蔓越莓司康', 350, N'6入/袋', N'scone.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (107, N'bread', N'百箱可可旅人蛋糕', 350, N'5入/盒', N'passionCocoCupCake.jpeg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (108, N'', N'金光閃閃巧克力球', 250, N'10入/罐，比利時進口純黑巧及白巧混合 +  特製焦糖脆片與杏仁角 +  純金箔粉', N'blackChocolate.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (109, N'', N'粉紅泡泡巧克力球', 300, N'10入/罐，紅寶石巧克力 + 乾燥莓果乾 + 脆球餅乾', N'redChocolate.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (110, N'canele', N'天使之鈴可麗露（原味）', 450, N'6入/盒', N'canele.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (111, N'canele', N'天使之鈴可麗露（櫻桃可可）', 450, N'6入/盒', N'canele.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (112, N'canele', N'天使之鈴可麗露（綜合）', 450, N'6入/盒，原味、櫻桃可可各3', N'canele.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (113, N'puff', N'泡芙（草莓起司）', 70, N'', N'puffstrawberrycheese.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (114, N'puff', N'泡芙（伯爵茶）', 70, N'', N'puffearlgrey.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (115, N'puff', N'泡芙（香草奶油）', 70, N'', N'puffvanilla.png', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (116, N'puff', N'泡芙（香濃可可）', 70, N'', N'puffchocolate.png', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (117, N'bread', N'檸檬瑪德蓮', 270, N'6入/袋', N'lemonMadeleine.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (118, N'', N'檸夏檸檬塔', 90, N'', N'lemonTart.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (119, N'mousse', N'酒鬼先生（大）', 520, N'提拉米蘇', N'TiramisuL.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (120, N'mousse', N'酒鬼先生（小）', 140, N'提拉米蘇', N'TiramisuS.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (121, N'', N'裝熟乳酪', 350, N'5入/盒', N'cheeseCake.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (122, N'mousse', N'香芒柚ＹＯ（大）', 450, N'芒果乳酪蛋糕盒', N'mangograpepudding.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (123, N'mousse', N'香芒柚ＹＯ（小）', 130, N'芒果乳酪蛋糕杯', N'mangograpepudding.jpg', 0)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (124, N'mousse', N'嬌貴小姐（大）', 520, N'草莓提拉米蘇', N'strawberryTiramisuL.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (125, N'mousse', N'嬌貴小姐（小）', 140, N'草莓提拉米蘇', N'strawberryTiramisuS.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (126, N'', N'鳳梨酥', 450, N'8入/盒', N'pineappleCake.jpg', 1)
INSERT [dbo].[dessert] ([dessert_ID], [dessert_category], [dessert_name], [dessert_price], [dessert_description], [dessert_image], [dessert_available]) VALUES (127, N'', N'小新', 200, N'蠟筆小新', N'202211040227122548.jpg', 1)
SET IDENTITY_INSERT [dbo].[dessert] OFF
GO
SET IDENTITY_INSERT [dbo].[dessertOrder] ON 

INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (1, N'20221112328342579', 1001, 105, 1, 285, CAST(N'2022-11-01T23:28:34.3746813' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (2, N'20221112328342579', 1001, 112, 1, 427, CAST(N'2022-11-01T23:28:34.3776735' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (3, N'20221112328342579', 1001, 122, 2, 427, CAST(N'2022-11-01T23:28:34.3776735' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (4, N'20221101234541461248', 1001, 106, 2, 332, CAST(N'2022-11-01T23:45:41.4651079' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (5, N'20221101234541461248', 1001, 110, 1, 427, CAST(N'2022-11-01T23:45:41.4661063' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (6, N'20221101234541461248', 1001, 113, 1, 66, CAST(N'2022-11-01T23:45:41.4730865' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (7, N'20221102000127744992', 1001, 105, 1, 285, CAST(N'2022-11-02T00:01:27.7507052' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (8, N'20221102000127744992', 1001, 116, 1, 66, CAST(N'2022-11-02T00:01:27.7537065' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (9, N'20221102000127744992', 1001, 126, 1, 427, CAST(N'2022-11-02T00:01:27.7546942' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (10, N'20221102000250073558', 1002, 106, 1, 350, CAST(N'2022-11-02T00:02:50.0798888' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (11, N'20221102000250073558', 1002, 115, 1, 70, CAST(N'2022-11-02T00:02:50.0813100' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (12, N'20221102000250073558', 1002, 118, 1, 90, CAST(N'2022-11-02T00:02:50.0852556' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (13, N'20221102000250073558', 1002, 117, 1, 270, CAST(N'2022-11-02T00:02:50.0852556' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (14, N'20221102000250073558', 1002, 125, 2, 140, CAST(N'2022-11-02T00:02:50.0862537' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (15, N'20221102000800578213', 1010, 103, 2, 220, CAST(N'2022-11-02T00:08:00.5797968' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (16, N'20221102000800578213', 1010, 108, 1, 250, CAST(N'2022-11-02T00:08:00.5808103' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (17, N'20221102000800578213', 1010, 111, 1, 450, CAST(N'2022-11-02T00:08:00.5817939' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (18, N'20221102001003172223', 1010, 105, 1, 285, CAST(N'2022-11-02T00:10:03.1810168' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (19, N'20221102001003172223', 1010, 118, 2, 85, CAST(N'2022-11-02T00:10:03.1830009' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (20, N'20221102001003172223', 1010, 124, 1, 494, CAST(N'2022-11-02T00:10:03.1840098' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (21, N'20221102001935822200', 1011, 119, 1, 520, CAST(N'2022-11-02T00:19:35.8315816' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (22, N'20221102001935822200', 1011, 126, 2, 450, CAST(N'2022-11-02T00:19:35.8335503' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (23, N'20221102002305813762', 1011, 105, 1, 285, CAST(N'2022-11-02T00:23:05.8198399' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (24, N'20221102002754607776', 1016, 105, 1, 300, CAST(N'2022-11-02T00:27:54.6119723' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (25, N'20221102002848875820', 1016, 105, 1, 285, CAST(N'2022-11-02T00:28:48.8869494' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (26, N'20221102002848875820', 1016, 109, 1, 285, CAST(N'2022-11-02T00:28:48.8879471' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (27, N'20221102002848875820', 1016, 112, 1, 427, CAST(N'2022-11-02T00:28:48.8889455' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (28, N'20221102220044014265', 1016, 110, 1, 427, CAST(N'2022-11-02T22:00:44.0200419' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (29, N'20221102220044014265', 1016, 122, 1, 427, CAST(N'2022-11-02T22:00:44.0215318' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (30, N'20221102220725805795', 1016, 108, 2, 225, CAST(N'2022-11-02T22:07:25.8113611' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (31, N'20221102220725805795', 1016, 121, 1, 315, CAST(N'2022-11-02T22:07:25.8123591' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (32, N'20221102230033983047', 1016, 109, 2, 270, CAST(N'2022-11-02T23:00:34.0000909' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (33, N'20221102230033983047', 1016, 104, 2, 180, CAST(N'2022-11-02T23:00:34.0010882' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (34, N'20221102230033983047', 1016, 119, 1, 468, CAST(N'2022-11-02T23:00:34.0020857' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (35, N'20221103003926259260', 1016, 107, 1, 350, CAST(N'2022-11-03T00:39:26.2692443' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (36, N'20221103003926259260', 1016, 110, 1, 450, CAST(N'2022-11-03T00:39:26.2702420' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (37, N'20221103003926259260', 1016, 115, 1, 70, CAST(N'2022-11-03T00:39:26.2712399' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (38, N'20221103003926259260', 1016, 122, 1, 450, CAST(N'2022-11-03T00:39:26.2732360' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (39, N'20221103004446841199', 1016, 104, 1, 200, CAST(N'2022-11-03T00:44:46.8548891' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (40, N'20221103203939546612', 1016, 103, 1, 209, CAST(N'2022-11-03T20:39:39.5525175' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (41, N'20221103203939546612', 1016, 107, 2, 332, CAST(N'2022-11-03T20:39:39.5544736' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (42, N'20221103203939546612', 1016, 105, 1, 285, CAST(N'2022-11-03T20:39:39.5544736' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (43, N'110401274722', 1016, 102, 1, 108, CAST(N'2022-11-04T01:27:47.6976202' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (44, N'110401274722', 1016, 107, 2, 315, CAST(N'2022-11-04T01:27:47.6996138' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (45, N'110401274722', 1016, 109, 2, 270, CAST(N'2022-11-04T01:27:47.7006111' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (46, N'110401274722', 1016, 112, 1, 405, CAST(N'2022-11-04T01:27:47.7033254' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (47, N'110401274722', 1016, 118, 2, 81, CAST(N'2022-11-04T01:27:47.7033254' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (48, N'110402000849', 1016, 106, 1, 315, CAST(N'2022-11-04T02:00:08.3662311' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (49, N'110402000849', 1016, 117, 1, 243, CAST(N'2022-11-04T02:00:08.3682754' AS DateTime2), 1)
INSERT [dbo].[dessertOrder] ([ID], [dessertOrder_ID], [member_ID], [dessert_ID], [dessert_amount], [dessert_dis_price], [dessertOrder_time], [dessertOrder_state]) VALUES (50, N'110403082324', 1016, 104, 1, 190, CAST(N'2022-11-04T03:08:23.1737442' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[dessertOrder] OFF
GO
SET IDENTITY_INSERT [dbo].[memberOrder] ON 

INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'110401274722', 1016, N'宅配到府$100', N'800高雄市新興區自立二路72號', N'付現', N'基本包裝', CAST(N'2022-11-04T01:27:47.7063544' AS DateTime2), 2950, 1, 2, 17)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'110402000849', 1016, N'宅配到府$100', N'800高雄市新興區自立二路72號', N'付現', N'基本包裝', CAST(N'2022-11-04T02:00:08.3704429' AS DateTime2), 1520, 1, 2, 18)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'110403082324', 1016, N'到店自取', N'甜點工作室在橋頭', N'付現', N'基本包裝', CAST(N'2022-11-04T03:08:23.1787306' AS DateTime2), 570, 1, 1, 19)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102000127001594', 1001, N'宅配到府$100', N'800高雄市新興區自立二路72號', N'付現', N'基本包裝', CAST(N'2022-11-02T00:01:27.7566899' AS DateTime2), 1320, 1, 0, 1)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102000250009259', 1002, N'到店自取', N'甜點工作室在橋頭', N'付現', N'基本包裝', CAST(N'2022-11-02T00:02:50.0882479' AS DateTime2), 1060, 1, 0, 2)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102000800007517', 1010, N'宅配到府$100', N'600嘉義市東區嘉北街101號', N'付現', N'基本包裝', CAST(N'2022-11-02T00:08:00.5848171' AS DateTime2), 1640, 1, 0, 3)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102001003001232', 1010, N'宅配到府$100', N'600嘉義市東區嘉北街101號', N'付現', N'基本包裝', CAST(N'2022-11-02T00:10:03.1879788' AS DateTime2), 1050, 1, 0, 4)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102001935822200', 1011, N'到店自取', N'甜點工作室在橋頭', N'付現', N'基本包裝', CAST(N'2022-11-02T00:19:35.8389247' AS DateTime2), 1420, 1, 2, 5)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102002305813762', 1011, N'到店自取', N'甜點工作室在橋頭', N'付現', N'基本包裝', CAST(N'2022-11-02T00:23:05.8256438' AS DateTime2), 665, 1, 2, 6)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102002529856975', 1012, N'冷凍宅配$200', N'300新竹市東區中央路342號', N'付現', N'基本包裝', CAST(N'2022-11-02T00:25:29.8796826' AS DateTime2), 2200, 1, 2, 7)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102002754607776', 1016, N'冷凍宅配$200', N'800高雄市新興區自立二路72號', N'付現', N'基本包裝', CAST(N'2022-11-02T00:27:54.6149648' AS DateTime2), 900, 1, 0, 8)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102002848875820', 1016, N'到店自取', N'甜點工作室在橋頭', N'付現', N'基本包裝', CAST(N'2022-11-02T00:28:48.8909394' AS DateTime2), 1850, 1, 0, 9)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102220044014265', 1016, N'宅配到府$100', N'800高雄市新興區自立二路72號', N'付現', N'基本包裝', CAST(N'2022-11-02T22:00:44.0238688' AS DateTime2), 1000, 1, 2, 10)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102220725805795', 1016, N'冷凍宅配$200', N'800高雄市新興區自立二路72號', N'付現', N'基本包裝', CAST(N'2022-11-02T22:07:25.8153505' AS DateTime2), 1850, 1, 2, 11)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221102230033983047', 1016, N'冷凍宅配$200', N'800高雄市新興區自立二路72號', N'付現', N'基本包裝', CAST(N'2022-11-02T23:00:34.0040801' AS DateTime2), 2648, 1, 1, 12)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221103003926259260', 1016, N'宅配到府$100', N'800高雄市新興區自立二路72號', N'付現', N'基本包裝', CAST(N'2022-11-03T00:39:26.2762582' AS DateTime2), 2220, 1, 1, 13)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221103004446841199', 1016, N'到店自取', N'甜點工作室在橋頭', N'付現', N'基本包裝', CAST(N'2022-11-03T00:44:46.8608747' AS DateTime2), 600, 1, 1, 14)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'20221103203939546612', 1016, N'到店自取', N'甜點工作室在橋頭', N'付現', N'基本包裝', CAST(N'2022-11-03T20:39:39.5574677' AS DateTime2), 2020, 1, 1, 15)
INSERT [dbo].[memberOrder] ([memberOrder_ID], [member_ID], [memberOrder_delivery], [memberOrder_address], [memberOrder_payment], [memberOrder_package], [memberOrder_time], [memberOrder_totalPrice], [memberOrder_available], [memberOrder_state], [mid]) VALUES (N'43172', NULL, NULL, NULL, NULL, NULL, CAST(N'2022-11-02T23:59:27.9405788' AS DateTime2), NULL, 1, 1, 16)
SET IDENTITY_INSERT [dbo].[memberOrder] OFF
GO
SET IDENTITY_INSERT [dbo].[momo_clerk_account] ON 

INSERT [dbo].[momo_clerk_account] ([clerk_ID], [clerk_account], [clerk_password], [clerk_available]) VALUES (2002, N'0000', N'0000', 1)
INSERT [dbo].[momo_clerk_account] ([clerk_ID], [clerk_account], [clerk_password], [clerk_available]) VALUES (2001, N'clerk1acc', N'clerk1psw', 1)
SET IDENTITY_INSERT [dbo].[momo_clerk_account] OFF
GO
SET IDENTITY_INSERT [dbo].[momo_member] ON 

INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1001, N'member1acc', N'member1psw', N'Pancake Ball', N'0979252743', CAST(N'1979-05-14' AS Date), N'maylin0979@gmail.com', N'800高雄市新興區自立二路72號', 0, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1002, N'member2acc', N'member2psw', N'Once Sweet', N'0994629572', CAST(N'1997-04-04' AS Date), N'amywhite948@gmail.com', N'803高雄市鹽埕區莒光街171號', 0, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1003, N'member3acc', N'member3psw', N'Windy Day', N'0904668463', CAST(N'1996-02-29' AS Date), N'maylin0979@gmail.com', N'600嘉義市東區興業新村40號', 0, 0, 0)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1010, N'member4acc', N'member4psw', N'meowmeow BookStore', N'0936583602', CAST(N'1951-07-10' AS Date), N'jfoa@jfeio.aj0', N'600嘉義市東區嘉北街101號', 1, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1011, N'member5acc', N'member5psw', N'yuiituwagyu hotpot', N'0963454645', CAST(N'1983-10-25' AS Date), N'feijjoaw@jfo.eof', N'407台中市西屯區文心路二段568號', 0, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1012, N'member6acc', N'member6psw', N'WOW Kichen', N'0945738455', CAST(N'1984-04-17' AS Date), N'aejojfkdei@fioeafofeo.fjiwoe', N'300新竹市東區中央路342號', 0, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1013, N'member7acc', N'member7psw', N'bellini cafffe', N'0974365784', CAST(N'1973-05-22' AS Date), N'fjeiwoa@aoejn.eji', N'104台北市中山區復興北路288號', 1, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1014, N'member8acc', N'member8psw', N'willison cafe', N'0937589436', CAST(N'1985-03-27' AS Date), N'zxoiwa@aolwqc.o', N'811高雄市楠梓區惠豐街192號號', 1, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1015, N'member9acc', N'member9psw', N'灶垰 和風洋食', N'0967456324', CAST(N'1989-09-14' AS Date), N'pemwq@j0z.fwe', N'820高雄市岡山區忠誠街272號', 1, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1016, N'1111', N'1111', N'測試人員', N'0911111111', CAST(N'1979-05-14' AS Date), N'grght46efe2@gmail.com', N'800高雄市新興區自立二路72號', 0, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1017, N'member10acc', N'member10psw', N'林鴻裕', N'0963785682', CAST(N'1974-10-15' AS Date), N'48dfhn79ewaf@fheu.ei', N'801高雄市前金區市中一路270號', 1, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1018, N'member11acc', N'member11psw', N'ECRET AND SENSES', N'0945614235', CAST(N'1953-05-07' AS Date), N'ehwua471@ehwuoa.eyfg', N'700台南市中西區永福路一段269號', 0, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1019, N'member13acc', N'member13psw', N'暖呼呼食堂', N'0913878613', CAST(N'1973-08-02' AS Date), N'qopmxz1635@qocu.awl', N'800高雄市新興區民族二路55巷14號', 1, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1020, N'member15acc', N'member15psw', N'陳大貓', N'0948643187', CAST(N'2000-11-04' AS Date), N'abcabc@eioa.ejw', N'106台北市大安區復興南路一段390號2樓', 0, 0, 1)
INSERT [dbo].[momo_member] ([member_ID], [member_account], [member_password], [member_name], [member_phone], [member_birthday], [member_email], [member_address], [member_marriage], [member_point], [member_available]) VALUES (1021, N'member16acc', N'member16psw', N'這餐你Food', N'0945612536', CAST(N'2002-04-26' AS Date), N'hwuiaoqp@ewag.rgr', N'106台北市大安區通化街19巷6弄2號', 0, 0, 0)
SET IDENTITY_INSERT [dbo].[momo_member] OFF
GO
SET IDENTITY_INSERT [dbo].[puffFlavor] ON 

INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (700, N'[草莓起司][伯爵茶]', 400, 1, CAST(N'2022-10-31T09:49:05.5794466' AS DateTime2), N'C8A03347-A5E0-480E-A095-84E9AF28E658.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (701, N'[草莓起司][香草奶油]', 400, 1, CAST(N'2022-10-31T09:49:05.5804444' AS DateTime2), N'C8A03347-A5E0-480E-A095-84E9AF28E658.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (702, N'[草莓起司][香濃可可]', 400, 1, CAST(N'2022-10-31T09:49:05.5804444' AS DateTime2), N'C8A03347-A5E0-480E-A095-84E9AF28E658.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (703, N'[伯爵茶][香草奶油]', 400, 1, CAST(N'2022-10-31T09:49:05.5804444' AS DateTime2), N'C8A03347-A5E0-480E-A095-84E9AF28E658.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (704, N'[伯爵茶][香濃可可]', 400, 1, CAST(N'2022-10-31T09:49:05.5814471' AS DateTime2), N'C8A03347-A5E0-480E-A095-84E9AF28E658.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (705, N'[香草奶油][香濃可可]', 400, 1, CAST(N'2022-10-31T09:49:05.5814471' AS DateTime2), N'C8A03347-A5E0-480E-A095-84E9AF28E658.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (706, N'[草莓起司][伯爵茶][香草奶油]', 400, 1, CAST(N'2022-10-31T09:49:05.5814471' AS DateTime2), N'C8A03347-A5E0-480E-A095-84E9AF28E658.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (707, N'[草莓起司][伯爵茶][香濃可可]', 400, 1, CAST(N'2022-10-31T09:49:05.5824440' AS DateTime2), N'C8A03347-A5E0-480E-A095-84E9AF28E658.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (708, N'[伯爵茶][香草奶油][香濃可可]', 400, 1, CAST(N'2022-10-31T09:49:05.5824440' AS DateTime2), N'C8A03347-A5E0-480E-A095-84E9AF28E658.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (709, N'泡芙(綜合)', 400, 1, CAST(N'2022-10-31T09:49:05.5824440' AS DateTime2), N'C8A03347-A5E0-480E-A095-84E9AF28E658.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (710, N'[草莓起司]', 0, 6, CAST(N'2022-10-31T09:49:05.5844433' AS DateTime2), N'puffstrawberrycheese.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (711, N'[伯爵茶]', 0, 6, CAST(N'2022-10-31T09:49:05.5844433' AS DateTime2), N'puffearlgrey.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (712, N'[香草奶油]', 0, 6, CAST(N'2022-10-31T09:49:05.5844433' AS DateTime2), N'puffvanilla.png', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (713, N'[香濃可可]', 0, 6, CAST(N'2022-10-31T09:49:05.5854295' AS DateTime2), N'puffchocolate.png', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (714, N'[草莓起司]', 0, 2, CAST(N'2022-10-31T09:49:05.5854295' AS DateTime2), N'puffstrawberrycheese.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (715, N'[伯爵茶]', 0, 2, CAST(N'2022-10-31T09:49:05.5864269' AS DateTime2), N'puffearlgrey.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (716, N'[香草奶油]', 0, 2, CAST(N'2022-10-31T09:49:05.5864269' AS DateTime2), N'puffvanilla.png', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (717, N'[香濃可可]', 0, 2, CAST(N'2022-10-31T09:49:05.5864269' AS DateTime2), N'puffchocolate.png', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (718, N'[草莓起司]', 0, 3, CAST(N'2022-10-31T09:49:05.5874285' AS DateTime2), N'puffstrawberrycheese.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (719, N'[伯爵茶]', 0, 3, CAST(N'2022-10-31T09:49:05.5874285' AS DateTime2), N'puffearlgrey.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (720, N'[香草奶油]', 0, 3, CAST(N'2022-10-31T09:49:05.5874285' AS DateTime2), N'puffvanilla.png', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (721, N'[香濃可可]', 0, 3, CAST(N'2022-10-31T09:49:05.5884214' AS DateTime2), N'puffchocolate.png', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (722, N'[草莓起司]', 0, 6, CAST(N'2022-10-31T09:49:05.5884214' AS DateTime2), N'puffstrawberrycheese.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (723, N'[伯爵茶]', 0, 6, CAST(N'2022-10-31T09:49:05.5884214' AS DateTime2), N'puffearlgrey.jpg', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (724, N'[香草奶油]', 0, 6, CAST(N'2022-10-31T09:49:05.5884214' AS DateTime2), N'puffvanilla.png', 1)
INSERT [dbo].[puffFlavor] ([puffFlavor_ID], [puffFlavor_name], [puffFlavor_price], [puffFlavor_amount], [puffFlavor_time], [puffFlavor_image], [puffFlavor_available]) VALUES (725, N'[香濃可可]', 0, 6, CAST(N'2022-10-31T09:49:05.5894290' AS DateTime2), N'puffchocolate.png', 1)
SET IDENTITY_INSERT [dbo].[puffFlavor] OFF
GO
SET IDENTITY_INSERT [dbo].[puffOrder] ON 

INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (1, N'202210311610496010', 1016, 701, N'[草莓起司][香草奶油]', NULL, CAST(N'2022-10-31T16:10:49.7807181' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (2, N'202210311610496010', 1016, 704, N'[伯爵茶][香濃可可]', NULL, CAST(N'2022-10-31T16:10:49.7832092' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (3, N'202210311610496010', 1016, 708, N'[伯爵茶][香草奶油][香濃可可]', NULL, CAST(N'2022-10-31T16:10:49.7854206' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (4, N'202210311620355251', 1016, 703, N'[伯爵茶][香草奶油]', 400, CAST(N'2022-10-31T16:20:35.6580431' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (5, N'202210311620355251', 1016, 704, N'[伯爵茶][香濃可可]', 400, CAST(N'2022-10-31T16:20:35.6594201' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (6, N'202210311620363488', 1016, 703, N'[伯爵茶][香草奶油]', 400, CAST(N'2022-10-31T16:20:36.5508266' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (7, N'202210311620363488', 1016, 704, N'[伯爵茶][香濃可可]', 400, CAST(N'2022-10-31T16:20:36.5525079' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (8, N'202210311620378550', 1016, 703, N'[伯爵茶][香草奶油]', 400, CAST(N'2022-10-31T16:20:37.2846656' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (9, N'202210311620378550', 1016, 704, N'[伯爵茶][香濃可可]', 400, CAST(N'2022-10-31T16:20:37.2864852' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (11, N'725', 1016, 725, N'[香濃可可]', 380, CAST(N'2022-10-31T23:10:41.5766212' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (12, N'706', 1016, 706, N'[草莓起司][伯爵茶][香草奶油]', 380, CAST(N'2022-10-31T23:10:41.5806097' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (13, N'723', 1016, 723, N'[伯爵茶]', 380, CAST(N'2022-10-31T23:12:50.4607016' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (16, N'202210312356511943', 1016, 700, N'[草莓起司][伯爵茶]', 380, CAST(N'2022-10-31T23:56:51.0738393' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (17, N'202210312356511943', 1016, 707, N'[草莓起司][伯爵茶][香濃可可]', 380, CAST(N'2022-10-31T23:56:51.0758340' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (18, N'202211102758813', 1016, 723, N'[伯爵茶]', 380, CAST(N'2022-11-01T00:27:05.4831350' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (19, N'202211102758813', 1016, 725, N'[香濃可可]', 380, CAST(N'2022-11-01T00:27:05.4853360' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (20, N'202211102758813', 1016, 700, N'[草莓起司][伯爵茶]', 380, CAST(N'2022-11-01T00:27:05.4882834' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (21, N'2022111029458754', 1016, 704, N'[伯爵茶][香濃可可]', 380, CAST(N'2022-11-01T00:29:45.5903246' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (22, N'2022111029458754', 1016, 722, N'[草莓起司]', 380, CAST(N'2022-11-01T00:29:45.5931887' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (23, N'20221112328343645', 1001, 705, N'[香草奶油][香濃可可]', 380, CAST(N'2022-11-01T23:28:34.3697422' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (24, N'20221112328343645', 1001, 723, N'[伯爵茶]', 380, CAST(N'2022-11-01T23:28:34.3716891' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (25, N'20221101234541452768', 1001, 703, N'[伯爵茶][香草奶油]', 380, CAST(N'2022-11-01T23:45:41.4631123' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (26, N'20221102000127741969', 1001, 706, N'[草莓起司][伯爵茶][香草奶油]', 380, CAST(N'2022-11-02T00:01:27.7477137' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (27, N'20221102000800573164', 1010, 708, N'[伯爵茶][香草奶油][香濃可可]', 400, CAST(N'2022-11-02T00:08:00.5768038' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (28, N'20221102002305813762', 1011, 708, N'[伯爵茶][香草奶油][香濃可可]', 380, CAST(N'2022-11-02T00:23:05.8178729' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (29, N'20221102002529856975', 1012, 703, N'[伯爵茶][香草奶油]', 360, CAST(N'2022-11-02T00:25:29.8636277' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (30, N'20221102002529856975', 1012, 708, N'[伯爵茶][香草奶油][香濃可可]', 360, CAST(N'2022-11-02T00:25:29.8686160' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (31, N'20221102002529856975', 1012, 703, N'[伯爵茶][香草奶油]', 360, CAST(N'2022-11-02T00:25:29.8726042' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (32, N'20221102002529856975', 1012, 701, N'[草莓起司][香草奶油]', 360, CAST(N'2022-11-02T00:25:29.8756925' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (33, N'20221102002529856975', 1012, 704, N'[伯爵茶][香濃可可]', 360, CAST(N'2022-11-02T00:25:29.8767146' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (34, N'20221102002754607776', 1016, 703, N'[伯爵茶][香草奶油]', 400, CAST(N'2022-11-02T00:27:54.6079837' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (35, N'20221102002848875820', 1016, 707, N'[草莓起司][伯爵茶][香濃可可]', 380, CAST(N'2022-11-02T00:28:48.8799680' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (36, N'20221102002848875820', 1016, 705, N'[香草奶油][香濃可可]', 380, CAST(N'2022-11-02T00:28:48.8829885' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (37, N'20221102220725805795', 1016, 723, N'[伯爵茶]', 360, CAST(N'2022-11-02T22:07:25.8050663' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (38, N'20221102220725805795', 1016, 702, N'[草莓起司][香濃可可]', 360, CAST(N'2022-11-02T22:07:25.8070760' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (39, N'20221102230033983047', 1016, 700, N'[草莓起司][伯爵茶]', 360, CAST(N'2022-11-02T23:00:33.9921125' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (40, N'20221102230033983047', 1016, 705, N'[香草奶油][香濃可可]', 360, CAST(N'2022-11-02T23:00:33.9951044' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (41, N'20221102230033983047', 1016, 707, N'[草莓起司][伯爵茶][香濃可可]', 360, CAST(N'2022-11-02T23:00:33.9981018' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (42, N'20221103003926259260', 1016, 703, N'[伯爵茶][香草奶油]', 400, CAST(N'2022-11-03T00:39:26.2622630' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (43, N'20221103003926259260', 1016, 725, N'[香濃可可]', 400, CAST(N'2022-11-03T00:39:26.2642576' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (44, N'20221103004446841199', 1016, 723, N'[伯爵茶]', 400, CAST(N'2022-11-03T00:44:46.8529011' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (45, N'20221103203939546612', 1016, 702, N'[草莓起司][香濃可可]', 380, CAST(N'2022-11-03T20:39:39.5464683' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (46, N'20221103203939546612', 1016, 708, N'[伯爵茶][香草奶油][香濃可可]', 380, CAST(N'2022-11-03T20:39:39.5498908' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (47, N'110401274722', 1016, 722, N'[草莓起司]', 360, CAST(N'2022-11-04T01:27:47.6926334' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (48, N'110401274722', 1016, 703, N'[伯爵茶][香草奶油]', 360, CAST(N'2022-11-04T01:27:47.6956246' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (49, N'110402000849', 1016, 704, N'[伯爵茶][香濃可可]', 360, CAST(N'2022-11-04T02:00:08.3606016' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (50, N'110402000849', 1016, 705, N'[香草奶油][香濃可可]', 360, CAST(N'2022-11-04T02:00:08.3627350' AS DateTime2), 1)
INSERT [dbo].[puffOrder] ([ID], [puffOrder_ID], [member_ID], [puffFlavor_ID], [puffOrder_flavor], [puffOrder_dis_price], [puffOrder_time], [puffOrder_state]) VALUES (51, N'110403082324', 1016, 703, N'[伯爵茶][香草奶油]', 380, CAST(N'2022-11-04T03:08:23.1707518' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[puffOrder] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_member_phone]    Script Date: 2022/11/4 上午 03:13:41 ******/
ALTER TABLE [dbo].[momo_member] ADD  CONSTRAINT [UQ_member_phone] UNIQUE NONCLUSTERED 
(
	[member_phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[dessert] ADD  DEFAULT ('') FOR [dessert_category]
GO
ALTER TABLE [dbo].[dessert] ADD  DEFAULT ('') FOR [dessert_description]
GO
ALTER TABLE [dbo].[dessert] ADD  DEFAULT ((1)) FOR [dessert_available]
GO
ALTER TABLE [dbo].[dessertOrder] ADD  DEFAULT (ceiling((1000000)*rand())) FOR [dessertOrder_ID]
GO
ALTER TABLE [dbo].[dessertOrder] ADD  DEFAULT (sysdatetime()) FOR [dessertOrder_time]
GO
ALTER TABLE [dbo].[dessertOrder] ADD  DEFAULT ((1)) FOR [dessertOrder_state]
GO
ALTER TABLE [dbo].[memberOrder] ADD  DEFAULT (ceiling((1000000)*rand())) FOR [memberOrder_ID]
GO
ALTER TABLE [dbo].[memberOrder] ADD  DEFAULT (sysdatetime()) FOR [memberOrder_time]
GO
ALTER TABLE [dbo].[memberOrder] ADD  DEFAULT ((1)) FOR [memberOrder_available]
GO
ALTER TABLE [dbo].[memberOrder] ADD  DEFAULT ((1)) FOR [memberOrder_state]
GO
ALTER TABLE [dbo].[momo_clerk_account] ADD  DEFAULT ((1)) FOR [clerk_available]
GO
ALTER TABLE [dbo].[momo_member] ADD  DEFAULT (dateadd(year,(-12),getdate())) FOR [member_birthday]
GO
ALTER TABLE [dbo].[momo_member] ADD  DEFAULT ((0)) FOR [member_marriage]
GO
ALTER TABLE [dbo].[momo_member] ADD  DEFAULT ((0)) FOR [member_point]
GO
ALTER TABLE [dbo].[momo_member] ADD  DEFAULT ((1)) FOR [member_available]
GO
ALTER TABLE [dbo].[puffFlavor] ADD  DEFAULT ((0)) FOR [puffFlavor_price]
GO
ALTER TABLE [dbo].[puffFlavor] ADD  DEFAULT (sysdatetime()) FOR [puffFlavor_time]
GO
ALTER TABLE [dbo].[puffFlavor] ADD  DEFAULT ((1)) FOR [puffFlavor_available]
GO
ALTER TABLE [dbo].[puffOrder] ADD  DEFAULT (ceiling((1000000)*rand())) FOR [puffOrder_ID]
GO
ALTER TABLE [dbo].[puffOrder] ADD  DEFAULT (sysdatetime()) FOR [puffOrder_time]
GO
ALTER TABLE [dbo].[puffOrder] ADD  DEFAULT ((1)) FOR [puffOrder_state]
GO
ALTER TABLE [dbo].[dessertOrder]  WITH CHECK ADD  CONSTRAINT [FK_do_member_ID] FOREIGN KEY([member_ID])
REFERENCES [dbo].[momo_member] ([member_ID])
GO
ALTER TABLE [dbo].[dessertOrder] CHECK CONSTRAINT [FK_do_member_ID]
GO
ALTER TABLE [dbo].[puffOrder]  WITH CHECK ADD  CONSTRAINT [FK_po_member_ID] FOREIGN KEY([member_ID])
REFERENCES [dbo].[momo_member] ([member_ID])
GO
ALTER TABLE [dbo].[puffOrder] CHECK CONSTRAINT [FK_po_member_ID]
GO
ALTER TABLE [dbo].[puffOrder]  WITH CHECK ADD  CONSTRAINT [FK_po_puffFlavor_ID] FOREIGN KEY([puffFlavor_ID])
REFERENCES [dbo].[puffFlavor] ([puffFlavor_ID])
GO
ALTER TABLE [dbo].[puffOrder] CHECK CONSTRAINT [FK_po_puffFlavor_ID]
GO
ALTER TABLE [dbo].[dessert]  WITH CHECK ADD CHECK  (([dessert_price]>=(50)))
GO
ALTER TABLE [dbo].[dessertOrder]  WITH CHECK ADD CHECK  (([dessert_amount]>(0)))
GO
ALTER TABLE [dbo].[momo_clerk_account]  WITH CHECK ADD CHECK  ((len([clerk_password])>=(4)))
GO
ALTER TABLE [dbo].[momo_member]  WITH CHECK ADD CHECK  ((len([member_password])>=(4)))
GO
USE [master]
GO
ALTER DATABASE [mymomo] SET  READ_WRITE 
GO

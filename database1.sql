USE [fooddb]
GO
/****** Object:  Table [dbo].[FoodDetails]    Script Date: 7/23/2022 4:41:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[restaurantName] [varchar](100) NULL,
	[foodName] [varchar](100) NULL,
	[foodImage] [varchar](100) NULL,
	[foodDescription] [varchar](100) NULL,
	[place] [varchar](100) NULL,
	[foodMrp] [decimal](18, 2) NULL,
	[foodDiscount] [decimal](18, 2) NULL,
	[foodFinal] [decimal](18, 2) NULL,
	[foodQuantity] [int] NULL,
	[IsActive] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodDetailsAdmin]    Script Date: 7/23/2022 4:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodDetailsAdmin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[restaurantName] [varchar](100) NULL,
	[foodName] [varchar](100) NULL,
	[foodImage] [varchar](100) NULL,
	[foodDescription] [varchar](100) NULL,
	[place] [varchar](100) NULL,
	[foodMrp] [decimal](18, 2) NULL,
	[foodDiscount] [decimal](18, 2) NULL,
	[foodFinal] [decimal](18, 2) NULL,
	[foodQuantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[myorder]    Script Date: 7/23/2022 4:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[myorder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[foodName] [varchar](100) NULL,
	[foodFinal] [decimal](18, 2) NULL,
	[foodImage] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderTbl]    Script Date: 7/23/2022 4:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderTbl](
	[Id] [int] IDENTITY(100,1) NOT NULL,
	[firstName] [varchar](100) NULL,
	[lastName] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[PhoneNo] [varchar](10) NULL,
	[paymentmode] [varchar](100) NULL,
	[Address] [varchar](100) NULL,
	[UserName] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegisterTbl]    Script Date: 7/23/2022 4:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegisterTbl](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NULL,
	[Address] [varchar](100) NULL,
	[PhoneNo] [int] NULL,
	[Email] [varchar](100) NULL,
	[Password] [varchar](100) NULL,
	[IsAdmin] [int] NULL,
	[IsRestaurant] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

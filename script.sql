USE [fooddb]
GO
/****** Object:  Table [dbo].[FoodDetails]    Script Date: 7/23/2022 4:46:45 PM ******/
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
/****** Object:  Table [dbo].[FoodDetailsAdmin]    Script Date: 7/23/2022 4:46:45 PM ******/
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
/****** Object:  Table [dbo].[myorder]    Script Date: 7/23/2022 4:46:45 PM ******/
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
/****** Object:  Table [dbo].[OrderTbl]    Script Date: 7/23/2022 4:46:45 PM ******/
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
/****** Object:  Table [dbo].[RegisterTbl]    Script Date: 7/23/2022 4:46:45 PM ******/
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
SET IDENTITY_INSERT [dbo].[FoodDetails] ON 

INSERT [dbo].[FoodDetails] ([Id], [restaurantName], [foodName], [foodImage], [foodDescription], [place], [foodMrp], [foodDiscount], [foodFinal], [foodQuantity], [IsActive]) VALUES (1, N'Vedant', N'Vada Pav', N'vadapav.jfif', N'fast food', N'pune', CAST(10.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 10, 1)
INSERT [dbo].[FoodDetails] ([Id], [restaurantName], [foodName], [foodImage], [foodDescription], [place], [foodMrp], [foodDiscount], [foodFinal], [foodQuantity], [IsActive]) VALUES (4, N'Shri', N'Snacks', N'snack.png', N'Healthy snack', N'pune', CAST(200.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(180.00 AS Decimal(18, 2)), 20, 0)
SET IDENTITY_INSERT [dbo].[FoodDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodDetailsAdmin] ON 

INSERT [dbo].[FoodDetailsAdmin] ([Id], [restaurantName], [foodName], [foodImage], [foodDescription], [place], [foodMrp], [foodDiscount], [foodFinal], [foodQuantity]) VALUES (6, N'Vedant', N'Vada Pav', N'vadapav.jfif', N'fast food', N'pune', CAST(10.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 10)
INSERT [dbo].[FoodDetailsAdmin] ([Id], [restaurantName], [foodName], [foodImage], [foodDescription], [place], [foodMrp], [foodDiscount], [foodFinal], [foodQuantity]) VALUES (7, N'Shri', N'Snacks', N'snack.png', N'Healthy snack', N'pune', CAST(200.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(180.00 AS Decimal(18, 2)), 20)
SET IDENTITY_INSERT [dbo].[FoodDetailsAdmin] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderTbl] ON 

INSERT [dbo].[OrderTbl] ([Id], [firstName], [lastName], [Email], [PhoneNo], [paymentmode], [Address], [UserName]) VALUES (102, N'jiya ', N'sharma', N'jiya@gmail.com', N'7709259757', N'Cash on Delivery', N'b103 sai complex pune', NULL)
SET IDENTITY_INSERT [dbo].[OrderTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[RegisterTbl] ON 

INSERT [dbo].[RegisterTbl] ([UserID], [UserName], [Address], [PhoneNo], [Email], [Password], [IsAdmin], [IsRestaurant]) VALUES (5, N'jiya', N'pune', 1234, N'jiya@gmail.com', N'jiya', NULL, NULL)
INSERT [dbo].[RegisterTbl] ([UserID], [UserName], [Address], [PhoneNo], [Email], [Password], [IsAdmin], [IsRestaurant]) VALUES (6, N'arati', N'pune', 77093, N'arati@gmail.com', N'arati', 1, 0)
INSERT [dbo].[RegisterTbl] ([UserID], [UserName], [Address], [PhoneNo], [Email], [Password], [IsAdmin], [IsRestaurant]) VALUES (7, N'Vedant', N'pune', 67854, N'vedant@gmail.com', N'Vedant', 0, 1)
INSERT [dbo].[RegisterTbl] ([UserID], [UserName], [Address], [PhoneNo], [Email], [Password], [IsAdmin], [IsRestaurant]) VALUES (8, N'riya@gmail.com', NULL, NULL, NULL, N'riya', NULL, NULL)
SET IDENTITY_INSERT [dbo].[RegisterTbl] OFF
GO

USE [TaqK22CNTt3Lession11Db]
GO
/****** Object:  Table [dbo].[TaqCategory]    Script Date: 04/07/2024 10:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaqCategory](
	[TaqID] [int] IDENTITY(1,1) NOT NULL,
	[TaqCateName] [nvarchar](50) NULL,
	[TaqStatus] [int] NULL,
 CONSTRAINT [PK_TaqCategory] PRIMARY KEY CLUSTERED 
(
	[TaqID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaqProduct]    Script Date: 04/07/2024 10:40:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaqProduct](
	[TaqID2210900058] [nvarchar](50) NOT NULL,
	[TaqProName] [nvarchar](50) NULL,
	[TaqQty] [int] NULL,
	[TaqPrice] [float] NULL,
	[TaqCateID] [int] NULL,
	[TaqActive] [bit] NULL,
 CONSTRAINT [PK_TaqProduct] PRIMARY KEY CLUSTERED 
(
	[TaqID2210900058] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TaqCategory] ON 

INSERT [dbo].[TaqCategory] ([TaqID], [TaqCateName], [TaqStatus]) VALUES (1, N'2210900058', NULL)
INSERT [dbo].[TaqCategory] ([TaqID], [TaqCateName], [TaqStatus]) VALUES (2, N'iphone', NULL)
SET IDENTITY_INSERT [dbo].[TaqCategory] OFF
GO
INSERT [dbo].[TaqProduct] ([TaqID2210900058], [TaqProName], [TaqQty], [TaqPrice], [TaqCateID], [TaqActive]) VALUES (N'2210900058', N'Truong Anh Quan', 10, 100, 1, 1)
INSERT [dbo].[TaqProduct] ([TaqID2210900058], [TaqProName], [TaqQty], [TaqPrice], [TaqCateID], [TaqActive]) VALUES (N'P001', N'Iphone 15', 1, 2000, 1, NULL)
GO

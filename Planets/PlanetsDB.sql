USE [PlanetsDb]
GO
/****** Object:  Table [dbo].[Eclipse]    Script Date: 01.01.2019 20:43:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eclipse](
	[IDEclipse] [int] IDENTITY(1,1) NOT NULL,
	[DataOfEclipse] [date] NOT NULL,
	[StartEclipse] [time](7) NOT NULL,
	[MaxPhase] [time](7) NOT NULL,
	[EndEclipse] [time](7) NOT NULL,
	[Discription] [nvarchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEclipse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IsThereLife]    Script Date: 01.01.2019 20:43:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IsThereLife](
	[IDLife] [int] IDENTITY(1,1) NOT NULL,
	[Life] [varchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLife] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeseagesFromUsers]    Script Date: 01.01.2019 20:43:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeseagesFromUsers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Author] [nvarchar](32) NOT NULL,
	[Content] [nvarchar](360) NOT NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planet]    Script Date: 01.01.2019 20:43:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planet](
	[IDPlanet] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Type] [int] NOT NULL,
	[Mass] [float] NOT NULL,
	[Radius] [float] NOT NULL,
	[Life] [int] NOT NULL,
	[PlanetarySystem] [int] NOT NULL,
	[Image] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPlanet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanetarySystem]    Script Date: 01.01.2019 20:43:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanetarySystem](
	[IDPlanetarySystem] [int] IDENTITY(1,1) NOT NULL,
	[System] [nvarchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPlanetarySystem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Star]    Script Date: 01.01.2019 20:43:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Star](
	[IDPlanet] [int] IDENTITY(1,1) NOT NULL,
	[NameStar] [nvarchar](128) NOT NULL,
	[TypeStar] [varchar](128) NOT NULL,
	[Mass] [float] NOT NULL,
	[Radius] [float] NOT NULL,
	[PlanetarySystem] [int] NOT NULL,
	[Image] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPlanet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfPlanet]    Script Date: 01.01.2019 20:43:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfPlanet](
	[IDType] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Planet]  WITH CHECK ADD FOREIGN KEY([Type])
REFERENCES [dbo].[TypeOfPlanet] ([IDType])
GO
ALTER TABLE [dbo].[Planet]  WITH CHECK ADD FOREIGN KEY([Life])
REFERENCES [dbo].[IsThereLife] ([IDLife])
GO
ALTER TABLE [dbo].[Planet]  WITH CHECK ADD FOREIGN KEY([PlanetarySystem])
REFERENCES [dbo].[PlanetarySystem] ([IDPlanetarySystem])
GO
ALTER TABLE [dbo].[Star]  WITH CHECK ADD FOREIGN KEY([PlanetarySystem])
REFERENCES [dbo].[PlanetarySystem] ([IDPlanetarySystem])
GO

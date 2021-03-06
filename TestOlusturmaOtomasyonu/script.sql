USE [TestHazirlamaOtoDB]
GO
/****** Object:  Table [dbo].[Sorular]    Script Date: 1.8.2016 23:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sorular](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Soru] [nvarchar](200) NOT NULL,
	[CevapA] [nvarchar](250) NOT NULL,
	[CevapB] [nvarchar](250) NOT NULL,
	[CevapC] [nvarchar](250) NOT NULL,
	[CevapD] [nvarchar](250) NOT NULL,
	[Cevap] [nvarchar](1) NOT NULL,
	[TestId] [int] NOT NULL,
 CONSTRAINT [PK_Sorular] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Test]    Script Date: 1.8.2016 23:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[BaslamaTarihi] [date] NOT NULL,
	[BitisTarihi] [date] NOT NULL,
	[OgretmenAdi] [nvarchar](50) NOT NULL,
	[SoruAdeti] [int] NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Sorular]  WITH CHECK ADD  CONSTRAINT [FK_Sorular_Test] FOREIGN KEY([TestId])
REFERENCES [dbo].[Test] ([Id])
GO
ALTER TABLE [dbo].[Sorular] CHECK CONSTRAINT [FK_Sorular_Test]
GO

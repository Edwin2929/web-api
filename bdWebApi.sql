USE [master]
GO
/****** Object:  Database [ejemplo_GBD]    Script Date: 20/9/2018 11:37:35 ******/
CREATE DATABASE [ejemplo_GBD]
 CONTAINMENT = NONE
GO
USE [ejemplo_GBD]
GO
/****** Object:  Table [dbo].[Docentes]    Script Date: 20/9/2018 11:37:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docentes](
	[iddocente] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[fecha] [date] NULL,
	[direccion] [varchar](100) NULL,
	[especialidad] [varchar](50) NULL,
 CONSTRAINT [PK_Docentes] PRIMARY KEY CLUSTERED 
(
	[iddocente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Docentes] ([iddocente], [nombre], [Apellidos], [fecha], [direccion], [especialidad]) VALUES (2, N'Jose Juan', N'Lopez Perez', CAST(N'2018-12-12' AS Date), N'sonsonate, El Salvador', N'Ingles')
INSERT [dbo].[Docentes] ([iddocente], [nombre], [Apellidos], [fecha], [direccion], [especialidad]) VALUES (3, N'Juan Jose', N'Leña Perez', CAST(N'2018-09-06' AS Date), N'Ataco', N'Ingles')
INSERT [dbo].[Docentes] ([iddocente], [nombre], [Apellidos], [fecha], [direccion], [especialidad]) VALUES (5, N'Elmer Jose', N'Lopez Perez', CAST(N'2018-09-07' AS Date), N'Atiquizaya, Ahuachapan', N'Porgramacion')
INSERT [dbo].[Docentes] ([iddocente], [nombre], [Apellidos], [fecha], [direccion], [especialidad]) VALUES (6, N'Jose Elmer', N'Mojica Hernandez', CAST(N'2018-09-13' AS Date), N'Ataco, Ahuchapan', N'Ingles')
USE [master]
GO
ALTER DATABASE [ejemplo_GBD] SET  READ_WRITE 
GO

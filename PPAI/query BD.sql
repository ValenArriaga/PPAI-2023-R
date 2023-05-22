USE [master]
GO
/****** Object:  Database [PPAI]    Script Date: 22/5/2023 17:32:35 ******/
CREATE DATABASE [PPAI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PPAI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PPAI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PPAI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PPAI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PPAI] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PPAI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PPAI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PPAI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PPAI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PPAI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PPAI] SET ARITHABORT OFF 
GO
ALTER DATABASE [PPAI] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PPAI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PPAI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PPAI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PPAI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PPAI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PPAI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PPAI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PPAI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PPAI] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PPAI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PPAI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PPAI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PPAI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PPAI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PPAI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PPAI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PPAI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PPAI] SET  MULTI_USER 
GO
ALTER DATABASE [PPAI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PPAI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PPAI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PPAI] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PPAI] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PPAI] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PPAI] SET QUERY_STORE = OFF
GO
USE [PPAI]
GO
/****** Object:  Table [dbo].[Accion]    Script Date: 22/5/2023 17:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Accion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CambioEstado]    Script Date: 22/5/2023 17:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CambioEstado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fechaHoraInicio] [datetime] NOT NULL,
	[idLlamada] [int] NOT NULL,
	[idEstado] [int] NOT NULL,
 CONSTRAINT [PK_CambioEstado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriaLlamada]    Script Date: 22/5/2023 17:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaLlamada](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nroOrden] [int] NULL,
	[nombre] [varchar](50) NULL,
	[audioMensajeOpciones] [varchar](50) NULL,
	[mensajeOpciones] [varchar](50) NULL,
 CONSTRAINT [PK_CategoriaLlamada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 22/5/2023 17:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nroCelular] [int] NULL,
 CONSTRAINT [PK_Cliente_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 22/5/2023 17:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](10) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InformacionCliente]    Script Date: 22/5/2023 17:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InformacionCliente](
	[idInfoCliente] [int] NOT NULL,
	[datoAValidar] [varchar](50) NOT NULL,
	[idOpcionCorrecta] [int] NOT NULL,
	[idValidacion] [int] NOT NULL,
	[tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_InformacionCliente] PRIMARY KEY CLUSTERED 
(
	[idInfoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Llamada]    Script Date: 22/5/2023 17:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Llamada](
	[idLlamada] [int] IDENTITY(1,1) NOT NULL,
	[descripcionOperador] [nchar](100) NULL,
	[detalleAccionRequerida] [nchar](100) NULL,
	[duracion] [time](7) NULL,
	[encuestaEnviada] [bit] NULL,
	[observacionAuditor] [nchar](100) NULL,
	[idCliente] [int] NOT NULL,
	[idAccion] [int] NULL,
	[idSubOpcionLlamada] [int] NULL,
	[idOpcionLlamada] [int] NULL,
	[idUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Llamada] PRIMARY KEY CLUSTERED 
(
	[idLlamada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OpcionLlamada]    Script Date: 22/5/2023 17:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpcionLlamada](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nroOrden] [int] NULL,
	[nombre] [varchar](50) NULL,
	[audioMensajesSubopciones] [varchar](50) NULL,
	[mensajeSubopciones] [varchar](50) NULL,
 CONSTRAINT [PK_OpcionLlamada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OpcionValidacion]    Script Date: 22/5/2023 17:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpcionValidacion](
	[idOpcionValidacion] [int] NOT NULL,
	[correcta] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[idValidacion] [int] NOT NULL,
 CONSTRAINT [PK_OpcionValidacion] PRIMARY KEY CLUSTERED 
(
	[idOpcionValidacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubOpcionLlamada]    Script Date: 22/5/2023 17:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubOpcionLlamada](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nroOrden] [nchar](10) NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_SubOpcionLlamada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/5/2023 17:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[activo] [bit] NULL,
	[fechaAlta] [date] NULL,
	[nombreUsuario] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Validacion]    Script Date: 22/5/2023 17:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Validacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nroOrden] [int] NULL,
	[nombre] [varchar](50) NULL,
	[audioMensajeValidacion] [varchar](50) NULL,
 CONSTRAINT [PK_Validacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CambioEstado]  WITH CHECK ADD  CONSTRAINT [FK_CambioEstado_Estado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[Estado] ([id])
GO
ALTER TABLE [dbo].[CambioEstado] CHECK CONSTRAINT [FK_CambioEstado_Estado]
GO
ALTER TABLE [dbo].[CambioEstado]  WITH CHECK ADD  CONSTRAINT [FK_CambioEstado_Llamada] FOREIGN KEY([idLlamada])
REFERENCES [dbo].[Llamada] ([idLlamada])
GO
ALTER TABLE [dbo].[CambioEstado] CHECK CONSTRAINT [FK_CambioEstado_Llamada]
GO
ALTER TABLE [dbo].[InformacionCliente]  WITH CHECK ADD  CONSTRAINT [FK_InformacionCliente_Validacion] FOREIGN KEY([idInfoCliente])
REFERENCES [dbo].[InformacionCliente] ([idInfoCliente])
GO
ALTER TABLE [dbo].[InformacionCliente] CHECK CONSTRAINT [FK_InformacionCliente_Validacion]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [FK_Llamada_Accion] FOREIGN KEY([idAccion])
REFERENCES [dbo].[Accion] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [FK_Llamada_Accion]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [FK_Llamada_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [FK_Llamada_Cliente]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [FK_Llamada_OpcionLlamada] FOREIGN KEY([idOpcionLlamada])
REFERENCES [dbo].[OpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [FK_Llamada_OpcionLlamada]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [FK_Llamada_SubOpcionLlamada] FOREIGN KEY([idLlamada])
REFERENCES [dbo].[SubOpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [FK_Llamada_SubOpcionLlamada]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [FK_Llamada_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [FK_Llamada_Usuario]
GO
USE [master]
GO
ALTER DATABASE [PPAI] SET  READ_WRITE 
GO

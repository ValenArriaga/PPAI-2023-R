USE [master]
GO
/****** Object:  Database [PPAI]    Script Date: 11/12/2023 2:17:06 PM ******/
CREATE DATABASE [PPAI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PPAI', FILENAME = N'C:\Bases\Data\PPAI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PPAI_log', FILENAME = N'C:\Bases\Logs\PPAI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PPAI] SET COMPATIBILITY_LEVEL = 160
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
ALTER DATABASE [PPAI] SET AUTO_CLOSE OFF 
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
ALTER DATABASE [PPAI] SET RECOVERY FULL 
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
EXEC sys.sp_db_vardecimal_storage_format N'PPAI', N'ON'
GO
ALTER DATABASE [PPAI] SET QUERY_STORE = ON
GO
ALTER DATABASE [PPAI] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PPAI]
GO
/****** Object:  Table [dbo].[Accion]    Script Date: 11/12/2023 2:17:06 PM ******/
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
/****** Object:  Table [dbo].[CambioEstado]    Script Date: 11/12/2023 2:17:06 PM ******/
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
/****** Object:  Table [dbo].[CategoriaLlamada]    Script Date: 11/12/2023 2:17:06 PM ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/12/2023 2:17:06 PM ******/
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
/****** Object:  Table [dbo].[Estado]    Script Date: 11/12/2023 2:17:06 PM ******/
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
/****** Object:  Table [dbo].[InformacionCliente]    Script Date: 11/12/2023 2:17:06 PM ******/
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
	[idCliente] [int] NOT NULL,
 CONSTRAINT [PK_InformacionCliente] PRIMARY KEY CLUSTERED 
(
	[idInfoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Llamada]    Script Date: 11/12/2023 2:17:06 PM ******/
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
	[Estado] [int] NULL,
 CONSTRAINT [PK_Llamada] PRIMARY KEY CLUSTERED 
(
	[idLlamada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OpcionLlamada]    Script Date: 11/12/2023 2:17:06 PM ******/
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
	[idCategoria] [int] NOT NULL,
 CONSTRAINT [PK_OpcionLlamada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OpcionValidacion]    Script Date: 11/12/2023 2:17:06 PM ******/
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
/****** Object:  Table [dbo].[SubOpcionLlamada]    Script Date: 11/12/2023 2:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubOpcionLlamada](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nroOrden] [nchar](10) NULL,
	[nombre] [varchar](50) NULL,
	[idOpcion] [int] NOT NULL,
 CONSTRAINT [PK_SubOpcionLlamada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/12/2023 2:17:06 PM ******/
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
/****** Object:  Table [dbo].[Validacion]    Script Date: 11/12/2023 2:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Validacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nroOrden] [int] NULL,
	[nombre] [varchar](50) NULL,
	[audioMensajeValidacion] [varchar](50) NULL,
	[idOpcion] [int] NOT NULL,
	[idSubopcion] [int] NOT NULL,
 CONSTRAINT [PK_Validacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accion] ON 
GO
INSERT [dbo].[Accion] ([id], [descripcion]) VALUES (1, N'Denunciar un robo')
GO
INSERT [dbo].[Accion] ([id], [descripcion]) VALUES (2, N'Comunicar un saldo')
GO
INSERT [dbo].[Accion] ([id], [descripcion]) VALUES (3, N'Dar de baja una tarjeta')
GO
SET IDENTITY_INSERT [dbo].[Accion] OFF
GO
SET IDENTITY_INSERT [dbo].[CambioEstado] ON 
GO
INSERT [dbo].[CambioEstado] ([id], [fechaHoraInicio], [idLlamada], [idEstado]) VALUES (15, CAST(N'2023-11-12T14:07:04.000' AS DateTime), 14, 1)
GO
INSERT [dbo].[CambioEstado] ([id], [fechaHoraInicio], [idLlamada], [idEstado]) VALUES (16, CAST(N'2023-11-12T14:07:13.000' AS DateTime), 14, 2)
GO
INSERT [dbo].[CambioEstado] ([id], [fechaHoraInicio], [idLlamada], [idEstado]) VALUES (17, CAST(N'2023-11-12T14:08:20.000' AS DateTime), 14, 3)
GO
INSERT [dbo].[CambioEstado] ([id], [fechaHoraInicio], [idLlamada], [idEstado]) VALUES (18, CAST(N'2023-11-12T14:08:53.000' AS DateTime), 15, 1)
GO
INSERT [dbo].[CambioEstado] ([id], [fechaHoraInicio], [idLlamada], [idEstado]) VALUES (19, CAST(N'2023-11-12T14:08:53.000' AS DateTime), 15, 2)
GO
INSERT [dbo].[CambioEstado] ([id], [fechaHoraInicio], [idLlamada], [idEstado]) VALUES (20, CAST(N'2023-11-12T14:10:30.000' AS DateTime), 15, 4)
GO
SET IDENTITY_INSERT [dbo].[CambioEstado] OFF
GO
SET IDENTITY_INSERT [dbo].[CategoriaLlamada] ON 
GO
INSERT [dbo].[CategoriaLlamada] ([id], [nroOrden], [nombre], [audioMensajeOpciones], [mensajeOpciones]) VALUES (1, 1, N'Robo', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[CategoriaLlamada] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 
GO
INSERT [dbo].[Cliente] ([id], [dni], [nombre], [apellido], [nroCelular]) VALUES (1, 123, N'Pedro Jose', N'Crespo', 123)
GO
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Estado] ON 
GO
INSERT [dbo].[Estado] ([id], [nombre]) VALUES (1, N'Iniciada  ')
GO
INSERT [dbo].[Estado] ([id], [nombre]) VALUES (2, N'EnCurso   ')
GO
INSERT [dbo].[Estado] ([id], [nombre]) VALUES (3, N'Finalizada')
GO
INSERT [dbo].[Estado] ([id], [nombre]) VALUES (4, N'Cancelada ')
GO
SET IDENTITY_INSERT [dbo].[Estado] OFF
GO
INSERT [dbo].[InformacionCliente] ([idInfoCliente], [datoAValidar], [idOpcionCorrecta], [idValidacion], [tipo], [idCliente]) VALUES (1, N'Cantidad de hijos', 1, 1, N'cantidad', 1)
GO
INSERT [dbo].[InformacionCliente] ([idInfoCliente], [datoAValidar], [idOpcionCorrecta], [idValidacion], [tipo], [idCliente]) VALUES (2, N'Nombre de mascota', 2, 2, N'nombre', 1)
GO
INSERT [dbo].[InformacionCliente] ([idInfoCliente], [datoAValidar], [idOpcionCorrecta], [idValidacion], [tipo], [idCliente]) VALUES (3, N'Edad', 3, 3, N'cantidad', 1)
GO
SET IDENTITY_INSERT [dbo].[Llamada] ON 
GO
INSERT [dbo].[Llamada] ([idLlamada], [descripcionOperador], [detalleAccionRequerida], [duracion], [encuestaEnviada], [observacionAuditor], [idCliente], [idAccion], [idSubOpcionLlamada], [idOpcionLlamada], [idUsuario], [Estado]) VALUES (14, N'confirmamos                                                                                         ', N'                                                                                                    ', CAST(N'00:01:16.5846770' AS Time), 0, NULL, 1, NULL, 1, 6, 1, 3)
GO
INSERT [dbo].[Llamada] ([idLlamada], [descripcionOperador], [detalleAccionRequerida], [duracion], [encuestaEnviada], [observacionAuditor], [idCliente], [idAccion], [idSubOpcionLlamada], [idOpcionLlamada], [idUsuario], [Estado]) VALUES (15, N'                                                                                                    ', N'                                                                                                    ', CAST(N'00:01:37.3222466' AS Time), 0, NULL, 1, NULL, 1, 7, 1, 4)
GO
SET IDENTITY_INSERT [dbo].[Llamada] OFF
GO
SET IDENTITY_INSERT [dbo].[OpcionLlamada] ON 
GO
INSERT [dbo].[OpcionLlamada] ([id], [nroOrden], [nombre], [audioMensajesSubopciones], [mensajeSubopciones], [idCategoria]) VALUES (1, 1, N'Solicitar nueva tarjeta', NULL, NULL, 1)
GO
INSERT [dbo].[OpcionLlamada] ([id], [nroOrden], [nombre], [audioMensajesSubopciones], [mensajeSubopciones], [idCategoria]) VALUES (5, 2, N'ComunicarseConOperador', NULL, NULL, 1)
GO
INSERT [dbo].[OpcionLlamada] ([id], [nroOrden], [nombre], [audioMensajesSubopciones], [mensajeSubopciones], [idCategoria]) VALUES (6, 3, N'Finalizada', NULL, NULL, 1)
GO
INSERT [dbo].[OpcionLlamada] ([id], [nroOrden], [nombre], [audioMensajesSubopciones], [mensajeSubopciones], [idCategoria]) VALUES (7, 4, N'Cancelada', NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[OpcionLlamada] OFF
GO
INSERT [dbo].[OpcionValidacion] ([idOpcionValidacion], [correcta], [descripcion], [idValidacion]) VALUES (1, N'2', N'2', 1)
GO
INSERT [dbo].[OpcionValidacion] ([idOpcionValidacion], [correcta], [descripcion], [idValidacion]) VALUES (2, N'Ramses', N'Ramses', 2)
GO
INSERT [dbo].[OpcionValidacion] ([idOpcionValidacion], [correcta], [descripcion], [idValidacion]) VALUES (3, N'32', N'32', 3)
GO
SET IDENTITY_INSERT [dbo].[SubOpcionLlamada] ON 
GO
INSERT [dbo].[SubOpcionLlamada] ([id], [nroOrden], [nombre], [idOpcion]) VALUES (1, N'1         ', N'Comunicarse con Operador', 1)
GO
SET IDENTITY_INSERT [dbo].[SubOpcionLlamada] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([id], [activo], [fechaAlta], [nombreUsuario], [password]) VALUES (1, NULL, NULL, N'pjcrespo', NULL)
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Validacion] ON 
GO
INSERT [dbo].[Validacion] ([id], [nroOrden], [nombre], [audioMensajeValidacion], [idOpcion], [idSubopcion]) VALUES (1, 1, N'Cantidad de hijos', NULL, 1, 1)
GO
INSERT [dbo].[Validacion] ([id], [nroOrden], [nombre], [audioMensajeValidacion], [idOpcion], [idSubopcion]) VALUES (2, 2, N'Nombre de mascota', NULL, 1, 1)
GO
INSERT [dbo].[Validacion] ([id], [nroOrden], [nombre], [audioMensajeValidacion], [idOpcion], [idSubopcion]) VALUES (3, 3, N'Edad', NULL, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Validacion] OFF
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
ALTER TABLE [dbo].[InformacionCliente]  WITH CHECK ADD  CONSTRAINT [fk_informacion_opcionValidacion] FOREIGN KEY([idOpcionCorrecta])
REFERENCES [dbo].[OpcionValidacion] ([idOpcionValidacion])
GO
ALTER TABLE [dbo].[InformacionCliente] CHECK CONSTRAINT [fk_informacion_opcionValidacion]
GO
ALTER TABLE [dbo].[InformacionCliente]  WITH CHECK ADD  CONSTRAINT [fk_informacionCliente_cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[InformacionCliente] CHECK CONSTRAINT [fk_informacionCliente_cliente]
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
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [fk_llamada_estado] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [fk_llamada_estado]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [FK_Llamada_OpcionLlamada] FOREIGN KEY([idOpcionLlamada])
REFERENCES [dbo].[OpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [FK_Llamada_OpcionLlamada]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [fk_llamada_subopcion] FOREIGN KEY([idSubOpcionLlamada])
REFERENCES [dbo].[SubOpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [fk_llamada_subopcion]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [FK_Llamada_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [FK_Llamada_Usuario]
GO
ALTER TABLE [dbo].[OpcionLlamada]  WITH CHECK ADD  CONSTRAINT [fk_opcion_categoria] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[CategoriaLlamada] ([id])
GO
ALTER TABLE [dbo].[OpcionLlamada] CHECK CONSTRAINT [fk_opcion_categoria]
GO
ALTER TABLE [dbo].[OpcionValidacion]  WITH CHECK ADD  CONSTRAINT [fk_opcionValidacion_validacion] FOREIGN KEY([idValidacion])
REFERENCES [dbo].[Validacion] ([id])
GO
ALTER TABLE [dbo].[OpcionValidacion] CHECK CONSTRAINT [fk_opcionValidacion_validacion]
GO
ALTER TABLE [dbo].[SubOpcionLlamada]  WITH CHECK ADD  CONSTRAINT [fk_subopcion_opcion] FOREIGN KEY([idOpcion])
REFERENCES [dbo].[OpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[SubOpcionLlamada] CHECK CONSTRAINT [fk_subopcion_opcion]
GO
ALTER TABLE [dbo].[Validacion]  WITH CHECK ADD  CONSTRAINT [fk_validacion_opcion] FOREIGN KEY([idOpcion])
REFERENCES [dbo].[OpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[Validacion] CHECK CONSTRAINT [fk_validacion_opcion]
GO
ALTER TABLE [dbo].[Validacion]  WITH CHECK ADD  CONSTRAINT [fk_validacion_subopcion] FOREIGN KEY([idSubopcion])
REFERENCES [dbo].[SubOpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[Validacion] CHECK CONSTRAINT [fk_validacion_subopcion]
GO
USE [master]
GO
ALTER DATABASE [PPAI] SET  READ_WRITE 
GO

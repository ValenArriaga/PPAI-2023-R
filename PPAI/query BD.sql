USE [PPAI]
GO
/****** Object:  Table [dbo].[Accion]    Script Date: 22/5/2023 21:09:53 ******/
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
/****** Object:  Table [dbo].[CambioEstado]    Script Date: 22/5/2023 21:09:53 ******/
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
/****** Object:  Table [dbo].[CategoriaLlamada]    Script Date: 22/5/2023 21:09:53 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 22/5/2023 21:09:53 ******/
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
/****** Object:  Table [dbo].[Estado]    Script Date: 22/5/2023 21:09:53 ******/
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
/****** Object:  Table [dbo].[InformacionCliente]    Script Date: 22/5/2023 21:09:53 ******/
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
/****** Object:  Table [dbo].[Llamada]    Script Date: 22/5/2023 21:09:53 ******/
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
/****** Object:  Table [dbo].[OpcionLlamada]    Script Date: 22/5/2023 21:09:53 ******/
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
/****** Object:  Table [dbo].[OpcionValidacion]    Script Date: 22/5/2023 21:09:53 ******/
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
/****** Object:  Table [dbo].[SubOpcionLlamada]    Script Date: 22/5/2023 21:09:53 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/5/2023 21:09:53 ******/
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
/****** Object:  Table [dbo].[Validacion]    Script Date: 22/5/2023 21:09:53 ******/
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

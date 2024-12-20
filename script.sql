USE [master]
GO
/****** Object:  Database [cursos]    Script Date: 30/11/2024 18:59:08 ******/
CREATE DATABASE [cursos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cursos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\cursos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cursos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\cursos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cursos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cursos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cursos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cursos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cursos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cursos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cursos] SET ARITHABORT OFF 
GO
ALTER DATABASE [cursos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cursos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cursos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cursos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cursos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cursos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cursos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cursos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cursos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cursos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cursos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cursos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cursos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cursos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cursos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cursos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cursos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cursos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [cursos] SET  MULTI_USER 
GO
ALTER DATABASE [cursos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cursos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cursos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cursos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cursos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cursos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [cursos] SET QUERY_STORE = OFF
GO
USE [cursos]
GO
/****** Object:  Table [dbo].[alumnos]    Script Date: 30/11/2024 18:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumnos](
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[fecha_nacimiento] [datetime] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_alumnos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[alumnos_por_curso]    Script Date: 30/11/2024 18:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumnos_por_curso](
	[alumno_id] [int] NOT NULL,
	[curso_id] [int] NOT NULL,
	[beca] [nvarchar](50) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_alumnos_por_curso] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cursos]    Script Date: 30/11/2024 18:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cursos](
	[nombre] [nvarchar](50) NOT NULL,
	[fecha_limite] [datetime] NOT NULL,
	[cupo] [int] NOT NULL,
	[costo] [float] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_cursos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[alumnos_por_curso]  WITH CHECK ADD  CONSTRAINT [FK_alumnos_por_curso_alumnos] FOREIGN KEY([alumno_id])
REFERENCES [dbo].[alumnos] ([id])
GO
ALTER TABLE [dbo].[alumnos_por_curso] CHECK CONSTRAINT [FK_alumnos_por_curso_alumnos]
GO
ALTER TABLE [dbo].[alumnos_por_curso]  WITH CHECK ADD  CONSTRAINT [FK_alumnos_por_curso_cursos] FOREIGN KEY([curso_id])
REFERENCES [dbo].[cursos] ([id])
GO
ALTER TABLE [dbo].[alumnos_por_curso] CHECK CONSTRAINT [FK_alumnos_por_curso_cursos]
GO
/****** Object:  StoredProcedure [dbo].[alta_alumno]    Script Date: 30/11/2024 18:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[alta_alumno]
	@nombre nvarchar(50),
	@apellido nvarchar(50),
	@fecha_nacimiento datetime
AS
BEGIN
	begin transaction
	insert into alumnos (nombre, apellido, fecha_nacimiento) values (@nombre, @apellido, @fecha_nacimiento)
	commit
END
GO
/****** Object:  StoredProcedure [dbo].[alta_curso]    Script Date: 30/11/2024 18:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[alta_curso]
	@nombre nvarchar(50),
	@cupo int,
	@fecha_limite datetime,
	@costo float
AS
BEGIN
	begin transaction
	insert into cursos (nombre, cupo, fecha_limite, costo) values (@nombre, @cupo, @fecha_limite, @costo)
	commit
END
GO
/****** Object:  StoredProcedure [dbo].[baja_alumno]    Script Date: 30/11/2024 18:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[baja_alumno]
	@id int
AS
BEGIN
	begin transaction
	delete from alumnos_por_curso where alumno_id = @id;
	delete from alumnos where id = @id;
	commit
END
GO
/****** Object:  StoredProcedure [dbo].[modificar_alumno]    Script Date: 30/11/2024 18:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[modificar_alumno]
	@id int,
	@nombre nvarchar(50),
	@apellido nvarchar(50),
	@fecha_nacimiento datetime
AS
BEGIN
	begin transaction
	update alumnos 
	set nombre = @nombre, apellido = @apellido, fecha_nacimiento = @fecha_nacimiento
	where id = @id
	commit
END
GO
/****** Object:  StoredProcedure [dbo].[recaudacion_por_curso]    Script Date: 30/11/2024 18:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[recaudacion_por_curso]
AS
BEGIN
	select c.nombre, (count(apc.alumno_id) * c.costo) as total
	from cursos c
	left join alumnos_por_curso apc on apc.curso_id = c.id 
	group by c.nombre, c.id, c.costo
END
GO
/****** Object:  StoredProcedure [dbo].[total_alumnos_por_curso]    Script Date: 30/11/2024 18:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[total_alumnos_por_curso]
AS
BEGIN
	select c.nombre, (count(apc.alumno_id) ) as total
	from cursos c
	left join alumnos_por_curso apc on apc.curso_id = c.id 
	group by c.nombre, c.id, c.costo
END

GO
USE [master]
GO
ALTER DATABASE [cursos] SET  READ_WRITE 
GO

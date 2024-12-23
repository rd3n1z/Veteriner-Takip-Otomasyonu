USE [master]
GO
/****** Object:  Database [veterinerdb]    Script Date: 23.12.2024 17:27:19 ******/
CREATE DATABASE [veterinerdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'veterinerdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\veterinerdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'veterinerdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\veterinerdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [veterinerdb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [veterinerdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [veterinerdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [veterinerdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [veterinerdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [veterinerdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [veterinerdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [veterinerdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [veterinerdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [veterinerdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [veterinerdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [veterinerdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [veterinerdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [veterinerdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [veterinerdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [veterinerdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [veterinerdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [veterinerdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [veterinerdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [veterinerdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [veterinerdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [veterinerdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [veterinerdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [veterinerdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [veterinerdb] SET RECOVERY FULL 
GO
ALTER DATABASE [veterinerdb] SET  MULTI_USER 
GO
ALTER DATABASE [veterinerdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [veterinerdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [veterinerdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [veterinerdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [veterinerdb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [veterinerdb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'veterinerdb', N'ON'
GO
ALTER DATABASE [veterinerdb] SET QUERY_STORE = ON
GO
ALTER DATABASE [veterinerdb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [veterinerdb]
GO
/****** Object:  Table [dbo].[Asilar]    Script Date: 23.12.2024 17:27:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asilar](
	[AsiId] [int] IDENTITY(1,1) NOT NULL,
	[AsiAdi] [nvarchar](100) NOT NULL,
	[tarih] [date] NOT NULL,
	[petid] [int] NOT NULL,
 CONSTRAINT [PK__Asilar__42AA3E46D85943AB] PRIMARY KEY CLUSTERED 
(
	[AsiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EvcilHayvanlarTablosu]    Script Date: 23.12.2024 17:27:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EvcilHayvanlarTablosu](
	[petid] [int] IDENTITY(1,1) NOT NULL,
	[hayvanAdi] [nvarchar](max) NOT NULL,
	[turu] [nvarchar](max) NOT NULL,
	[cinsiyet] [nvarchar](max) NOT NULL,
	[yas] [int] NOT NULL,
	[sahipUserId] [int] NOT NULL,
	[avatarTuru] [nvarchar](max) NOT NULL,
	[hayvanFoto] [nvarchar](max) NULL,
 CONSTRAINT [PK_EvcilHayvanlarTablosu] PRIMARY KEY CLUSTERED 
(
	[petid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FaturaDetaylari]    Script Date: 23.12.2024 17:27:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FaturaDetaylari](
	[FaturaDetayID] [int] IDENTITY(1,1) NOT NULL,
	[FaturaID] [int] NULL,
	[UrunID] [int] NULL,
	[Miktar] [int] NULL,
	[Fiyat] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[FaturaDetayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[faturalar]    Script Date: 23.12.2024 17:27:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[faturalar](
	[faturaId] [int] IDENTITY(1,1) NOT NULL,
	[userid] [int] NOT NULL,
	[toplamtutar] [decimal](18, 0) NOT NULL,
	[tarih] [date] NOT NULL,
 CONSTRAINT [PK_faturalar] PRIMARY KEY CLUSTERED 
(
	[faturaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanici_giris]    Script Date: 23.12.2024 17:27:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici_giris](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nchar](50) NOT NULL,
	[soyad] [nchar](50) NOT NULL,
	[kullanici_adi] [nvarchar](max) NOT NULL,
	[kullanici_sifre] [nvarchar](max) NOT NULL,
	[email] [nvarchar](max) NOT NULL,
	[rol] [nvarchar](50) NOT NULL,
	[cinsiyet] [nchar](10) NULL,
 CONSTRAINT [PK_kullanici_giris] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[randevular]    Script Date: 23.12.2024 17:27:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[randevular](
	[randevuId] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciId] [int] NOT NULL,
	[petid] [int] NOT NULL,
	[tarih] [date] NOT NULL,
	[saat] [time](7) NOT NULL,
	[durum] [nchar](25) NOT NULL,
	[randevuTur] [nvarchar](100) NOT NULL,
	[AsiMi] [bit] NOT NULL,
 CONSTRAINT [PK_randevular] PRIMARY KEY CLUSTERED 
(
	[randevuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urunler]    Script Date: 23.12.2024 17:27:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urunler](
	[urunid] [int] IDENTITY(1,1) NOT NULL,
	[urunadi] [nvarchar](max) NOT NULL,
	[fiyat] [decimal](18, 0) NOT NULL,
	[stok] [int] NOT NULL,
	[Foto] [nvarchar](max) NULL,
 CONSTRAINT [PK_urunler] PRIMARY KEY CLUSTERED 
(
	[urunid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[randevular] ADD  DEFAULT ((0)) FOR [AsiMi]
GO
ALTER TABLE [dbo].[Asilar]  WITH CHECK ADD  CONSTRAINT [asilar_randevular_durum] FOREIGN KEY([AsiId])
REFERENCES [dbo].[Asilar] ([AsiId])
GO
ALTER TABLE [dbo].[Asilar] CHECK CONSTRAINT [asilar_randevular_durum]
GO
ALTER TABLE [dbo].[Asilar]  WITH CHECK ADD  CONSTRAINT [evcilhayvanlar_asilar_petid] FOREIGN KEY([petid])
REFERENCES [dbo].[EvcilHayvanlarTablosu] ([petid])
GO
ALTER TABLE [dbo].[Asilar] CHECK CONSTRAINT [evcilhayvanlar_asilar_petid]
GO
ALTER TABLE [dbo].[EvcilHayvanlarTablosu]  WITH CHECK ADD  CONSTRAINT [evcilhayvanlartablosu_kullanici_giris_sahipuser_userid] FOREIGN KEY([sahipUserId])
REFERENCES [dbo].[kullanici_giris] ([userid])
GO
ALTER TABLE [dbo].[EvcilHayvanlarTablosu] CHECK CONSTRAINT [evcilhayvanlartablosu_kullanici_giris_sahipuser_userid]
GO
ALTER TABLE [dbo].[randevular]  WITH CHECK ADD  CONSTRAINT [randevu_kullanici_giris_kullaniciId_userId] FOREIGN KEY([kullaniciId])
REFERENCES [dbo].[kullanici_giris] ([userid])
GO
ALTER TABLE [dbo].[randevular] CHECK CONSTRAINT [randevu_kullanici_giris_kullaniciId_userId]
GO
ALTER TABLE [dbo].[randevular]  WITH CHECK ADD  CONSTRAINT [randevular_evcilhyvanlar_petid_petid] FOREIGN KEY([petid])
REFERENCES [dbo].[EvcilHayvanlarTablosu] ([petid])
GO
ALTER TABLE [dbo].[randevular] CHECK CONSTRAINT [randevular_evcilhyvanlar_petid_petid]
GO
ALTER TABLE [dbo].[urunler]  WITH CHECK ADD  CONSTRAINT [FK_urunler_urunler] FOREIGN KEY([urunid])
REFERENCES [dbo].[urunler] ([urunid])
GO
ALTER TABLE [dbo].[urunler] CHECK CONSTRAINT [FK_urunler_urunler]
GO
USE [master]
GO
ALTER DATABASE [veterinerdb] SET  READ_WRITE 
GO

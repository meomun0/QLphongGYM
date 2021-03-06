USE [master]
GO
/****** Object:  Database [GYM]    Script Date: 5/25/2018 12:29:19 AM ******/
CREATE DATABASE [GYM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GYM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GYM.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GYM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GYM_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GYM] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GYM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GYM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GYM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GYM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GYM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GYM] SET ARITHABORT OFF 
GO
ALTER DATABASE [GYM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GYM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GYM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GYM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GYM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GYM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GYM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GYM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GYM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GYM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GYM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GYM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GYM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GYM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GYM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GYM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GYM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GYM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GYM] SET  MULTI_USER 
GO
ALTER DATABASE [GYM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GYM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GYM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GYM] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [GYM] SET DELAYED_DURABILITY = DISABLED 
GO
USE [GYM]
GO
/****** Object:  Table [dbo].[CHI]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHI](
	[Mã chi] [varchar](10) NOT NULL,
	[Số tiền] [money] NULL,
	[Thời gian] [datetime] NULL,
	[Nội dung] [nvarchar](100) NULL,
	[Người thực hiện] [varchar](12) NULL,
	[IsDel] [bit] NULL,
 CONSTRAINT [PK_CHI] PRIMARY KEY CLUSTERED 
(
	[Mã chi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DUNGCU]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DUNGCU](
	[Mã dụng cụ] [varchar](10) NOT NULL,
	[Tên] [nvarchar](50) NULL,
	[Giá] [money] NULL,
	[Tình trạng] [nvarchar](50) NULL,
	[Ngày mua] [date] NULL,
	[NgaySD] [date] NULL,
	[KhuVucSD] [nvarchar](50) NULL,
	[IsDel] [bit] NULL,
 CONSTRAINT [PK_DUNGCU_HLV_QLy_1] PRIMARY KEY CLUSTERED 
(
	[Mã dụng cụ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GÓI TẬP]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GÓI TẬP](
	[Mã gói tập] [varchar](12) NOT NULL,
	[Tên gói tập] [nvarchar](50) NOT NULL,
	[Giá] [money] NULL,
	[Ngày bắt đầu] [date] NULL,
	[Ngày kết thúc] [date] NULL,
	[Buổi] [nvarchar](50) NULL,
	[Ca] [nvarchar](50) NULL,
	[KhuVucTap] [nvarchar](50) NULL,
	[Số người ĐK] [int] NULL,
	[IsDel] [bit] NULL,
 CONSTRAINT [PK_GÓI TẬP] PRIMARY KEY CLUSTERED 
(
	[Mã gói tập] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHÁCH]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHÁCH](
	[Mã khách] [varchar](12) NOT NULL,
	[Họ tên] [nvarchar](30) NULL,
	[GT] [nchar](3) NULL,
	[NS] [date] NULL,
	[Số điện thoại] [varchar](11) NOT NULL,
	[Địa chỉ] [nvarchar](50) NULL,
	[Ngày đăng ký] [date] NULL,
	[HanThe] [date] NULL,
	[IsDel] [bit] NULL,
 CONSTRAINT [PK_KHÁCH] PRIMARY KEY CLUSTERED 
(
	[Mã khách] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACH_GOI]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACH_GOI](
	[Mã khách hàng] [varchar](12) NOT NULL,
	[Mã gói tập] [varchar](12) NOT NULL,
	[Ngày BĐ] [date] NULL,
	[Ngày KT] [date] NULL,
	[HLV] [nvarchar](max) NULL,
	[ThanhToan(Y/N)] [bit] NULL,
 CONSTRAINT [PK_KHACH_GOI] PRIMARY KEY CLUSTERED 
(
	[Mã khách hàng] ASC,
	[Mã gói tập] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LSuGiaHan]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LSuGiaHan](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[MaKhach] [varchar](12) NULL,
	[TenKhach] [nvarchar](30) NULL,
	[TGĐK] [date] NULL,
	[HanTruoc] [date] NULL,
	[HanSau] [date] NULL,
	[check] [bit] NULL,
 CONSTRAINT [PK_expirationHistory] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[Mã NV] [varchar](12) NOT NULL,
	[Tên] [nvarchar](50) NULL,
	[NS] [date] NULL,
	[GT] [nchar](3) NULL,
	[Số điện thoại] [varchar](11) NULL,
	[Chức vụ] [nvarchar](30) NULL,
	[Ca làm] [nvarchar](50) NULL,
	[Ngày BĐ] [date] NULL,
	[Lương] [money] NULL,
	[Quê quán] [nvarchar](50) NULL,
	[IsDel] [bit] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[Mã NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHÂN CÔNG]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHÂN CÔNG](
	[Mã HLV] [varchar](12) NOT NULL,
	[Mã gói tập] [varchar](12) NOT NULL,
	[Tên gói tập] [nvarchar](50) NULL,
	[Tên HLV] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHÁCH_GÓI] PRIMARY KEY CLUSTERED 
(
	[Mã HLV] ASC,
	[Mã gói tập] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBi_GoiTap]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBi_GoiTap](
	[Mã gói] [varchar](12) NOT NULL,
	[Mã thiết bị] [varchar](10) NOT NULL,
	[TenGoi] [nvarchar](50) NULL,
	[TenThietBi] [nvarchar](50) NULL,
 CONSTRAINT [PK_TBi_GoiTap] PRIMARY KEY CLUSTERED 
(
	[Mã gói] ASC,
	[Mã thiết bị] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THU]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THU](
	[Mã thu] [varchar](23) NOT NULL,
	[Mã khách] [varchar](12) NULL,
	[Tên gói] [varchar](12) NULL,
	[Số lượng tiền] [money] NULL,
	[Thời gian] [smalldatetime] NULL,
	[Mô tả] [nvarchar](100) NULL,
	[Người duyệt] [varchar](13) NOT NULL,
	[IsDel] [bit] NULL,
 CONSTRAINT [PK_THU CHI_1] PRIMARY KEY CLUSTERED 
(
	[Mã thu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Privilege] [nvarchar](50) NOT NULL,
	[ID] [varchar](12) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[LICH_HLV]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LICH_HLV] AS SELECT temp.*,nv.[Ca làm] 
FROM dbo.NHANVIEN AS nv,
	(SELECT b.[Mã HLV],b.[Mã gói tập],a.Buổi,a.Ca 
	FROM dbo.[GÓI TẬP] AS a,dbo.[PHÂN CÔNG] AS b
	WHERE GETDATE()<a.[Ngày kết thúc] AND a.[Mã gói tập]=b.[Mã gói tập]) AS temp
WHERE nv.[Mã NV]=temp.[Mã HLV]
GO
/****** Object:  View [dbo].[LICH_KHACH]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LICH_KHACH] AS
SELECT dbo.KHACH_GOI.*,[Ngày bắt đầu],[Ngày kết thúc],Buổi,Ca
FROM dbo.KHACH_GOI,
	(SELECT * FROM dbo.[GÓI TẬP] WHERE [Ngày kết thúc]>= CAST(GETDATE() AS DATE)) AS b
WHERE b.[Mã gói tập]=KHACH_GOI.[Mã gói tập]
GO
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160000', -100000.0000, CAST(N'2018-05-15 21:46:07.017' AS DateTime), N'Mua dụng cụ Tạ 10kg', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160001', -100000.0000, CAST(N'2018-05-15 21:46:07.017' AS DateTime), N'Mua dụng cụ Tạ 10kg', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160002', -100000.0000, CAST(N'2018-05-15 21:46:07.017' AS DateTime), N'Mua dụng cụ Tạ 10kg', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160003', -100000.0000, CAST(N'2018-05-15 21:46:07.020' AS DateTime), N'Mua dụng cụ Tạ 10kg', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160004', -100000.0000, CAST(N'2018-05-15 21:46:07.020' AS DateTime), N'Mua dụng cụ Tạ 10kg', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160005', -100000.0000, CAST(N'2018-05-15 21:46:07.020' AS DateTime), N'Mua dụng cụ Tạ 10kg', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160006', -12000000.0000, CAST(N'2018-05-15 21:46:07.020' AS DateTime), N'Mua dụng cụ Máy tập cơ', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160007', -12000000.0000, CAST(N'2018-05-15 21:46:07.020' AS DateTime), N'Mua dụng cụ Máy tập cơ', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160008', -10000000.0000, CAST(N'2018-05-15 21:46:07.020' AS DateTime), N'Mua dụng cụ Xe đạp', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160009', -10000000.0000, CAST(N'2018-05-15 21:46:07.023' AS DateTime), N'Mua dụng cụ Xe đạp', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160010', -5000000.0000, CAST(N'2018-05-15 21:46:07.023' AS DateTime), N'Mua dụng cụ Ghế đa năng', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160011', -5000000.0000, CAST(N'2018-05-15 21:46:07.023' AS DateTime), N'Mua dụng cụ Ghế đa năng', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160012', -5000000.0000, CAST(N'2018-05-15 21:46:07.023' AS DateTime), N'Mua dụng cụ Ghế đa năng', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160013', -5000000.0000, CAST(N'2018-05-15 21:46:07.023' AS DateTime), N'Mua dụng cụ Ghế đa năng', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160014', -25000000.0000, CAST(N'2018-05-15 21:46:07.027' AS DateTime), N'Mua dụng cụ Máy chạy bộ', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160015', -25000000.0000, CAST(N'2018-05-15 21:46:07.027' AS DateTime), N'Mua dụng cụ Máy chạy bộ', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160016', -25000000.0000, CAST(N'2018-05-15 21:46:07.027' AS DateTime), N'Mua dụng cụ Máy chạy bộ', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160017', -100000.0000, CAST(N'2018-05-15 21:46:07.030' AS DateTime), N'Mua dụng cụ Tạ 10 Kg', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'DC_160018', -100000.0000, CAST(N'2018-05-24 12:20:52.857' AS DateTime), N'Mua dụng cụ Tạ 10Kg', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'M_170000', -1000000.0000, CAST(N'2018-05-24 09:39:00.013' AS DateTime), N'Tiền điện tháng 5/2018', N'NV_144711', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'P1001', 0.0000, CAST(N'2018-05-15 21:46:07.030' AS DateTime), N'Mua dụng cụ Phòng tập chung', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'P1002', 0.0000, CAST(N'2018-05-15 21:46:07.030' AS DateTime), N'Mua dụng cụ Phòng tập riêng', N'NV_144706', 0)
INSERT [dbo].[CHI] ([Mã chi], [Số tiền], [Thời gian], [Nội dung], [Người thực hiện], [IsDel]) VALUES (N'P1003', 0.0000, CAST(N'2018-05-15 21:46:07.030' AS DateTime), N'Mua dụng cụ Phòng tập dáng', N'NV_144706', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160000', N'Tạ 10kg', 100000.0000, N'Đang sử dụng', CAST(N'2018-05-14' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160001', N'Tạ 10kg', 100000.0000, N'Đang sử dụng', CAST(N'2018-05-14' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160002', N'Tạ 10kg', 100000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160003', N'Tạ 10kg', 100000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160004', N'Tạ 10kg', 100000.0000, N'Sửa chữa', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Trong kho', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160005', N'Tạ 10kg', 100000.0000, N'Hỏng hóc', CAST(N'2017-10-20' AS Date), CAST(N'2018-05-14' AS Date), N'Trong kho', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160006', N'Máy tập cơ', 12000000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Private studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160007', N'Máy tập cơ', 12000000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160008', N'Xe đạp', 10000000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Private studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160009', N'Xe đạp', 10000000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160010', N'Ghế đa năng', 5000000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Private studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160011', N'Ghế đa năng', 5000000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160012', N'Ghế đa năng', 5000000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160013', N'Ghế đa năng', 5000000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160014', N'Máy chạy bộ', 25000000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Private studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160015', N'Máy chạy bộ', 25000000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160016', N'Máy chạy bộ', 25000000.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160017', N'Tạ 10 Kg', 100000.0000, N'Dự trữ', CAST(N'2018-05-15' AS Date), CAST(N'2018-05-15' AS Date), N'Private studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'DC_160018', N'Tạ 10Kg', 100000.0000, N'Dự trữ', CAST(N'2018-05-24' AS Date), NULL, N'Trong kho', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'P1001', N'Phòng tập chung', 0.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Public studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'P1002', N'Phòng tập riêng', 0.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Private studio', 0)
INSERT [dbo].[DUNGCU] ([Mã dụng cụ], [Tên], [Giá], [Tình trạng], [Ngày mua], [NgaySD], [KhuVucSD], [IsDel]) VALUES (N'P1003', N'Phòng tập dáng', 0.0000, N'Đang sử dụng', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-14' AS Date), N'Body and Mind studio', 0)
INSERT [dbo].[GÓI TẬP] ([Mã gói tập], [Tên gói tập], [Giá], [Ngày bắt đầu], [Ngày kết thúc], [Buổi], [Ca], [KhuVucTap], [Số người ĐK], [IsDel]) VALUES (N'Aerobic_1', N'Aerobic', 1850000.0000, CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'T2 T3 T4 T5 T6 T7 CN ', N'Sáng', N'Body and Mind studio', 7, 0)
INSERT [dbo].[GÓI TẬP] ([Mã gói tập], [Tên gói tập], [Giá], [Ngày bắt đầu], [Ngày kết thúc], [Buổi], [Ca], [KhuVucTap], [Số người ĐK], [IsDel]) VALUES (N'Aerobic_2', N'Aerobic', 1850000.0000, CAST(N'2018-05-01' AS Date), CAST(N'2018-07-01' AS Date), N'T2 T3 T4 T5 T6 T7 CN ', N'Sáng', N'Body and Mind studio', 1, 0)
INSERT [dbo].[GÓI TẬP] ([Mã gói tập], [Tên gói tập], [Giá], [Ngày bắt đầu], [Ngày kết thúc], [Buổi], [Ca], [KhuVucTap], [Số người ĐK], [IsDel]) VALUES (N'GYM_R1', N'KEM RIENG', 1500000.0000, CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'T2 T4 T6 ', N'Tối', N'Private studio', 1, 0)
INSERT [dbo].[GÓI TẬP] ([Mã gói tập], [Tên gói tập], [Giá], [Ngày bắt đầu], [Ngày kết thúc], [Buổi], [Ca], [KhuVucTap], [Số người ĐK], [IsDel]) VALUES (N'GYM_R2', N'KEM RIENG', 1500000.0000, CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'T7 CN ', N'Không giới hạn', N'Private studio', 1, 0)
INSERT [dbo].[GÓI TẬP] ([Mã gói tập], [Tên gói tập], [Giá], [Ngày bắt đầu], [Ngày kết thúc], [Buổi], [Ca], [KhuVucTap], [Số người ĐK], [IsDel]) VALUES (N'GYM_R3', N'KEM RIENG', 1500000.0000, CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'T3 T5 T7 ', N'Tối', N'Private studio', 1, 0)
INSERT [dbo].[GÓI TẬP] ([Mã gói tập], [Tên gói tập], [Giá], [Ngày bắt đầu], [Ngày kết thúc], [Buổi], [Ca], [KhuVucTap], [Số người ĐK], [IsDel]) VALUES (N'GYM_T1', N'Lớp thường', 2000000.0000, CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'T2 T3 T4 T5 T6 T7 CN ', N'Chiều', N'Private studio', 2, 0)
INSERT [dbo].[GÓI TẬP] ([Mã gói tập], [Tên gói tập], [Giá], [Ngày bắt đầu], [Ngày kết thúc], [Buổi], [Ca], [KhuVucTap], [Số người ĐK], [IsDel]) VALUES (N'GYM_T2', N'Lớp thường', 1500000.0000, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-30' AS Date), N'T2 T3 T4 T5 T6 ', N'Sáng', N'Private studio', 0, 0)
INSERT [dbo].[GÓI TẬP] ([Mã gói tập], [Tên gói tập], [Giá], [Ngày bắt đầu], [Ngày kết thúc], [Buổi], [Ca], [KhuVucTap], [Số người ĐK], [IsDel]) VALUES (N'GYM_V1', N'Lớp VIP', 1500000.0000, CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'T2 T3 T4 T5 T6 T7 CN ', N'Không giới hạn', N'Private studio', 3, 0)
INSERT [dbo].[GÓI TẬP] ([Mã gói tập], [Tên gói tập], [Giá], [Ngày bắt đầu], [Ngày kết thúc], [Buổi], [Ca], [KhuVucTap], [Số người ĐK], [IsDel]) VALUES (N'GYM_Z1', N'Zumba', 2000000.0000, CAST(N'2018-04-08' AS Date), CAST(N'2018-07-08' AS Date), N'T2 T3 T4 T5 T6 T7 CN ', N'Chiều', N'Body and Mind studio', 1, 0)
INSERT [dbo].[GÓI TẬP] ([Mã gói tập], [Tên gói tập], [Giá], [Ngày bắt đầu], [Ngày kết thúc], [Buổi], [Ca], [KhuVucTap], [Số người ĐK], [IsDel]) VALUES (N'GYM_Z2', N'Zumba', 2000000.0000, CAST(N'2018-07-09' AS Date), CAST(N'2018-10-09' AS Date), N'T2 T3 T4 T5 T6 T7 CN ', N'Tối', N'Body and Mind studio', 1, 0)
INSERT [dbo].[GÓI TẬP] ([Mã gói tập], [Tên gói tập], [Giá], [Ngày bắt đầu], [Ngày kết thúc], [Buổi], [Ca], [KhuVucTap], [Số người ĐK], [IsDel]) VALUES (N'Yoga_1', N'Yoga', 1990000.0000, CAST(N'2018-06-01' AS Date), CAST(N'2018-08-01' AS Date), N'T2 T3 T4 T5 T6 T7 CN ', N'Chiều', N'Body and Mind studio', 2, 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150000', N'Tuấn Anhh', N'Nam', CAST(N'1996-01-01' AS Date), N'0989898989 ', N'Hà Nội', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150001', N'Vân Anh', N'Nữ ', CAST(N'1997-01-23' AS Date), N'0988889999 ', N'Hải Phòng', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150002', N'Mai Duyên', N'Nữ ', CAST(N'1997-02-15' AS Date), N'0987726388 ', N'Hà Nam', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150003', N'Đình Dũng', N'nam', CAST(N'1997-09-01' AS Date), N'0989263762 ', N'Hà Nội', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150004', N'Quốc Tuấn', N'nam', CAST(N'1997-11-04' AS Date), N'0973452931 ', N'Hà Nội', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150005', N'Hồng Liên', N'nữ ', CAST(N'1997-07-01' AS Date), N'01654821221', N'Nam Định', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150006', N'Lê Tùng', N'nam', CAST(N'1993-01-01' AS Date), N'01689500363', N'Thái Bình', CAST(N'2017-10-11' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150007', N'Bùi Hoàng', N'nam', CAST(N'1997-01-05' AS Date), N'0840888888 ', N'Bắc Giang', CAST(N'2017-10-11' AS Date), CAST(N'2018-07-08' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150008', N'Linh Nguyễn', N'nữ ', CAST(N'1997-06-01' AS Date), N'0937288998 ', N'Hà Nội', CAST(N'2017-10-12' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150009', N'Trần Kim Anh', N'Nữ ', CAST(N'1992-03-01' AS Date), N'0923453687', N'Hà Nội', CAST(N'2017-10-12' AS Date), CAST(N'2018-07-08' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150010', N'Nguyễn An', N'Nam', CAST(N'1997-11-01' AS Date), N'0934638932 ', N'Thái Nguyên', CAST(N'2017-10-12' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150011', N'Giang Hải', N'Nam', CAST(N'1997-06-17' AS Date), N'0965186738 ', N'Hà Nội', CAST(N'2017-10-10' AS Date), CAST(N'2018-08-01' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150012', N'Quỳnh Anh', N'Nữ ', CAST(N'2000-01-01' AS Date), N'01685081146', N'Hà Nội', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150013', N'Trương Hải', N'Nam', CAST(N'1997-02-15' AS Date), N'0967125182 ', N'Thanh Hoá', CAST(N'2018-02-05' AS Date), CAST(N'2018-08-31' AS Date), 0)
INSERT [dbo].[KHÁCH] ([Mã khách], [Họ tên], [GT], [NS], [Số điện thoại], [Địa chỉ], [Ngày đăng ký], [HanThe], [IsDel]) VALUES (N'KH_150014', N'Tester', N'Nam', CAST(N'1997-05-30' AS Date), N'0983423424', N'Hà Nội', CAST(N'2018-05-13' AS Date), CAST(N'2018-10-09' AS Date), 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150000', N'GYM_T1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Dương Dũng; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150001', N'Aerobic_1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Nguyễn Anh; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150002', N'Aerobic_1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Nguyễn Anh; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150003', N'GYM_V1    ', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Bùi Tuấn; Bá Nghĩa; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150004', N'GYM_R3    ', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Hà Huy; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150005', N'Aerobic_1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Nguyễn Anh; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150006', N'Aerobic_1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Nguyễn Anh; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150007', N'GYM_Z1', CAST(N'2018-04-08' AS Date), CAST(N'2018-07-08' AS Date), N'Nguyễn Anh; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150010', N'GYM_T1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Dương Dũng; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150011', N'Aerobic_1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Nguyễn Anh; ', 1)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150011', N'GYM_V1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Bùi Tuấn; Bá Nghĩa; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150011', N'Yoga_1', CAST(N'2018-06-01' AS Date), CAST(N'2018-08-01' AS Date), N'Nguyễn Anh; Tester; ', 1)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150012', N'Aerobic_1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Nguyễn Anh; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150012', N'GYM_R1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Hà Huy; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150014', N'Aerobic_1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Nguyễn Anh; ', 1)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150014', N'GYM_R2    ', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Bùi Tuấn; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150014', N'GYM_V1', CAST(N'2018-03-01' AS Date), CAST(N'2018-04-28' AS Date), N'Bùi Tuấn; Bá Nghĩa; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150014', N'GYM_Z2', CAST(N'2018-07-09' AS Date), CAST(N'2018-10-09' AS Date), N'Nguyễn Anh; ', 0)
INSERT [dbo].[KHACH_GOI] ([Mã khách hàng], [Mã gói tập], [Ngày BĐ], [Ngày KT], [HLV], [ThanhToan(Y/N)]) VALUES (N'KH_150014', N'Yoga_1', CAST(N'2018-06-01' AS Date), CAST(N'2018-08-01' AS Date), N'Nguyễn Anh; Tester; ', 1)
SET IDENTITY_INSERT [dbo].[LSuGiaHan] ON 

INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (1, N'KH_150014', N'Tester', CAST(N'2018-05-13' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-05-17' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (2, N'KH_150000', N'Tuấn Anh', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (3, N'KH_150001', N'Vân Anh', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (4, N'KH_150002', N'Mai Duyên', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (5, N'KH_150003', N'Đình Dũng', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (6, N'KH_150004', N'Quốc Tuấn', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (7, N'KH_150005', N'Hồng Liên', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (8, N'KH_150006', N'Lê Tùng', CAST(N'2017-10-11' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (9, N'KH_150007', N'Bùi Hoàng', CAST(N'2017-10-11' AS Date), CAST(N'2018-07-08' AS Date), CAST(N'2018-07-08' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (10, N'KH_150010', N'Nguyễn An', CAST(N'2017-10-12' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (11, N'KH_150011', N'Giang Hải', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (12, N'KH_150012', N'Quỳnh Anh', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-19' AS Date), CAST(N'2018-05-19' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (13, N'KH_150014', N'Tester', CAST(N'2018-05-13' AS Date), CAST(N'2018-05-17' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (38, N'KH_150013', N'Trương Hải', CAST(N'2018-02-05' AS Date), CAST(N'2018-07-15' AS Date), CAST(N'2018-08-15' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (75, N'KH_150013', N'Trương Hải', CAST(N'2018-02-05' AS Date), CAST(N'2018-08-15' AS Date), CAST(N'2018-08-31' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (76, N'KH_150014', N'Tester', CAST(N'2018-05-13' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2019-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (77, N'KH_150014', N'Tester', CAST(N'2018-05-13' AS Date), CAST(N'2019-04-28' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (78, N'KH_150011', N'Giang Hải', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-08-01' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (79, N'KH_150012', N'Quỳnh Anh', CAST(N'2017-10-10' AS Date), CAST(N'2018-05-19' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (80, N'KH_150014', N'Tester', CAST(N'2018-05-13' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-08-01' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (81, N'KH_150014', N'Tester', CAST(N'2018-05-13' AS Date), CAST(N'2018-08-01' AS Date), CAST(N'2018-10-09' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (82, N'KH_150000', N'Tuấn Anhh', CAST(N'2017-10-10' AS Date), CAST(N'2018-04-28' AS Date), CAST(N'2018-04-28' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (83, N'KH_150011', N'Giang Hải', CAST(N'2017-10-10' AS Date), CAST(N'2018-08-01' AS Date), CAST(N'2080-05-24' AS Date), 0)
INSERT [dbo].[LSuGiaHan] ([Ma], [MaKhach], [TenKhach], [TGĐK], [HanTruoc], [HanSau], [check]) VALUES (84, N'KH_150011', N'Giang Hải', CAST(N'2017-10-10' AS Date), CAST(N'2080-05-24' AS Date), CAST(N'2018-08-01' AS Date), 0)
SET IDENTITY_INSERT [dbo].[LSuGiaHan] OFF
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên], [NS], [GT], [Số điện thoại], [Chức vụ], [Ca làm], [Ngày BĐ], [Lương], [Quê quán], [IsDel]) VALUES (N'NV_144706', N'Giang Hải', CAST(N'1997-06-17' AS Date), N'Nam', N'0965186738 ', N'Quản Lý', N'Cả Ngày', CAST(N'2017-10-10' AS Date), 0.0000, N'Hà Nội', 0)
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên], [NS], [GT], [Số điện thoại], [Chức vụ], [Ca làm], [Ngày BĐ], [Lương], [Quê quán], [IsDel]) VALUES (N'NV_144707', N'Dương Dũng', CAST(N'1997-08-28' AS Date), N'Nam', N'01662119740', N'HLV', N'Chiều', CAST(N'2017-10-10' AS Date), 6000000.0000, N'Hà Nội', 0)
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên], [NS], [GT], [Số điện thoại], [Chức vụ], [Ca làm], [Ngày BĐ], [Lương], [Quê quán], [IsDel]) VALUES (N'NV_144708', N'Giang C', CAST(N'1975-06-20' AS Date), N'Nam', N'0963632226 ', N'Quản Lý', N'Cả Ngày', CAST(N'2017-10-10' AS Date), 0.0000, N'Hà Nội', 0)
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên], [NS], [GT], [Số điện thoại], [Chức vụ], [Ca làm], [Ngày BĐ], [Lương], [Quê quán], [IsDel]) VALUES (N'NV_144709', N'Mr. Clean', CAST(N'1997-03-18' AS Date), N'Nam', N'0908070605 ', N'Dọn phòng', N'Tối', CAST(N'2017-10-10' AS Date), 3000000.0000, N'Hà Nội', 0)
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên], [NS], [GT], [Số điện thoại], [Chức vụ], [Ca làm], [Ngày BĐ], [Lương], [Quê quán], [IsDel]) VALUES (N'NV_144710', N'Nguyễn Anh', CAST(N'1997-01-01' AS Date), N'Nữ ', N'0973218324 ', N'HLV', N'Sáng', CAST(N'2017-10-10' AS Date), 4500000.0000, N'Hà Nội', 0)
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên], [NS], [GT], [Số điện thoại], [Chức vụ], [Ca làm], [Ngày BĐ], [Lương], [Quê quán], [IsDel]) VALUES (N'NV_144711', N'Quỳnh Anh', CAST(N'2000-07-30' AS Date), N'Nữ ', N'01685081146', N'Kế toán', N'Cả ngày', CAST(N'2017-10-10' AS Date), 5000000.0000, N'Hà Nội', 0)
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên], [NS], [GT], [Số điện thoại], [Chức vụ], [Ca làm], [Ngày BĐ], [Lương], [Quê quán], [IsDel]) VALUES (N'NV_144712', N'Bùi Tuấn', CAST(N'1997-04-19' AS Date), N'Nam', N'0973592599 ', N'HLV', N'Cả Ngày', CAST(N'2017-10-10' AS Date), 7000000.0000, N'Hà Nội', 0)
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên], [NS], [GT], [Số điện thoại], [Chức vụ], [Ca làm], [Ngày BĐ], [Lương], [Quê quán], [IsDel]) VALUES (N'NV_144713', N'Bá Nghĩa', CAST(N'1997-10-28' AS Date), N'Nam', N'0979731211 ', N'HLV', N'Cả Ngày', CAST(N'2017-10-10' AS Date), 7000000.0000, N'Hà Nội', 0)
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên], [NS], [GT], [Số điện thoại], [Chức vụ], [Ca làm], [Ngày BĐ], [Lương], [Quê quán], [IsDel]) VALUES (N'NV_144714', N'Hà Huy', CAST(N'1997-07-19' AS Date), N'Nam', N'01667563443', N'HLV', N'Tối', CAST(N'2017-10-10' AS Date), 4500000.0000, N'Hà Nội', 0)
INSERT [dbo].[NHANVIEN] ([Mã NV], [Tên], [NS], [GT], [Số điện thoại], [Chức vụ], [Ca làm], [Ngày BĐ], [Lương], [Quê quán], [IsDel]) VALUES (N'NV_144715', N'Tester', CAST(N'2018-05-04' AS Date), N'Nam', N'0112312312', N'HLV', N'Cả ngày', CAST(N'2018-05-12' AS Date), 8000000.0000, N'Hà nội', 0)
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144707', N'GYM_T1', N'Lớp thường', N'Dương Dũng')
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144707', N'GYM_T2', N'Lớp thường', N'Dương Dũng')
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144710', N'Aerobic_1', N'Aerobic', N'Nguyễn Anh')
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144710', N'GYM_Z2', N'Zumba', N'Nguyễn Anh')
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144710', N'Yoga_1', N'Yoga', N'Nguyễn Anh')
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144712', N'GYM_R2', N'KEM RIENG', N'Bùi Tuấn')
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144712', N'GYM_V1', N'Lớp VIP', N'Bùi Tuấn')
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144713', N'GYM_T2', N'Lớp thường', N'Bá Nghĩa')
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144713', N'GYM_V1', N'Lớp VIP', N'Bá Nghĩa')
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144714', N'GYM_R1', N'KEM RIENG', N'Hà Huy')
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144714', N'GYM_R3', N'KEM RIENG', N'Hà Huy')
INSERT [dbo].[PHÂN CÔNG] ([Mã HLV], [Mã gói tập], [Tên gói tập], [Tên HLV]) VALUES (N'NV_144715', N'Yoga_1', N'Yoga', N'Tester')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'Aerobic_1', N'P1003', N'Aerobic', N'Phòng tập dáng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R1', N'DC_160000', N'KEM RIENG', N'Tạ 10kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R1', N'DC_160006', N'KEM RIENG', N'Máy tập cơ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R1', N'DC_160008', N'KEM RIENG', N'Xe đạp')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R1', N'DC_160010', N'KEM RIENG', N'Ghế đa năng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R1', N'DC_160014', N'KEM RIENG', N'Máy chạy bộ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R1', N'DC_160017', N'KEM RIENG', N'Tạ 10 Kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R1', N'P1002', N'KEM RIENG', N'Phòng tập riêng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R2', N'DC_160000', N'KEM RIENG', N'Tạ 10kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R2', N'DC_160006', N'KEM RIENG', N'Máy tập cơ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R2', N'DC_160008', N'KEM RIENG', N'Xe đạp')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R2', N'DC_160010', N'KEM RIENG', N'Ghế đa năng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R2', N'DC_160014', N'KEM RIENG', N'Máy chạy bộ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R2', N'DC_160017', N'KEM RIENG', N'Tạ 10 Kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R2', N'P1002', N'KEM RIENG', N'Phòng tập riêng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R3', N'DC_160000', N'KEM RIENG', N'Tạ 10kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R3', N'DC_160006', N'KEM RIENG', N'Máy tập cơ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R3', N'DC_160008', N'KEM RIENG', N'Xe đạp')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R3', N'DC_160010', N'KEM RIENG', N'Ghế đa năng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R3', N'DC_160014', N'KEM RIENG', N'Máy chạy bộ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R3', N'DC_160017', N'KEM RIENG', N'Tạ 10 Kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_R3', N'P1002', N'KEM RIENG', N'Phòng tập riêng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T1', N'DC_160000', N'Lớp thường', N'Tạ 10kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T1', N'DC_160006', N'Lớp thường', N'Máy tập cơ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T1', N'DC_160008', N'Lớp thường', N'Xe đạp')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T1', N'DC_160010', N'Lớp thường', N'Ghế đa năng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T1', N'DC_160014', N'Lớp thường', N'Máy chạy bộ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T1', N'DC_160017', N'Lớp thường', N'Tạ 10 Kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T1', N'P1002', N'Lớp thường', N'Phòng tập riêng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T2', N'DC_160000', N'Lớp thường', N'Tạ 10kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T2', N'DC_160006', N'Lớp thường', N'Máy tập cơ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T2', N'DC_160008', N'Lớp thường', N'Xe đạp')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T2', N'DC_160010', N'Lớp thường', N'Ghế đa năng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T2', N'DC_160014', N'Lớp thường', N'Máy chạy bộ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T2', N'DC_160017', N'Lớp thường', N'Tạ 10 Kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_T2', N'P1002', N'Lớp thường', N'Phòng tập riêng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_V1', N'DC_160000', N'Lớp vip', N'Tạ 10kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_V1', N'DC_160006', N'Lớp vip', N'Máy tập cơ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_V1', N'DC_160008', N'Lớp vip', N'Xe đạp')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_V1', N'DC_160010', N'Lớp vip', N'Ghế đa năng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_V1', N'DC_160014', N'Lớp vip', N'Máy chạy bộ')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_V1', N'DC_160017', N'Lớp vip', N'Tạ 10 Kg')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_V1', N'P1002', N'Lớp vip', N'Phòng tập riêng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_Z1', N'P1003', N'Zumba', N'Phòng tập dáng')
INSERT [dbo].[TBi_GoiTap] ([Mã gói], [Mã thiết bị], [TenGoi], [TenThietBi]) VALUES (N'GYM_Z2', N'P1003', N'Zumba', N'Phòng tập dáng')
INSERT [dbo].[THU] ([Mã thu], [Mã khách], [Tên gói], [Số lượng tiền], [Thời gian], [Mô tả], [Người duyệt], [IsDel]) VALUES (N'GH_180000              ', N'KH_150011   ', N'GH_0001   ', 120000000.0000, CAST(N'2018-05-24 14:56:00' AS SmallDateTime), N'Khách hàng Giang Hải gia hạn thẻ ', N'NV_144706    ', 0)
INSERT [dbo].[THU] ([Mã thu], [Mã khách], [Tên gói], [Số lượng tiền], [Thời gian], [Mô tả], [Người duyệt], [IsDel]) VALUES (N'GH_180001              ', N'KH_150011   ', N'GH_0001   ', 30000000.0000, CAST(N'2018-05-24 15:00:00' AS SmallDateTime), N'Khách hàng Giang Hải gia hạn thẻ đến cuối đời', N'NV_144706    ', 0)
INSERT [dbo].[THU] ([Mã thu], [Mã khách], [Tên gói], [Số lượng tiền], [Thời gian], [Mô tả], [Người duyệt], [IsDel]) VALUES (N'M_180000               ', N'KH_150011   ', N'Aerobic_1 ', 1850000.0000, CAST(N'2018-05-22 00:51:00' AS SmallDateTime), N'Khách hàng Giang Hải đóng tiền gói tập Aerobic', N'NV_144706    ', 0)
INSERT [dbo].[THU] ([Mã thu], [Mã khách], [Tên gói], [Số lượng tiền], [Thời gian], [Mô tả], [Người duyệt], [IsDel]) VALUES (N'M_180001', N'KH_150014', N'Yoga_1', 1990000.0000, CAST(N'2018-05-23 02:50:00' AS SmallDateTime), N'Khách hàng Tester dóng ti?n gói t?p Yoga', N'NV_144711', 0)
INSERT [dbo].[THU] ([Mã thu], [Mã khách], [Tên gói], [Số lượng tiền], [Thời gian], [Mô tả], [Người duyệt], [IsDel]) VALUES (N'M_180002', N'KH_150011', N'Yoga_1', 1990000.0000, CAST(N'2018-05-23 02:54:00' AS SmallDateTime), N'Khách hàng Giang H?i dóng ti?n gói t?p Yoga', N'NV_144706', 0)
INSERT [dbo].[THU] ([Mã thu], [Mã khách], [Tên gói], [Số lượng tiền], [Thời gian], [Mô tả], [Người duyệt], [IsDel]) VALUES (N'M_180005', N'KH_150014', N'Aerobic_1', 1850000.0000, CAST(N'2018-05-24 03:39:00' AS SmallDateTime), N'Khách hàng Tester đóng tiền gói tập Aerobic', N'NV_144706', 0)
INSERT [dbo].[Users] ([UserName], [Pass], [FullName], [Privilege], [ID]) VALUES (N'15150150', N'1', N'Hải', N'low', N'NV_144706')
INSERT [dbo].[Users] ([UserName], [Pass], [FullName], [Privilege], [ID]) VALUES (N'admin', N'123', N'Hari', N'high', N'NV_144706')
INSERT [dbo].[Users] ([UserName], [Pass], [FullName], [Privilege], [ID]) VALUES (N'banghia', N'12', N'Bá Nghĩa', N'normal', N'NV_144713')
INSERT [dbo].[Users] ([UserName], [Pass], [FullName], [Privilege], [ID]) VALUES (N'buituan', N'12', N'Bùi Tuấn', N'normal', N'NV_144712')
INSERT [dbo].[Users] ([UserName], [Pass], [FullName], [Privilege], [ID]) VALUES (N'duongdung', N'12', N'Dương Dũng', N'nomal', N'NV_144707')
INSERT [dbo].[Users] ([UserName], [Pass], [FullName], [Privilege], [ID]) VALUES (N'gianghai', N'12', N'Giang Hải', N'normal', N'NV_144706')
INSERT [dbo].[Users] ([UserName], [Pass], [FullName], [Privilege], [ID]) VALUES (N'hahuy', N'12', N'Hà Huy', N'normal', N'NV_144714')
INSERT [dbo].[Users] ([UserName], [Pass], [FullName], [Privilege], [ID]) VALUES (N'hoanghong', N'1', N'Hoàng Hồng', N'normal', N'NV_144713')
INSERT [dbo].[Users] ([UserName], [Pass], [FullName], [Privilege], [ID]) VALUES (N'nguyenanh', N'12', N'Nguyễn Anh', N'normal', N'NV_144710')
INSERT [dbo].[Users] ([UserName], [Pass], [FullName], [Privilege], [ID]) VALUES (N'quynhanh', N'12', N'Quỳnh Anh', N'normal', N'NV_144711')
SET ANSI_PADDING ON

GO
/****** Object:  Index [KHACH_SDT]    Script Date: 5/25/2018 12:29:19 AM ******/
ALTER TABLE [dbo].[KHÁCH] ADD  CONSTRAINT [KHACH_SDT] UNIQUE NONCLUSTERED 
(
	[Số điện thoại] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [KHACH_THEKHACH]    Script Date: 5/25/2018 12:29:19 AM ******/
ALTER TABLE [dbo].[KHÁCH] ADD  CONSTRAINT [KHACH_THEKHACH] UNIQUE NONCLUSTERED 
(
	[Mã khách] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [NHANVIEN_SDT]    Script Date: 5/25/2018 12:29:19 AM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [NHANVIEN_SDT] UNIQUE NONCLUSTERED 
(
	[Số điện thoại] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHI]  WITH CHECK ADD  CONSTRAINT [FK_CHI_NHANVIEN] FOREIGN KEY([Người thực hiện])
REFERENCES [dbo].[NHANVIEN] ([Mã NV])
GO
ALTER TABLE [dbo].[CHI] CHECK CONSTRAINT [FK_CHI_NHANVIEN]
GO
ALTER TABLE [dbo].[KHACH_GOI]  WITH CHECK ADD  CONSTRAINT [FK_KHACH_GOI_GÓI TẬP] FOREIGN KEY([Mã gói tập])
REFERENCES [dbo].[GÓI TẬP] ([Mã gói tập])
GO
ALTER TABLE [dbo].[KHACH_GOI] CHECK CONSTRAINT [FK_KHACH_GOI_GÓI TẬP]
GO
ALTER TABLE [dbo].[KHACH_GOI]  WITH CHECK ADD  CONSTRAINT [FK_KHACH_GOI_KHÁCH] FOREIGN KEY([Mã khách hàng])
REFERENCES [dbo].[KHÁCH] ([Mã khách])
GO
ALTER TABLE [dbo].[KHACH_GOI] CHECK CONSTRAINT [FK_KHACH_GOI_KHÁCH]
GO
ALTER TABLE [dbo].[LSuGiaHan]  WITH CHECK ADD  CONSTRAINT [FK_expirationHistory_KHÁCH] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KHÁCH] ([Mã khách])
GO
ALTER TABLE [dbo].[LSuGiaHan] CHECK CONSTRAINT [FK_expirationHistory_KHÁCH]
GO
ALTER TABLE [dbo].[PHÂN CÔNG]  WITH CHECK ADD  CONSTRAINT [FK_PHÂN CÔNG_GÓI TẬP] FOREIGN KEY([Mã gói tập])
REFERENCES [dbo].[GÓI TẬP] ([Mã gói tập])
GO
ALTER TABLE [dbo].[PHÂN CÔNG] CHECK CONSTRAINT [FK_PHÂN CÔNG_GÓI TẬP]
GO
ALTER TABLE [dbo].[PHÂN CÔNG]  WITH CHECK ADD  CONSTRAINT [FK_PHÂN CÔNG_GÓI TẬP1] FOREIGN KEY([Mã gói tập])
REFERENCES [dbo].[GÓI TẬP] ([Mã gói tập])
GO
ALTER TABLE [dbo].[PHÂN CÔNG] CHECK CONSTRAINT [FK_PHÂN CÔNG_GÓI TẬP1]
GO
ALTER TABLE [dbo].[PHÂN CÔNG]  WITH CHECK ADD  CONSTRAINT [FK_PHÂN CÔNG_NHANVIEN] FOREIGN KEY([Mã HLV])
REFERENCES [dbo].[NHANVIEN] ([Mã NV])
GO
ALTER TABLE [dbo].[PHÂN CÔNG] CHECK CONSTRAINT [FK_PHÂN CÔNG_NHANVIEN]
GO
ALTER TABLE [dbo].[TBi_GoiTap]  WITH CHECK ADD  CONSTRAINT [FK_TBi_GoiTap_DUNGCU] FOREIGN KEY([Mã thiết bị])
REFERENCES [dbo].[DUNGCU] ([Mã dụng cụ])
GO
ALTER TABLE [dbo].[TBi_GoiTap] CHECK CONSTRAINT [FK_TBi_GoiTap_DUNGCU]
GO
ALTER TABLE [dbo].[TBi_GoiTap]  WITH CHECK ADD  CONSTRAINT [FK_TBi_GoiTap_GÓI TẬP] FOREIGN KEY([Mã gói])
REFERENCES [dbo].[GÓI TẬP] ([Mã gói tập])
GO
ALTER TABLE [dbo].[TBi_GoiTap] CHECK CONSTRAINT [FK_TBi_GoiTap_GÓI TẬP]
GO
ALTER TABLE [dbo].[THU]  WITH CHECK ADD  CONSTRAINT [FK_THU_KHÁCH] FOREIGN KEY([Mã khách])
REFERENCES [dbo].[KHÁCH] ([Mã khách])
GO
ALTER TABLE [dbo].[THU] CHECK CONSTRAINT [FK_THU_KHÁCH]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_NHANVIEN] FOREIGN KEY([ID])
REFERENCES [dbo].[NHANVIEN] ([Mã NV])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_NHANVIEN]
GO
ALTER TABLE [dbo].[GÓI TẬP]  WITH CHECK ADD  CONSTRAINT [CHECK_CATAP] CHECK  (([Ca]=N'Không giới hạn' OR [Ca]=N'Tối' OR [Ca]=N'Chiều' OR [Ca]=N'Sáng'))
GO
ALTER TABLE [dbo].[GÓI TẬP] CHECK CONSTRAINT [CHECK_CATAP]
GO
ALTER TABLE [dbo].[KHÁCH]  WITH CHECK ADD  CONSTRAINT [CHECK_GT_KHACH] CHECK  (([GT]=N'Nữ' OR [GT]=N'Nam'))
GO
ALTER TABLE [dbo].[KHÁCH] CHECK CONSTRAINT [CHECK_GT_KHACH]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [CHECK_GT_NV] CHECK  (([GT]=N'Nữ' OR [GT]=N'Nam'))
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [CHECK_GT_NV]
GO
/****** Object:  StoredProcedure [dbo].[ID_Chi]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ID_Chi](
@maChi NVARCHAR(10),
@soTien MONEY,
@noidung NVARCHAR(100),
@ngThucHien VARCHAR(12),
@Statement NVARCHAR(20)=''
) AS
BEGIN
	IF @Statement = 'Select'
	BEGIN
		SELECT * FROM dbo.CHI WHERE [Mã chi] =@maChi
	END
	IF @Statement ='Insert'
	BEGIN
		 INSERT INTO dbo.CHI
		 VALUES  ( @maChi , -- Mã chi - nvarchar(10)
		           @soTien , -- Số tiền - money
		           GETDATE() , -- Thời gian - date
		           @noidung , -- Nội dung - nvarchar(100)
		           @ngThucHien,  -- Người thực hiện - nchar(13)
				   0
		         )
	END
	IF @Statement='Hide'
	BEGIN
		UPDATE dbo.CHI SET IsDel=1 WHERE [Mã chi]=@maChi
	END
	IF @Statement='Show'
	BEGIN
		UPDATE dbo.CHI SET IsDel=0 WHERE [Mã chi]=@maChi
	END
	IF @Statement ='Delete'
	BEGIN
		DELETE FROM dbo.CHI WHERE [Mã chi]=@maChi
	END
END

GO
/****** Object:  StoredProcedure [dbo].[ID_PhanCong]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ID_PhanCong](
@mahlv VARCHAR(13),
@magoitap VARCHAR(10),
@statement NVARCHAR(20) =''
) AS
BEGIN
	IF @statement ='Select'
	BEGIN
		SELECT * FROM dbo.[PHÂN CÔNG] WHERE [Mã HLV]=@mahlv AND [Mã gói tập]=@magoitap
	END
	IF @statement ='Insert'
	BEGIN
		INSERT INTO dbo.[PHÂN CÔNG]
		        ( [Mã HLV] ,
		          [Mã gói tập]
		        )
		VALUES  (  @mahlv, -- Mã HLV - varchar(13)
		          @magoitap -- Mã gói tập - varchar(10)
		        )
	END
	IF @statement = 'Delete'
	BEGIN
		DELETE FROM dbo.[PHÂN CÔNG] WHERE [Mã HLV]=@mahlv AND [Mã gói tập]=@magoitap
	END
END

GO
/****** Object:  StoredProcedure [dbo].[ID_Thu]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ID_Thu](
@mathu NCHAR(23),
@makhach NCHAR(13),
@tengoi NCHAR(10),
@sotien MONEY,
@ngduyet NCHAR(13),
@mota NVARCHAR(100),
@Statement NVARCHAR(20)=''
) AS 
BEGIN
	IF @Statement='Select'
	BEGIN
		SELECT * FROM dbo.THU WHERE [Mã thu] =@mathu OR ([Mã khách]=@makhach AND [Tên gói]=@tengoi )
	END
	IF @Statement = 'Insert'
	BEGIN
		
		INSERT INTO dbo.THU
		        ( [Mã thu] ,
		          [Mã khách] ,
		          [Tên gói] ,
		          [Số lượng tiền] ,
		          [Thời gian] ,
		          [Mô tả] ,
		          [Người duyệt],
				  IsDel
		        )
		VALUES  ( @mathu , -- Mã thu - nchar(23)
		          @makhach , -- Mã khách - nchar(13)
		          @tengoi , -- Tên gói - nchar(10)
		          @sotien , -- Số lượng tiền - money
		          GETDATE() , -- Thời gian - date
		          @mota , -- Mô tả - nvarchar(100)
		          @ngduyet,  -- Người duyệt - nchar(13)
				  '0'
		        )
	END
	IF @Statement ='Delete'
	BEGIN
		DELETE FROM dbo.THU WHERE [Mã thu] =@mathu
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_HanThe]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_HanThe] AS 
BEGIN
	DECLARE @makhach VARCHAR(12), @ngayKT DATE 
	DECLARE cuso CURSOR SCROLL FOR
	SELECT [Mã khách hàng], MAX([Ngày KT]) FROM dbo.KHACH_GOI GROUP BY [Mã khách hàng]
	OPEN cuso
	FETCH FIRST FROM cuso INTO @makhach,@ngayKT
	WHILE @@FETCH_STATUS=0
	BEGIN
		UPDATE dbo.KHÁCH SET HanThe=@ngayKT WHERE [Mã khách]=@makhach AND HanThe <> @ngayKT
		FETCH NEXT FROM cuso INTO @makhach,@ngayKT
	END
	CLOSE cuso
	DEALLOCATE cuso
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_TB_GT]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_TB_GT] AS
BEGIN
	DECLARE @maGT VARCHAR(12), @tenGoi NVARCHAR(50), @maTB VARCHAR(10),@tenTB NVARCHAR(50)
	DECLARE cuso CURSOR SCROLL FOR 
	SELECT [Mã gói tập], [Tên gói tập],[Mã dụng cụ],Tên FROM dbo.[GÓI TẬP], dbo.DUNGCU WHERE KhuVucSD=KhuVucTap
	OPEN cuso 
	FETCH FIRST FROM cuso INTO @maGT,@tenGoi,@maTB,@tenTB
	WHILE @@FETCH_STATUS =0
	BEGIN
		INSERT INTO dbo.TBi_GoiTap
		VALUES  ( @maGT , -- Mã gói - varchar(12)
		         @maTB , -- Mã thiết bị - varchar(10)
		          @tenGoi , -- TenGoi - nvarchar(50)
		          @tenTB  -- TenThietBi - nvarchar(50)
		        )
				FETCH NEXT FROM cuso INTO @maGT,@tenGoi,@maTB,@tenTB
	END
	CLOSE cuso
	DEALLOCATE cuso
END
GO
/****** Object:  StoredProcedure [dbo].[insertDATEforKHACH_GOI]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertDATEforKHACH_GOI] AS
BEGIN
	DECLARE @magoi VARCHAR(12),@ngaybd DATE, @ngaykt DATE
	DECLARE tg CURSOR SCROLL FOR
		SELECT [Mã gói tập],[Ngày bắt đầu],[Ngày kết thúc] FROM dbo.[GÓI TẬP]
		OPEN tg;
		FETCH FIRST FROM tg INTO @magoi,@ngaybd,@ngaykt;
		WHILE @@FETCH_STATUS=0
		BEGIN
			UPDATE dbo.KHACH_GOI SET [Ngày BĐ]=@ngaybd,[Ngày KT]=@ngaykt WHERE [Mã gói tập] =@magoi
			FETCH NEXT FROM tg INTO @magoi,@ngaybd,@ngaykt;
		END
	CLOSE tg;
	DEALLOCATE tg;
END

GO
/****** Object:  StoredProcedure [dbo].[insertEquipmentsPrice]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertEquipmentsPrice](
@ngThucHien VARCHAR(13)
) AS
BEGIN
	DECLARE @madc VARCHAR(10),@tendc NVARCHAR(50), @gia MONEY,@noidung NVARCHAR(100)
	DECLARE cuso CURSOR SCROLL FOR
	SELECT [Mã dụng cụ],Giá,Tên FROM dbo.DUNGCU WHERE [Mã dụng cụ] NOT IN (SELECT [Mã chi] FROM dbo.CHI)
	OPEN cuso
	FETCH FIRST FROM cuso INTO @madc,@gia,@tendc
	WHILE @@FETCH_STATUS = 0
		BEGIN
		SET @noidung= N'Mua dụng cụ '+@tendc
		SET @gia = @gia * -1
		INSERT dbo.CHI
			SELECT @madc,@gia,GETDATE(),@noidung,@ngThucHien,0
		FETCH NEXT FROM cuso INTO @madc,@gia,@tendc
		END
END 
CLOSE cuso
DEALLOCATE cuso

GO
/****** Object:  StoredProcedure [dbo].[insertHLVforKHACH_GOI]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------------
CREATE PROC [dbo].[insertHLVforKHACH_GOI] AS
BEGIN
	DECLARE @magoi VARCHAR(12), @tenhlv NVARCHAR(MAX)
	DECLARE arr CURSOR SCROLL FOR
	SELECT [Mã gói tập],[Tên HLV] FROM dbo.[PHÂN CÔNG]
	OPEN arr
	FETCH FIRST FROM arr INTO @magoi,@tenhlv
	WHILE @@FETCH_STATUS =0
	BEGIN
		SET @tenhlv=''
		DECLARE @magoi2 VARCHAR(12), @tenhlv2 NVARCHAR(max)
		DECLARE arr2 CURSOR SCROLL FOR
		SELECT [Mã gói tập],[Tên HLV] FROM dbo.[PHÂN CÔNG]
		OPEN arr2
		FETCH FIRST FROM arr2 INTO @magoi2,@tenhlv2
		WHILE @@FETCH_STATUS=0
		BEGIN
			IF (@magoi2=@magoi)
			BEGIN
				SET @tenhlv= @tenhlv+@tenhlv2+'; '
			END
			FETCH NEXT FROM arr2 INTO @magoi2,@tenhlv2
		END
		CLOSE arr2
		DEALLOCATE arr2
		UPDATE dbo.KHACH_GOI SET HLV=@tenhlv WHERE [Mã gói tập]=@magoi
		FETCH NEXT FROM arr INTO @magoi,@tenhlv
	END
	CLOSE arr
	DEALLOCATE arr
END

GO
/****** Object:  StoredProcedure [dbo].[insertNumofclasses]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertNumofclasses] AS 
BEGIN
	DECLARE @mahlv NCHAR(13),@solg INT;
	DECLARE temp2 CURSOR SCROLL FOR 
		SELECT [Mã HLV], COUNT([Mã HLV]) FROM dbo.[PHÂN CÔNG] GROUP BY [Mã HLV]
		OPEN temp2;
		FETCH FIRST FROM temp2 INTO @mahlv,@solg;
		WHILE @@FETCH_STATUS = 0
		BEGIN
			UPDATE dbo.HLV SET [Số lớp]=@solg WHERE [Mã HLV]=@mahlv
			FETCH NEXT FROM temp2 INTO @mahlv,@solg;
		END 
	CLOSE temp2;
	DEALLOCATE temp2;
END
GO
/****** Object:  StoredProcedure [dbo].[insertNumofcustomer]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertNumofcustomer] AS 
BEGIN
	DECLARE @magoi VARCHAR(12),@solg INT;
	DECLARE temp CURSOR SCROLL FOR 
		SELECT [Mã gói tập],COUNT([Mã gói tập]) FROM dbo.KHACH_GOI GROUP BY [Mã gói tập];
		OPEN temp;
		FETCH FIRST FROM temp INTO @magoi,@solg;
		WHILE @@FETCH_STATUS = 0
		BEGIN
			UPDATE dbo.[GÓI TẬP] SET [Số người ĐK] = @solg WHERE [Mã gói tập] =@magoi
			FETCH NEXT FROM temp INTO @magoi,@solg;
		END 
	CLOSE temp;
	DEALLOCATE temp;
END

GO
/****** Object:  StoredProcedure [dbo].[insertTEN_TBiGoiTap]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertTEN_TBiGoiTap] AS
BEGIN
	DECLARE @ma varchar(10), @tengoi NVARCHAR(50)
	DECLARE tg CURSOR SCROLL FOR
		SELECT [Mã gói tập],[Tên gói tập] FROM dbo.[GÓI TẬP]
		OPEN tg
		FETCH FIRST FROM tg INTO @ma,@tengoi
		WHILE @@FETCH_STATUS=0
		BEGIN
			UPDATE dbo.TBi_GoiTap SET TenGoi=@tengoi WHERE [Mã gói]=@ma
			FETCH NEXT FROM tg INTO @ma,@tengoi
		END
	CLOSE tg;
	DEALLOCATE tg;
	DECLARE @madungcu VARCHAR(10), @tendungcu NVARCHAR(50)
	DECLARE tg2 CURSOR SCROLL FOR
		SELECT [Mã dụng cụ], Tên FROM dbo.DUNGCU
		OPEN tg2;
		FETCH FIRST FROM tg2 INTO @madungcu,@tendungcu
		WHILE @@FETCH_STATUS =0
		BEGIN
			UPDATE dbo.TBi_GoiTap SET TenThietBi=@tendungcu WHERE [Mã thiết bị]=@madungcu
			FETCH NEXT FROM tg2 INTO @madungcu,@tendungcu
		END
	CLOSE tg2;
	DEALLOCATE tg2;
END
GO
/****** Object:  StoredProcedure [dbo].[insertTENofPhanCong]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertTENofPhanCong] AS
BEGIN
	DECLARE @ma VARCHAR(12), @tenhlv NVARCHAR(50)
	DECLARE tg CURSOR SCROLL FOR
		SELECT [Mã NV],Tên FROM dbo.NHANVIEN WHERE [Chức vụ] LIKE N'HLV'
		OPEN tg
		FETCH FIRST FROM tg INTO @ma,@tenhlv
		WHILE @@FETCH_STATUS=0
		BEGIN
			UPDATE dbo.[PHÂN CÔNG] SET [Tên HLV]=@tenhlv WHERE [Mã HLV]=@ma
			FETCH NEXT FROM tg INTO @ma,@tenhlv
		END
	CLOSE tg;
	DEALLOCATE tg;
	DECLARE @magoi VARCHAR(12), @tengoi NVARCHAR(50)
	DECLARE tg2 CURSOR SCROLL FOR
		SELECT [Mã gói tập], [Tên gói tập] FROM dbo.[GÓI TẬP]
		OPEN tg2;
		FETCH FIRST FROM tg2 INTO @magoi,@tengoi
		WHILE @@FETCH_STATUS =0
		BEGIN
			UPDATE dbo.[PHÂN CÔNG] SET [Tên gói tập]=@tengoi WHERE [Mã gói tập]=@magoi
			FETCH NEXT FROM tg2 INTO @magoi,@tengoi
		END
	CLOSE tg2;
	DEALLOCATE tg2;
END

GO
/****** Object:  StoredProcedure [dbo].[IUD_DUNGCU]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IUD_DUNGCU](
@maDC VARCHAR(10),
@tenDC NVARCHAR(50),
@gia MONEY,
@tinhTrang NVARCHAR(50),
@ngaySD DATE,
@khuVucSD NVARCHAR(50),
@Statement NVARCHAR(20)='' )
AS
BEGIN
	IF @Statement='Insert'
	BEGIN
		INSERT INTO dbo.DUNGCU
		VALUES  ( @maDC , -- Mã dụng cụ - varchar(10)
		          @tenDC , -- Tên - nvarchar(50)
		          @gia , -- Giá - money
		          @tinhTrang , -- Tình trạng(%) - int
		          CAST(GETDATE() AS DATE) , -- Ngày mua - date
		          @ngaySD,  -- NQL - varchar(12)
				  @khuVucSD,
				  0
		        )
	END
	IF @Statement = 'Hide'
	BEGIN
		UPDATE dbo.DUNGCU SET IsDel = 1 WHERE [Mã dụng cụ]=@maDC	
	END
	IF @Statement = 'Show'
	BEGIN
		UPDATE dbo.DUNGCU SET IsDel=0 WHERE [Mã dụng cụ]=@maDC
	END
	IF @Statement = 'Update'
	BEGIN
		UPDATE dbo.DUNGCU SET Tên=@tenDC,Giá=@gia,[Tình trạng]=@tinhTrang,NgaySD=@ngaySD,KhuVucSD=@khuVucSD WHERE [Mã dụng cụ]=@maDC
	END
	IF @Statement = 'Delete'
	BEGIN
		DELETE FROM dbo.DUNGCU WHERE [Mã dụng cụ]=@maDC
	END
END
GO
/****** Object:  StoredProcedure [dbo].[IUD_GOITAP]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IUD_GOITAP](
	@magoi VARCHAR(12),
	@tengoi NVARCHAR(50),
	@gia MONEY,
	@ngayBD DATE,
	@ngayKT DATE,
	@buoi NVARCHAR(50),
	@ca NVARCHAR(50),
	@khuvuc NVARCHAR(50),
	@deleted BIT,
	@Statement NVARCHAR(20)=''
) AS
BEGIN
	IF @Statement = 'Select'
	BEGIN
		SELECT * FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] =@magoi
	END
	IF @Statement = 'Insert'
	BEGIN
		INSERT INTO dbo.[GÓI TẬP]
		VALUES  ( @magoi , -- Mã gói tập - varchar(12)
		          @tengoi , -- Tên gói tập - nvarchar(50)
		          @gia , -- Giá - money
		          @ngayBD , -- Ngày bắt đầu - date
		          @ngayKT , -- Ngày kết thúc - date
		          @buoi , -- Buổi - nvarchar(50)
				  @ca , -- Ca - nvarchar(50)
		          @khuvuc, -- khu vuc
				  0,  -- Số người ĐK - int
				  @deleted --isdell
		        )
	END
	IF @Statement = 'Update'
	BEGIN
		UPDATE dbo.[GÓI TẬP] 
		SET [Tên gói tập]=@tengoi,
			[Giá] = @gia,
			[Ngày bắt đầu]=@ngayBD,
			[Ngày kết thúc]=@ngayKT,
			[Buổi]=@buoi,
			[Ca]=@ca,
			[KhuVucTap]=@khuvuc,
			IsDel=@deleted
		WHERE [Mã gói tập]=@magoi
	END
	IF @Statement='Hide'
	BEGIN
		UPDATE dbo.[GÓI TẬP]
		SET IsDel=1
		WHERE [Mã gói tập]=@magoi
	END
	IF @Statement = 'Show'
	BEGIN
		UPDATE dbo.[GÓI TẬP]
		SET IsDel=0
		WHERE [Mã gói tập]=@magoi
	END
	IF (@Statement = 'Delete')
	BEGIN
		DELETE FROM dbo.KHACH_GOI WHERE [Mã gói tập]=@magoi
		DELETE FROM dbo.THU WHERE [Tên gói] =@magoi
		DELETE FROM dbo.[PHÂN CÔNG] WHERE [Mã gói tập]=@magoi
		DELETE FROM dbo.TBi_GoiTap WHERE [Mã gói]=@magoi
		DELETE FROM dbo.[GÓI TẬP] WHERE [Mã gói tập]=@magoi
	END
END
GO
/****** Object:  StoredProcedure [dbo].[IUD_KHACH]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IUD_KHACH](
@makhach VARCHAR(12),
@hoten NVARCHAR(30),
@GT NCHAR(3),
@NS DATE,
@SDT VARCHAR(11),
@diachi NVARCHAR(50),
@ngayDK DATE,
@hanthe DATE,
@Statement NVARCHAR(20)=''
) AS
BEGIN
	IF @Statement='Select'
	BEGIN
		SELECT * FROM dbo.KHÁCH WHERE [Mã khách]=@makhach
	END
	IF @Statement='Insert'
	BEGIN
		INSERT INTO dbo.KHÁCH
		VALUES  ( @makhach , -- Mã khách - varchar(12)
		          @hoten , -- Họ tên - nvarchar(30)
		          @GT , -- GT - nchar(3)
		          @NS , -- NS - date
		          @SDT, -- Số điện thoại - varchar(11)
		          @diachi , -- Địa chỉ - nvarchar(50)
		          @ngayDK , -- Ngày đăng ký - date
		          @hanthe , -- HanThe - date
		          0  -- IsDel - bit
		        )
	END
	IF @Statement = 'Hide'
	BEGIN
		UPDATE dbo.KHÁCH SET IsDel=1 WHERE [Mã khách]=@makhach
	END
	IF @Statement='Show'
	BEGIN
		UPDATE dbo.KHÁCH SET IsDel = 0 WHERE [Mã khách]=@makhach
	END
	IF @Statement='Update'
	BEGIN
		UPDATE dbo.KHÁCH SET
			[Họ tên]=@hoten,
			GT=@GT,
			NS=@NS,
			[Số điện thoại]=@SDT,
			[Địa chỉ]=@diachi,
			HanThe=@hanthe
		WHERE [Mã khách]=@makhach
	END
	IF @Statement='Delete'
	BEGIN
		DELETE FROM dbo.THU WHERE [Mã khách]=@makhach
		DELETE FROM dbo.KHACH_GOI WHERE [Mã khách hàng]=@makhach
		DELETE FROM dbo.KHÁCH WHERE [Mã khách]=@makhach
	END
END

GO
/****** Object:  StoredProcedure [dbo].[IUD_KhachGoi]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IUD_KhachGoi](
@mkh NVARCHAR(13),
@mgt NCHAR(10),
@StamentType NVARCHAR(20)=''
)
AS BEGIN
   	IF @StamentType = 'Insert'
	BEGIN
		INSERT INTO dbo.KHACH_GOI
		        ( [Mã khách hàng] ,
		          [Mã gói tập],
				  [ThanhToan(Y/N)]
		        )
		VALUES  ( @mkh , -- Mã khách hàng - nvarchar(13)
		          @mgt, -- Mã gói tập - nchar(10)
				  '0'
		        )
	END
	IF @StamentType = 'ThanhToan'
	BEGIN
		INSERT INTO dbo.KHACH_GOI
		        ( [Mã khách hàng] ,
		          [Mã gói tập],
				  [ThanhToan(Y/N)]
		        )
		VALUES  ( @mkh , -- Mã khách hàng - nvarchar(13)
		          @mgt, -- Mã gói tập - nchar(10)
				  '1'
		        )
	END
	IF @StamentType = 'Delete'
	BEGIN
		DELETE FROM dbo.KHACH_GOI WHERE [Mã khách hàng]=@mkh AND [Mã gói tập]=@mgt
	END
	IF @StamentType ='Select'
	BEGIN
		SELECT * FROM dbo.KHACH_GOI WHERE [Mã khách hàng]=@mkh AND [Mã gói tập]=@mgt
	END
   END

GO
/****** Object:  StoredProcedure [dbo].[IUD_NHANVIEN]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IUD_NHANVIEN](
@manv VARCHAR(12),
@ten NVARCHAR(50),
@NS DATE,
@gt NCHAR(3),
@SDT VARCHAR(11),
@chucvu NVARCHAR(30),
@calam NVARCHAR(50),
@ngDB DATE,
@luong MONEY,
@que NVARCHAR(50),
@Statement NVARCHAR(20)='' )
AS
BEGIN
	IF @Statement='Select'
	BEGIN
		SELECT * FROM dbo.NHANVIEN WHERE [Mã NV]=@manv
	END
	IF @Statement='Insert'
	BEGIN
		INSERT INTO dbo.NHANVIEN
		VALUES  ( @manv , -- Mã NV - varchar(12)
		          @ten , -- Tên - nvarchar(50)
		          @NS , -- NS - date
		          @gt , -- GT - nchar(3)
		          @SDT, -- Số điện thoại - varchar(11)
		          @chucvu, -- Chức vụ - nvarchar(30)
		          @calam, -- Ca làm - nvarchar(50)
		          @ngDB , -- Ngày BĐ - date
		          @luong, -- Lương - money
		          @que,  -- Quê quán - nvarchar(50)
				  0
		        )
	END
	IF @Statement='Update'
	BEGIN
		UPDATE dbo.NHANVIEN SET 
			Tên=@ten,
			NS=@NS,
			GT=@gt,
			[Số điện thoại]=@SDT,
			[Chức vụ]=@chucvu,
			[Ca làm]=@calam,
			[Ngày BĐ]=@ngDB,
			Lương=@luong,
			[Quê quán]=@que
		WHERE [Mã NV]=@manv
	END
	IF @Statement='Hide'
	BEGIN
		UPDATE dbo.NHANVIEN SET
			IsDel =1
		WHERE [Mã NV]=@manv
	END
	IF @Statement='Show'
	BEGIN
		UPDATE dbo.NHANVIEN SET
			IsDel=0
		WHERE [Mã NV]=@manv
	END
	IF @Statement='Delete'
	BEGIN
		DELETE FROM dbo.CHI WHERE [Người thực hiện]=@manv
		DELETE FROM dbo.[PHÂN CÔNG] WHERE [Mã HLV]=@manv
		DELETE FROM dbo.NHANVIEN WHERE [Mã NV]=@manv
	END
END
GO
/****** Object:  StoredProcedure [dbo].[IUD_USERS]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IUD_USERS]( 
@userName NVARCHAR(50),
@name NVARCHAR(50),
@pri NVARCHAR(50),
@iD VARCHAR(12),
@Statement NVARCHAR(20) ='')
AS
BEGIN
	IF @Statement='Select'
	BEGIN
		SELECT * FROM dbo.Users WHERE UserName=@userName
	END
	IF @Statement='Insert'
	BEGIN
		INSERT INTO dbo.Users 
		VALUES  ( @userName , -- UserName - nvarchar(50)
		          '1' , -- Pass - nvarchar(50)
		          @name , -- FullName - nvarchar(50)
		          @pri , -- Privilege - nvarchar(50)
		          @iD  -- ID - varchar(12)
		        )
	END
	IF @Statement='Update'
	BEGIN
		UPDATE dbo.Users SET FullName=@name,Privilege=@pri,ID=@iD WHERE UserName=@userName
	END
	IF @Statement='Delete'
	BEGIN
		DELETE FROM dbo.Users WHERE UserName=@userName
	END
END
GO
/****** Object:  StoredProcedure [dbo].[ThanhToan_GoiTap]    Script Date: 5/25/2018 12:29:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThanhToan_GoiTap] (
@mathu VARCHAR(23),
@makhach VARCHAR(12),
@magoi VARCHAR(12),
@soluongtien MONEY,
@mota NVARCHAR(100),
@nguoiduyet VARCHAR(13) )
AS
BEGIN
	INSERT INTO dbo.THU
	VALUES  ( @mathu , -- Mã thu - varchar(23)
		        @makhach , -- Mã khách - varchar(12)
		        @magoi , -- Tên gói - varchar(12)
		        @soluongtien , -- Số lượng tiền - money
		        GETDATE() , -- Thời gian - smalldatetime
		        @mota , -- Mô tả - nvarchar(100)
		        @nguoiduyet , -- Người duyệt - varchar(13)
		        0  -- IsDel - bit
		    )
	INSERT INTO dbo.KHACH_GOI 
		    ( [Mã khách hàng] ,
		        [Mã gói tập] ,
		        [Ngày BĐ] ,
		        [Ngày KT] ,
		        HLV ,
		        [ThanhToan(Y/N)]
		    )
	VALUES  ( @makhach , -- Mã khách hàng - varchar(12)
		        @magoi , -- Mã gói tập - varchar(12)
		        NULL , -- Ngày BĐ - date
		        NULL , -- Ngày KT - date
		        NULL , -- HLV - nvarchar(max)
		        1  -- ThanhToan(Y/N) - bit
		    )
	EXECUTE dbo.insertDATEforKHACH_GOI
	EXECUTE dbo.insertHLVforKHACH_GOI
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'<' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'GÓI TẬP', @level2type=N'COLUMN',@level2name=N'Ngày bắt đầu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'>' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'GÓI TẬP', @level2type=N'COLUMN',@level2name=N'Ngày kết thúc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'AT' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'GÓI TẬP', @level2type=N'COLUMN',@level2name=N'Số người ĐK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'<' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KHÁCH', @level2type=N'COLUMN',@level2name=N'Ngày đăng ký'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'AT' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KHACH_GOI', @level2type=N'COLUMN',@level2name=N'Ngày BĐ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'AT' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KHACH_GOI', @level2type=N'COLUMN',@level2name=N'Ngày KT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'AT' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KHACH_GOI', @level2type=N'COLUMN',@level2name=N'HLV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'AT' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHÂN CÔNG', @level2type=N'COLUMN',@level2name=N'Tên gói tập'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'AT' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHÂN CÔNG', @level2type=N'COLUMN',@level2name=N'Tên HLV'
GO
USE [master]
GO
ALTER DATABASE [GYM] SET  READ_WRITE 
GO

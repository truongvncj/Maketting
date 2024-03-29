USE [master]
GO
/****** Object:  Database [MKTing]    Script Date: 23/09/2021 2:27:09 CH ******/
CREATE DATABASE [MKTing]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'POSM', FILENAME = N'C:\Data\Datasql\MKTing.mdf' , SIZE = 235904KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'POSM_log', FILENAME = N'C:\Data\Datasql\MKTing_log.ldf' , SIZE = 1850304KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MKTing] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MKTing].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MKTing] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MKTing] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MKTing] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MKTing] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MKTing] SET ARITHABORT OFF 
GO
ALTER DATABASE [MKTing] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MKTing] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MKTing] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MKTing] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MKTing] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MKTing] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MKTing] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MKTing] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MKTing] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MKTing] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MKTing] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MKTing] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MKTing] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MKTing] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MKTing] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MKTing] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MKTing] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MKTing] SET RECOVERY FULL 
GO
ALTER DATABASE [MKTing] SET  MULTI_USER 
GO
ALTER DATABASE [MKTing] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MKTing] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MKTing] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MKTing] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MKTing] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MKTing]
GO
/****** Object:  Table [dbo].[tbl_MKT_CustomerChanel]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_CustomerChanel](
	[Chanel_code] [nvarchar](50) NULL,
	[Chanel_name] [nvarchar](225) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Note] [nvarchar](225) NULL,
 CONSTRAINT [PK_tbl_CustomerChanel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_CustomerChaneltmp]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_CustomerChaneltmp](
	[Chanel_code] [nvarchar](50) NULL,
	[Chanel_name] [nvarchar](225) NULL,
	[Note] [nvarchar](225) NULL,
	[Select_channel] [bit] NOT NULL CONSTRAINT [DF_tbl_MKT_CustomerChaneltmp_Select_channel]  DEFAULT ((0)),
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_CustomerChaneltmp] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_DetailRpt_Phieuissue]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_DetailRpt_Phieuissue](
	[Username] [nvarchar](50) NULL,
	[stt] [nvarchar](50) NULL,
	[soluong] [float] NULL,
	[bangchu] [nvarchar](255) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tensanpham] [nvarchar](255) NULL,
	[Sophieu] [nvarchar](50) NULL,
	[thuhang] [bit] NOT NULL CONSTRAINT [DF_tbl_MKT_DetailRpt_Phieuissue_thuhang]  DEFAULT ((0)),
	[masanpham] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_MKT_Rptdetail_Phieuissue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_headRpt_Phieuissue]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_headRpt_Phieuissue](
	[Username] [nvarchar](50) NULL,
	[Nguoiyeucau] [nvarchar](50) NULL,
	[Ngaythang] [datetime] NULL,
	[Sophieu] [nvarchar](50) NULL,
	[Nguoinhancode] [nvarchar](255) NULL,
	[Nguoinhanname] [nvarchar](255) NULL,
	[Diachi] [nvarchar](255) NULL,
	[mucdich] [nvarchar](255) NULL,
	[dienthoai] [nvarchar](255) NULL,
	[seri] [nvarchar](255) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Barcode] [image] NULL,
	[ghichu] [nvarchar](255) NULL,
	[thuhang] [bit] NOT NULL CONSTRAINT [DF_tbl_MKT_headRpt_Phieuissue_thuhang]  DEFAULT ((0)),
 CONSTRAINT [PK_tbl_MKT_Rpt_Phieuissue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_IO_Programe]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_IO_Programe](
	[IO_number] [nvarchar](50) NULL,
	[IO_Name] [nvarchar](225) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ghichu] [nvarchar](225) NULL,
	[Sales_Org] [nvarchar](50) NULL,
	[Region] [nvarchar](50) NULL,
	[ChannelGroup] [nvarchar](50) NULL,
	[Budget] [float] NULL CONSTRAINT [DF_tbl_MKT_IO_Programe_Budget]  DEFAULT ((0)),
	[Avaiable_Budget] [float] NULL CONSTRAINT [DF_tbl_MKT_IO_Programe_Avaiable_Budget]  DEFAULT ((0)),
	[Spent_Budget] [float] NULL CONSTRAINT [DF_tbl_MKT_IO_Programe_Spended_Budget]  DEFAULT ((0)),
	[ProgrameIDDocno] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_IO_Programe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_IO_ProgrameTMP]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_IO_ProgrameTMP](
	[ProgrameIDDocno] [nvarchar](50) NULL,
	[IO_number] [nvarchar](50) NULL,
	[IO_Name] [nvarchar](225) NULL,
	[ghichu] [nvarchar](225) NULL,
	[Sales_Org] [nvarchar](50) NULL,
	[Region] [nvarchar](50) NULL,
	[ChannelGroup] [nvarchar](50) NULL,
	[Budget] [float] NULL,
	[Username] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tbl_MKT_IO_ProgrameTMP] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_khoMKT]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_khoMKT](
	[tenkho] [nvarchar](50) NULL,
	[makho] [nvarchar](10) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[diachikho] [nvarchar](50) NULL,
	[ghichu] [nvarchar](50) NULL,
	[storeright] [nvarchar](10) NULL,
 CONSTRAINT [PK_tbl_MKT_khoMKT] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_ListLoadhead]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_ListLoadhead](
	[LoadNumber] [nvarchar](50) NULL,
	[Date_Created] [datetime] NULL,
	[Created_by] [nvarchar](255) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[ShippingPoint] [nvarchar](50) NULL,
	[TransposterCode] [nvarchar](50) NULL,
	[TransposterName] [nvarchar](255) NULL,
	[Truckno] [nvarchar](255) NULL,
	[pallet] [float] NULL,
 CONSTRAINT [PK_tbl_MKt_ListLoadhead] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_ListLoadheadDetail]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_ListLoadheadDetail](
	[LoadNumber] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[ShippingPoint] [nvarchar](50) NULL,
	[Materiacode] [nvarchar](50) NULL,
	[Materialname] [nvarchar](255) NULL,
	[Issued] [float] NULL,
	[Serriload] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKt_ListLoadheadDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_Listphieudetail]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_Listphieudetail](
	[Gate_pass] [nvarchar](255) NULL,
	[Date_Received_Issued] [datetime] NULL,
	[Requested_by] [nvarchar](255) NULL,
	[Customer_SAP_Code] [nvarchar](50) NULL,
	[Receiver_by] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Tel] [nvarchar](255) NULL,
	[Purpose] [nvarchar](255) NULL,
	[Item] [float] NULL,
	[Materiacode] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Issued] [float] NULL,
	[Ngaytaophieu] [datetime] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MateriaSAPcode] [nvarchar](255) NULL,
	[Soluongdaxuat] [float] NULL,
	[Soluongconlai] [float] NULL,
	[Status] [nvarchar](50) NULL CONSTRAINT [DF_tbl_MKt_Listphieudetail_Status]  DEFAULT (N'CRT'),
	[Ngayhoanthanh] [datetime] NULL,
	[Username] [nvarchar](50) NULL,
	[Purposeid] [nvarchar](50) NULL,
	[Unit] [nvarchar](50) NULL,
	[ShippingPoint] [nvarchar](50) NULL,
	[Materialname] [nvarchar](255) NULL,
	[Loadingby] [nvarchar](50) NULL,
	[ShipmentNumber] [nvarchar](50) NULL,
	[Shipmentby] [nvarchar](50) NULL,
	[Tranposterby] [nvarchar](50) NULL,
	[Truck] [nvarchar](50) NULL,
	[Region] [nvarchar](50) NULL,
	[Completed_by] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[NetValue] [float] NULL,
	[Returnby] [nvarchar](255) NULL,
	[Returndate] [datetime] NULL,
	[ReturnQuantity] [float] NOT NULL CONSTRAINT [DF_tbl_MKt_Listphieudetail_ReturnQuantity]  DEFAULT ((0)),
	[Delivery_date] [datetime] NULL,
	[Issued_dated] [datetime] NULL,
	[Included_Shipment] [nvarchar](50) NULL,
	[pallet] [float] NULL,
	[Note] [nvarchar](255) NULL,
	[shiptocity] [nvarchar](50) NULL,
	[Return_reason] [nvarchar](255) NULL,
	[Returnrequest] [float] NULL,
 CONSTRAINT [PK_tbl_MKt_Listphieudetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_Listphieuhead]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_Listphieuhead](
	[Gate_pass] [nvarchar](255) NULL,
	[Date_Received_Issued] [datetime] NULL,
	[Requested_by] [nvarchar](255) NULL,
	[Customer_SAP_Code] [float] NULL,
	[Receiver_by] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Tel] [nvarchar](255) NULL,
	[Purpose] [nvarchar](255) NULL,
	[Ngaytaophieu] [datetime] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Purposeid] [nvarchar](50) NULL,
	[ShippingPoint] [nvarchar](50) NULL,
	[LoadNumber] [nvarchar](50) NULL,
	[completed] [bit] NOT NULL CONSTRAINT [DF_tbl_MKt_Listphieuhead_completed]  DEFAULT ((0)),
	[completedby] [nvarchar](50) NULL,
	[Tranposterby] [nvarchar](50) NULL,
	[Region] [nvarchar](50) NULL,
	[ShiptoCode] [float] NULL,
	[ShiptoName] [nvarchar](255) NULL,
	[ShiptoAddress] [nvarchar](255) NULL,
	[Note] [nvarchar](255) NULL,
	[Trucknumber] [nvarchar](255) NULL,
	[requestReturn] [bit] NOT NULL CONSTRAINT [DF_tbl_MKt_Listphieuhead_requestReturn]  DEFAULT ((0)),
 CONSTRAINT [PK_tbl_MKt_Listphieuhead] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_LoaddetailRpt]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_LoaddetailRpt](
	[Username] [nvarchar](50) NULL,
	[stt] [nvarchar](50) NULL,
	[soluong] [float] NULL,
	[bangchu] [nvarchar](255) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[materialcode] [nvarchar](255) NULL,
	[tensanpham] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_MKT_LoaddetailRpt] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_LoadHeadRpt]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_LoadHeadRpt](
	[username] [nvarchar](50) NULL,
	[Loadnumber] [nvarchar](50) NULL,
	[Ngaythang] [datetime] NULL,
	[shippingpoint] [nvarchar](50) NULL,
	[Loadcreatebby] [nvarchar](255) NULL,
	[codetransporter] [nvarchar](255) NULL,
	[nametransporter] [nvarchar](255) NULL,
	[seri] [nvarchar](255) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Barcode] [image] NULL,
	[gatepasslist] [nvarchar](500) NULL,
	[pallet] [float] NULL,
 CONSTRAINT [PK_tbl_MKT_LoadHeadRpt] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Nhacungungvantai]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Nhacungungvantai](
	[tenNVT] [nvarchar](225) NULL,
	[maNVT] [nvarchar](50) NULL,
	[diachiNVT] [nvarchar](225) NULL,
	[masothueNVT] [nvarchar](225) NULL,
	[dienthoaiNVT] [nvarchar](225) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tbl_MKTNhacungungvantai] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Palletrate]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Palletrate](
	[ITEM ] [nvarchar](255) NULL,
	[onPallet] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Payment_Aproval]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Payment_Aproval](
	[IO_number] [nvarchar](50) NULL,
	[ProgrameIDDocno] [nvarchar](50) NULL,
	[Customercode] [nvarchar](50) NULL,
	[CustomerName] [nvarchar](225) NULL,
	[CustomerAddress] [nvarchar](225) NULL,
	[AprovalBudget] [float] NULL,
	[costcenter] [nvarchar](50) NULL,
	[Account] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[payID] [int] NULL,
	[Approval] [nvarchar](50) NULL,
	[Requestby] [nvarchar](50) NULL,
	[Approvalby] [nvarchar](50) NULL,
	[Requsestdate] [datetime] NULL,
	[Approvaldate] [datetime] NULL,
 CONSTRAINT [PK_tbl_MKT_Payment_Aproval] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Payment_Aproval_head]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Payment_Aproval_head](
	[Requestby] [nvarchar](50) NULL,
	[IO_number] [nvarchar](50) NULL,
	[TotalAprovalBudget] [float] NULL,
	[costcenter] [nvarchar](50) NULL,
	[Account] [nvarchar](50) NULL,
	[payID] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[Approval] [nvarchar](50) NULL,
	[ProgrameIDDocno] [nvarchar](50) NULL,
	[ProgrameName] [nvarchar](225) NULL,
 CONSTRAINT [PK_tbl_MKT_Payment_Aproval_head] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Payment_AprovalTMP]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Payment_AprovalTMP](
	[IO_number] [nvarchar](50) NULL,
	[ProgrameIDDocno] [nvarchar](50) NULL,
	[Customercode] [nvarchar](50) NULL,
	[CustomerName] [nvarchar](225) NULL,
	[CustomerAddress] [nvarchar](225) NULL,
	[AprovalBudget] [float] NULL,
	[costcenter] [nvarchar](50) NULL,
	[Account] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKT_Payment_AprovalTMP] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_POdetail]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_POdetail](
	[POnumber] [nvarchar](255) NULL,
	[MateriaSAPcode] [nvarchar](255) NULL,
	[MateriaItemcode] [nvarchar](255) NULL,
	[Materialname] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Unit] [nvarchar](50) NULL,
	[QuantityOrder] [float] NULL,
	[DatePO] [datetime] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[BalanceQuantity] [float] NULL,
	[Username] [nvarchar](50) NULL,
	[Storelocation] [nvarchar](50) NULL,
	[StatusPO] [nvarchar](50) NULL,
	[RecieptedQuantity] [float] NOT NULL,
	[Unit_Price] [float] NULL,
	[Region] [nvarchar](50) NULL,
	[inputRate] [float] NULL,
 CONSTRAINT [PK_tbl_MKt_POdetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_POdetail_TMP]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_POdetail_TMP](
	[POnumber] [nvarchar](255) NULL,
	[MateriaSAPcode] [nvarchar](255) NULL,
	[MateriaItemcode] [nvarchar](255) NULL,
	[Materialname] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Unit] [nvarchar](50) NULL,
	[QuantityOrder] [float] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Storelocation] [nvarchar](50) NULL,
	[StatusPO] [nvarchar](50) NULL,
	[IOcode] [nvarchar](50) NULL,
	[IOname] [nvarchar](50) NULL,
	[Unit_Price] [float] NULL,
	[Region] [nvarchar](50) NULL,
	[inputRate] [float] NULL,
	[POdate] [datetime] NULL,
 CONSTRAINT [PK_tbl_MKt_POdetail_TMP] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_POhead]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_POhead](
	[PONumber] [nvarchar](255) NULL,
	[Created_by] [nvarchar](255) NULL,
	[DatePo] [datetime] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[StoreLocation] [nvarchar](50) NULL,
	[IOcode] [nvarchar](50) NULL,
	[IOname] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKt_POhead] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Programe]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Programe](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProgrameIDDocno] [nvarchar](50) NULL,
	[tenCT] [nvarchar](225) NULL,
	[Fromdate] [datetime] NULL,
	[Todate] [datetime] NULL,
	[ghichu] [nvarchar](225) NULL,
	[TotalBudget] [float] NULL,
	[UsedBudget] [float] NULL,
	[BalanceBudget] [float] NULL,
 CONSTRAINT [PK_tbl_MKT_Programe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Programepdfdata]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_MKT_Programepdfdata](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](225) NULL,
	[Contentype] [nvarchar](10) NULL,
	[Data] [varbinary](max) NULL,
	[ProgrameIDDocno] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKT_Programepdfdata] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_MKT_Programepriceproduct]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Programepriceproduct](
	[ProgrameIDDocno] [nvarchar](50) NOT NULL,
	[SAP_CODE] [nvarchar](255) NULL,
	[ITEM_Code] [nvarchar](255) NULL,
	[MATERIAL] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[UNIT] [nvarchar](255) NULL,
	[Price] [float] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tbl_MKT_Programepriceproduct] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_ProgramepriceproductTMP]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_ProgramepriceproductTMP](
	[SAP_CODE] [nvarchar](255) NULL,
	[ITEM_Code] [nvarchar](255) NULL,
	[MATERIAL] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[UNIT] [nvarchar](255) NULL,
	[Price] [float] NULL,
	[Username] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProgrameIDDocno] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKT_ProgramepriceproductTMP2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Region]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Region](
	[Region] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Note] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKT_Region] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_SaleOrg]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_SaleOrg](
	[SaleOrg] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Note] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKT_SaleOrg] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Soldtocode]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Soldtocode](
	[Customer] [nvarchar](50) NULL,
	[ShiptoCode] [nvarchar](50) NULL,
	[Soldtype] [bit] NOT NULL CONSTRAINT [DF_tbl_MKT_Soldtocode_Soldtype]  DEFAULT ((0)),
	[FullNameN] [nvarchar](225) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Telephone1] [nvarchar](225) NULL,
	[Note] [nvarchar](225) NULL,
	[District] [nvarchar](50) NULL,
	[SalesOrg] [nvarchar](50) NULL,
	[Street] [nvarchar](225) NULL,
	[City] [nvarchar](50) NULL,
	[Region] [nvarchar](50) NULL,
	[PaymentTerms] [nvarchar](50) NULL,
	[PriceList] [nvarchar](50) NULL,
	[KeyAcc] [nvarchar](50) NULL,
	[SalesDistrict] [nvarchar](50) NULL,
	[VATregistrationNo] [nvarchar](50) NULL,
	[Createdon] [datetime] NULL,
	[Createby] [nvarchar](50) NULL,
	[Chanel] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKT_khachhang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Stockcount]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Stockcount](
	[SAP_CODE] [nvarchar](255) NULL,
	[ITEM_Code] [nvarchar](255) NULL,
	[MATERIAL] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[UNIT] [nvarchar](255) NULL,
	[END_STOCK] [float] NULL,
	[Store_code] [nvarchar](10) NULL,
	[CountingDate] [datetime] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Idsub] [int] NULL,
	[Createdby] [nvarchar](50) NULL,
	[CountQuantity] [float] NULL,
	[Aproved] [bit] NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Aprovedby] [nvarchar](50) NULL,
	[AprovedDate] [datetime] NULL,
	[ActualEndatAproval] [float] NULL,
 CONSTRAINT [PK_tbl_MKT_Stockcount] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Stockend]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Stockend](
	[SAP_CODE] [nvarchar](255) NULL,
	[ITEM_Code] [nvarchar](255) NULL,
	[MATERIAL] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[UNIT] [nvarchar](255) NULL,
	[END_STOCK] [float] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Store_code] [nvarchar](10) NULL,
	[TransferingOUT] [float] NULL,
	[Ordered] [float] NULL CONSTRAINT [DF_tbl_MKT_Stockend_Ordered]  DEFAULT ((0)),
	[RegionBudgeted] [float] NOT NULL CONSTRAINT [DF_tbl_MKT_Stockend_RegionBudgeted]  DEFAULT ((0)),
	[ON_Hold] [float] NULL,
	[Quantity_Per_Pallet] [float] NULL,
	[End_Stock_By_Pallet] [float] NULL,
 CONSTRAINT [PK_tbl_MKT_Stockend] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_Stockenddailysave]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_Stockenddailysave](
	[SAP_CODE] [nvarchar](255) NULL,
	[ITEM_Code] [nvarchar](255) NULL,
	[MATERIAL] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[UNIT] [nvarchar](255) NULL,
	[END_STOCK] [float] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Store_code] [nvarchar](10) NULL,
	[TransferingOUT] [float] NULL,
	[ON_Hold] [float] NULL,
	[End_date] [date] NULL,
 CONSTRAINT [PK_tbl_MKT_Stockenddailysave] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_StockendRegionBudget]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_StockendRegionBudget](
	[Region] [nvarchar](50) NULL,
	[SAP_CODE] [nvarchar](255) NULL,
	[ITEM_Code] [nvarchar](255) NULL,
	[MATERIAL] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[UNIT] [nvarchar](255) NULL,
	[QuantityInputbyPO] [float] NULL,
	[QuantityOutput] [float] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[QuantityInputbyReturn] [float] NULL,
	[QuantitybyDevice] [float] NULL,
	[Note] [nvarchar](255) NULL,
	[Regionchangedate] [datetime] NULL,
	[Store_code] [nvarchar](10) NULL,
	[Gate_pass] [nvarchar](255) NULL,
	[POnumber] [nvarchar](255) NULL,
	[idsub] [int] NULL,
	[QuantityReceipt] [float] NULL,
	[DocumentNumber] [nvarchar](255) NULL,
	[DnNumber] [nvarchar](255) NULL,
	[QuantityInputbytransferin] [float] NULL,
	[Createdate] [datetime] NULL,
 CONSTRAINT [PK_tbl_MKT_StockendbudgetbyRegion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_StockendTMP]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_StockendTMP](
	[SAP_CODE] [nvarchar](255) NULL,
	[ITEM_Code] [nvarchar](255) NULL,
	[MATERIAL] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[UNIT] [nvarchar](255) NULL,
	[END_STOCK] [float] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Store_code] [nvarchar](10) NULL,
	[Username] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKT_StockendTMP] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_StoreRight]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_StoreRight](
	[makho] [nvarchar](10) NULL,
	[storeright] [nvarchar](10) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tbl_MKT_StoreRight] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_TransferINdetail]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_TransferINdetail](
	[Tranfernumber] [nvarchar](255) NULL,
	[MateriaSAPcode] [nvarchar](255) NULL,
	[MateriaItemcode] [nvarchar](255) NULL,
	[Materialname] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Unit] [nvarchar](50) NULL,
	[Transfer_OUT_Date] [datetime] NULL,
	[Transfer_IN_Date] [datetime] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Store_OUT] [nvarchar](50) NULL,
	[Store_IN] [nvarchar](50) NULL,
	[Reciepted_Quantity] [float] NULL,
	[IssueIDsub] [int] NULL,
	[Region] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKt_TransferINdetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_Transferindetailrpt]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_Transferindetailrpt](
	[stt] [nvarchar](50) NULL,
	[soluong] [float] NULL,
	[username] [nvarchar](50) NULL,
	[tensanpham] [nvarchar](255) NULL,
	[bangchu] [nvarchar](255) NULL,
	[masanpham] [nvarchar](255) NULL,
	[donvi] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tbl_MKt_Transferindetailrpt] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_TransferinoutHEADrpt]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_TransferinoutHEADrpt](
	[username] [nvarchar](50) NULL,
	[Tranfernumber] [nvarchar](255) NULL,
	[Created_by] [nvarchar](255) NULL,
	[Transfer_OUT_Date] [datetime] NULL,
	[Transfer_IN_Date] [datetime] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Store_OUT] [nvarchar](50) NULL,
	[Store_IN] [nvarchar](50) NULL,
	[Trucknumber] [nvarchar](50) NULL,
	[Seri] [nvarchar](255) NULL,
	[Barcode] [image] NULL,
	[Subid] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKt_TransferoutHEADrpt] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_Transferoutdetail]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_Transferoutdetail](
	[Tranfernumber] [nvarchar](255) NULL,
	[MateriaSAPcode] [nvarchar](255) NULL,
	[MateriaItemcode] [nvarchar](255) NULL,
	[Materialname] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Unit] [nvarchar](50) NULL,
	[Quantity] [float] NULL,
	[Transfer_OUT_Date] [datetime] NULL,
	[Transfer_IN_Date] [datetime] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Store_OUT] [nvarchar](50) NULL,
	[Store_IN] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[AvaiableQuantity] [float] NULL,
	[Reciepted_Quantity] [float] NULL,
 CONSTRAINT [PK_tbl_MKt_Transferoutdetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_Transferoutdetailrpt]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_Transferoutdetailrpt](
	[stt] [nvarchar](50) NULL,
	[soluong] [float] NULL,
	[username] [nvarchar](50) NULL,
	[tensanpham] [nvarchar](255) NULL,
	[bangchu] [nvarchar](255) NULL,
	[masanpham] [nvarchar](255) NULL,
	[donvi] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tbl_MKt_Transferoutdetailrpt] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_TransferoutdetailTMP]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_TransferoutdetailTMP](
	[Tranfernumber] [nvarchar](255) NULL,
	[MateriaSAPcode] [nvarchar](255) NULL,
	[MateriaItemcode] [nvarchar](255) NULL,
	[Materialname] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Unit] [nvarchar](50) NULL,
	[Quantity] [float] NULL,
	[Transfer_OUT_Date] [datetime] NULL,
	[Transfer_IN_Date] [datetime] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Store_OUT] [nvarchar](50) NULL,
	[Store_IN] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[AvaiableQuantity] [float] NULL,
	[QuantityInConfirm] [float] NULL,
 CONSTRAINT [PK_tbl_MKt_TransferoutdetailTMP] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_TransferoutHEAD]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_TransferoutHEAD](
	[Tranfernumber] [nvarchar](255) NULL,
	[Created_by] [nvarchar](255) NULL,
	[Transfer_OUT_Date] [datetime] NULL,
	[Transfer_IN_Date] [datetime] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Store_OUT] [nvarchar](50) NULL,
	[Store_IN] [nvarchar](50) NULL,
	[Trucknumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKt_TransferoutHEAD] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKT_WHissueHeadRpt]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKT_WHissueHeadRpt](
	[username] [nvarchar](50) NULL,
	[Loadnumber] [nvarchar](50) NULL,
	[Ngaythang] [datetime] NULL,
	[Storeman] [nvarchar](255) NULL,
	[Subid] [nvarchar](255) NULL,
	[seri] [nvarchar](255) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Barcode] [image] NULL,
	[shippingpoint] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MKT_WHissueHeadRpt] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_MKt_WHstoreissue]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MKt_WHstoreissue](
	[LoadNumber] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[ShippingPoint] [nvarchar](50) NULL,
	[Materiacode] [nvarchar](50) NULL,
	[Materialname] [nvarchar](50) NULL,
	[IssueDate] [datetime] NULL,
	[Issued] [float] NULL,
	[Serriload] [nvarchar](50) NULL,
	[IssueBy] [nvarchar](50) NULL,
	[IssueIDsub] [int] NULL,
	[RecieptQuantity] [float] NULL,
	[Recieptby] [nvarchar](50) NULL,
	[POnumber] [nvarchar](50) NULL,
	[Unit] [nvarchar](255) NULL,
	[MateriaItemcode] [nvarchar](50) NULL,
	[date_input_output] [datetime] NULL,
	[DNNumber] [nvarchar](50) NULL,
	[Document_number] [nvarchar](50) NULL,
	[Transfer_number] [nvarchar](50) NULL,
	[Doc_date] [datetime] NULL,
 CONSTRAINT [PK_tbl_MKt_WHstoreissue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Temp]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Temp](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Version] [int] NULL,
	[Region] [nvarchar](50) NULL,
	[Username] [nchar](225) NULL,
	[Password] [nchar](225) NULL,
	[Name] [nvarchar](50) NULL,
	[System] [bit] NOT NULL DEFAULT ((0)),
	[MakettingRight] [bit] NOT NULL DEFAULT ((1)),
	[storeright] [nvarchar](10) NULL,
	[LoadRight] [bit] NOT NULL DEFAULT ((0)),
	[WareHouseRight] [bit] NOT NULL DEFAULT ((0)),
	[ReportsRight] [bit] NOT NULL DEFAULT ((0)),
	[Inventory] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_Inventory]  DEFAULT ((0)),
	[InventoryAprroval] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_InventoryAprroval]  DEFAULT ((0)),
	[StoreLocationmanage] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_StoreLocationmanage]  DEFAULT ((0)),
	[addNewProduct] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_addNewProduct]  DEFAULT ((0)),
	[IOprogamecreatRight] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_IOprogamecreatRight]  DEFAULT ((0)),
	[Loadcreated] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_Loadcreated]  DEFAULT ((0)),
	[StoreIssue] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_StoreIssue]  DEFAULT ((0)),
	[TransferOut] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_TransferOut]  DEFAULT ((0)),
	[TransferIN] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_TransferIN]  DEFAULT ((0)),
	[ChanelManage] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_ChannelManage]  DEFAULT ((0)),
	[IOmanageright] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_IOmanageright]  DEFAULT ((0)),
	[SetPOSMprogrameright] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_SetPOSMprogrameright]  DEFAULT ((0)),
	[ViewProgramePDFright] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_ViewProgramePDFright]  DEFAULT ((0)),
	[AprovalPaymentRequestright] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_AprovalPaymentRequestright]  DEFAULT ((0)),
	[updateGatePassDeliveredright] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_updateGatePassDeliveredright]  DEFAULT ((0)),
	[RequestpaymentApproval] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_RequestpaymentApproval]  DEFAULT ((0)),
	[uploadBeginStoreright] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_uploadBeginStoreright]  DEFAULT ((0)),
	[ControlUsername] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_UserAdminright]  DEFAULT ((0)),
	[CustomerEdit] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_CustomerEdit]  DEFAULT ((0)),
	[CustomerUploadright] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_CustomerUploadright]  DEFAULT ((0)),
	[SalesLocationright] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_SalesLocationright]  DEFAULT ((0)),
	[SalesRegionManageright] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_SalesRegionManageright]  DEFAULT ((0)),
	[ChannelsalesManageright] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_ChannelsalesManageright]  DEFAULT ((0)),
	[ReturnTicket] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_ReturnTicket]  DEFAULT ((0)),
	[doMoreReturnticket] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_doMoreReturnticket]  DEFAULT ((0)),
	[doViewcounting] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_doViewcounting]  DEFAULT ((0)),
	[changeProduct] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_change_Product]  DEFAULT ((0)),
	[deleteProduct] [bit] NOT NULL CONSTRAINT [DF_tbl_Temp_delete_Product]  DEFAULT ((0)),
 CONSTRAINT [PK_temp] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_MKT_CustomerChanel] ON 

INSERT [dbo].[tbl_MKT_CustomerChanel] ([Chanel_code], [Chanel_name], [id], [Note]) VALUES (N'ATW', N'At work', 3, N'At work')
INSERT [dbo].[tbl_MKT_CustomerChanel] ([Chanel_code], [Chanel_name], [id], [Note]) VALUES (N'E&D', N'Eating&Drinking ', 4, N'Eating&Drinking ')
INSERT [dbo].[tbl_MKT_CustomerChanel] ([Chanel_code], [Chanel_name], [id], [Note]) VALUES (N'EDU', N'Education', 5, N'Education')
INSERT [dbo].[tbl_MKT_CustomerChanel] ([Chanel_code], [Chanel_name], [id], [Note]) VALUES (N'ERL', N'Entertainment ', 6, N'Entertainment ')
INSERT [dbo].[tbl_MKT_CustomerChanel] ([Chanel_code], [Chanel_name], [id], [Note]) VALUES (N'GRO', N'Grocery', 7, N'Grocery')
INSERT [dbo].[tbl_MKT_CustomerChanel] ([Chanel_code], [Chanel_name], [id], [Note]) VALUES (N'DAS', N'Exclusive Dasani ', 8, N'Exclusive Dasani ')
INSERT [dbo].[tbl_MKT_CustomerChanel] ([Chanel_code], [Chanel_name], [id], [Note]) VALUES (N'OTH', N'Others', 9, N'Others')
INSERT [dbo].[tbl_MKT_CustomerChanel] ([Chanel_code], [Chanel_name], [id], [Note]) VALUES (N'SUP', N'Super Market', 10, N'Super Market')
INSERT [dbo].[tbl_MKT_CustomerChanel] ([Chanel_code], [Chanel_name], [id], [Note]) VALUES (N'TTH', N'Travel, Transportation, Hotel', 11, N'Travel, Transportation, Hotel')
SET IDENTITY_INSERT [dbo].[tbl_MKT_CustomerChanel] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ON 

INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'ATW', N'At work', N'At work', 0, 60, N'tr1')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'E&D', N'Eating&Drinking ', N'Eating&Drinking ', 0, 61, N'tr1')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'EDU', N'Education', N'Education', 0, 62, N'tr1')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'ERL', N'Entertainment ', N'Entertainment ', 0, 63, N'tr1')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'GRO', N'Grocery', N'Grocery', 0, 64, N'tr1')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'DAS', N'Exclusive Dasani ', N'Exclusive Dasani ', 0, 65, N'tr1')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'OTH', N'Others', N'Others', 0, 66, N'tr1')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'SUP', N'Super Market', N'Super Market', 0, 67, N'tr1')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'TTH', N'Travel, Transportation, Hotel', N'Travel, Transportation, Hotel', 0, 68, N'tr1')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'ATW', N'At work', N'At work', 0, 2068, N'vnttthuyen')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'E&D', N'Eating&Drinking ', N'Eating&Drinking ', 1, 2069, N'vnttthuyen')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'EDU', N'Education', N'Education', 1, 2070, N'vnttthuyen')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'ERL', N'Entertainment ', N'Entertainment ', 1, 2071, N'vnttthuyen')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'GRO', N'Grocery', N'Grocery', 1, 2072, N'vnttthuyen')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'DAS', N'Exclusive Dasani ', N'Exclusive Dasani ', 1, 2073, N'vnttthuyen')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'OTH', N'Others', N'Others', 1, 2074, N'vnttthuyen')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'SUP', N'Super Market', N'Super Market', 1, 2075, N'vnttthuyen')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'TTH', N'Travel, Transportation, Hotel', N'Travel, Transportation, Hotel', 1, 2076, N'vnttthuyen')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'ATW', N'At work', N'At work', 0, 2653, N'vnvanle')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'E&D', N'Eating&Drinking ', N'Eating&Drinking ', 1, 2654, N'vnvanle')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'EDU', N'Education', N'Education', 0, 2655, N'vnvanle')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'ERL', N'Entertainment ', N'Entertainment ', 0, 2656, N'vnvanle')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'GRO', N'Grocery', N'Grocery', 1, 2657, N'vnvanle')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'DAS', N'Exclusive Dasani ', N'Exclusive Dasani ', 0, 2658, N'vnvanle')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'OTH', N'Others', N'Others', 1, 2659, N'vnvanle')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'SUP', N'Super Market', N'Super Market', 0, 2660, N'vnvanle')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'TTH', N'Travel, Transportation, Hotel', N'Travel, Transportation, Hotel', 0, 2661, N'vnvanle')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'ATW', N'At work', N'At work', 0, 2662, N'lttvan')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'E&D', N'Eating&Drinking ', N'Eating&Drinking ', 0, 2663, N'lttvan')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'EDU', N'Education', N'Education', 0, 2664, N'lttvan')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'ERL', N'Entertainment ', N'Entertainment ', 0, 2665, N'lttvan')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'GRO', N'Grocery', N'Grocery', 0, 2666, N'lttvan')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'DAS', N'Exclusive Dasani ', N'Exclusive Dasani ', 0, 2667, N'lttvan')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'OTH', N'Others', N'Others', 1, 2668, N'lttvan')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'SUP', N'Super Market', N'Super Market', 0, 2669, N'lttvan')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'TTH', N'Travel, Transportation, Hotel', N'Travel, Transportation, Hotel', 0, 2670, N'lttvan')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'ATW', N'At work', N'At work', 0, 2671, N'vndhuong')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'E&D', N'Eating&Drinking ', N'Eating&Drinking ', 0, 2672, N'vndhuong')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'EDU', N'Education', N'Education', 0, 2673, N'vndhuong')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'ERL', N'Entertainment ', N'Entertainment ', 0, 2674, N'vndhuong')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'GRO', N'Grocery', N'Grocery', 1, 2675, N'vndhuong')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'DAS', N'Exclusive Dasani ', N'Exclusive Dasani ', 0, 2676, N'vndhuong')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'OTH', N'Others', N'Others', 0, 2677, N'vndhuong')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'SUP', N'Super Market', N'Super Market', 0, 2678, N'vndhuong')
INSERT [dbo].[tbl_MKT_CustomerChaneltmp] ([Chanel_code], [Chanel_name], [Note], [Select_channel], [ID], [username]) VALUES (N'TTH', N'Travel, Transportation, Hotel', N'Travel, Transportation, Hotel', 0, 2679, N'vndhuong')
SET IDENTITY_INSERT [dbo].[tbl_MKT_CustomerChaneltmp] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKT_DetailRpt_Phieuissue] ON 

INSERT [dbo].[tbl_MKT_DetailRpt_Phieuissue] ([Username], [stt], [soluong], [bangchu], [id], [tensanpham], [Sophieu], [thuhang], [masanpham]) VALUES (N'tr1', N'1', 12, N'Mười hai', 63501, N'adfasf', NULL, 0, N'13')
INSERT [dbo].[tbl_MKT_DetailRpt_Phieuissue] ([Username], [stt], [soluong], [bangchu], [id], [tensanpham], [Sophieu], [thuhang], [masanpham]) VALUES (N'tr1', N'2', 1, N'Một', 63502, N'adfasf', NULL, 0, N'13')
SET IDENTITY_INSERT [dbo].[tbl_MKT_DetailRpt_Phieuissue] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ON 

INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'vnttthuyen', N'Tạ Thị Thu Huyền', CAST(N'2019-12-04 00:00:00.000' AS DateTime), N'23315', N'70147347', N'CÔNG TY CỔ PHẦN TRUNG TÂM CÔNG NGHỆ PHẦN MỀM THÁI NGUYÊN ', N' TỔ 11 PHƯỜNG TÂN THỊNH ,THÀNH PHỐ THÁI NGUYÊN ,TỈNH THÁI NGUYÊN - VIỆT NAM', N'Regional LKA 2019', N'2802211424', N'NWV10123315', 13854, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003614944415468438D8D01AAED3814C3EEFE37FD867C1008E1742208F6B15DFAFB7BE4F7FBFD7BF8E2CC3B9E71D60D0AED7AA37868B7EE66607F58DDFA666556E8EEE06DFBDB4D66C5C357466EC5BFF0BC5C3F33CEBCE31967DDA0D0AE378A8776EB6E06F687D5AD6F566685EE0EDEB6BFDD64563C7C65E456FC0BCFCBF533E3CC3B9E71D60D0AED7AA37868B7EE66607F58DDFA666556E8EEE06DFBDB4D66C5C357466EC5BFF0BC5C3F33CEBCE31967DDA0D0AE378A8776EB6E06F687D5AD6F566685EE0EDEB6BFDD64563C7C65E456FC0BCFCBF533E3CC3B9E71D60D0AED7AA37868B7EE66607F58DDFA666556E8EEE06DFBDB4D66C5C357466EC5BFF0BC5C3F33CEBCE31967DDA0D0AE378A8776EB6E06F687D5AD6F566685EE0EDEB6BFDD64563C7C65E456FC0BCFCBF533E3CC3B9E71D60D0AED7AA37868B7EE66607F58DDFA666556E8EEE06DFBDB4D66C5C357466EC5BFF0BC5C3F33CEBCE31967DDA0D0AE378A8776EB6E06F687D5AD6F566685EE0EDEB6BFDD64563C7C65E456FC0BCFCBF533E3CC3B9E71D60D0AED7AA37868B7EE66607F58DDFA666556E8EEE06DFBDB4D66C5C357466EC5BFF0BC5C3F33CEBCE31967DDA0D0AE378A8776EB6E06F687D5AD6F566685EE0EDEB6BFDD64563C7C65E456FC0BCFCBF533E3CC3B9E71D60D0AED7AA37868B7EE66607F58DDFA666556E8EEE06DFBDB4D66C5C357466EC5BFF0BC5C3F33CEBCE31967DDA0D0AE378A8776EB6E06F687D5AD6F566685EE0EDEB6BFDD64563C7C65E456FC0BCFCBF533E3CC3B9E71D60D0AED7AA37868B7EE66607F58DDFA666556E8EEE06DFBDB4D66C5C357466EC5BFF0BC5C3F33CEBCE31967DDA0D0AE378A8776EB6E06F687D5AD6F566685EE0EDEB6BFDD64563C7C65E456FC0BCFCBF533E3CC3B9E71D60D0AED7AA37868B7EE66607F58DDFA666556E8EEE06DFBDB4D66C5C357466EC5BFF0BC5C3F33CEBCE31967DDA0D0AE378A8776EB6E06F687D5AD6F566685EE0EDEB6BFDD64563C7C65E456FC0BCFCBF533E3CC3B9E71D60D0AED7AA37868B7EE66607F58DDFA666556E8EEE06DFBDB4D66C5C357466EC5BFF0BC5C3F33CEBCE31967DDA0D0AE378A8776EB6E06F687D5AD6F566685EE0EDEB6BFDD64563C7C65E456FC0BCFCBF533E3CC3B9E71D60D0AED7AA37868B7EE66607F58DDFA666556E8EEE06DFBDB4D66C5C357466EC5FF3F7F7FFF0194661971879B36F70000000049454E44AE426082, N'LKA -Payment  KA DSD -ADM Duy- liên hệ 0985568123 -anh Huy', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'dvthuy', N'Dinh Thi Thu Huong', CAST(N'2020-03-24 00:00:00.000' AS DateTime), N'37168', N'70590651', N'CÔNG TY CỔ PHẦN ĐẦU TƯ KINH DOANH TỔNG HỢP NHẬT THÀNH', N'SỐ 15 ĐƯỜNG LÊ QUANG ĐẠO  - PHƯỜNG PHÚ ĐÔ - ,QUẬN NAM TỪ LIÊM ,Hà Nội', N'POSM Window 3 2019', N'TRẦN ANH HÒA: 0982 799 988', N'HNV10137168', 24531, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003524944415468438D8D01AAE5400CC3DEFD2FFD972C0884893B110C4D6487FEFE8EFC7EBFFF8F39B17317DAAD3DCFD86527BDC96CDBD381E7A165BE63CE1C9CD9C3CB7DDDB7DE90FB80C3FBCB7CE1DCDC7E66ECDC85766BCF3376D9496F32DBF674E0796899EF98330767F6F0725FF7AD37E43EE0F0FE325F3837B79F193B77A1DDDAF38C5D76D29BCCB63D1D781E5AE63BE6CCC1993DBCDCD77DEB0DB90F38BCBFCC17CECDED67C6CE5D68B7F63C63979DF426B36D4F079E8796F98E397370660F2FF775DF7A43EE030EEF2FF3857373FB99B17317DAAD3DCFD86527BDC96CDBD381E7A165BE63CE1C9CD9C3CB7DDDB7DE90FB80C3FBCB7CE1DCDC7E66ECDC85766BCF3376D9496F32DBF674E0796899EF98330767F6F0725FF7AD37E43EE0F0FE325F3837B79F193B77A1DDDAF38C5D76D29BCCB63D1D781E5AE63BE6CCC1993DBCDCD77DEB0DB90F38BCBFCC17CECDED67C6CE5D68B7F63C63979DF426B36D4F079E8796F98E397370660F2FF775DF7A43EE030EEF2FF3857373FB99B17317DAAD3DCFD86527BDC96CDBD381E7A165BE63CE1C9CD9C3CB7DDDB7DE90FB80C3FBCB7CE1DCDC7E66ECDC85766BCF3376D9496F32DBF674E0796899EF98330767F6F0725FF7AD37E43EE0F0FE325F3837B79F193B77A1DDDAF38C5D76D29BCCB63D1D781E5AE63BE6CCC1993DBCDCD77DEB0DB90F38BCBFCC17CECDED67C6CE5D68B7F63C63979DF426B36D4F079E8796F98E397370660F2FF775DF7A43EE030EEF2FF3857373FB99B17317DAAD3DCFD86527BDC96CDBD381E7A165BE63CE1C9CD9C3CB7DDDB7DE90FB80C3FBCB7CE1DCDC7E66ECDC85766BCF3376D9496F32DBF674E0796899EF98330767F6F0725FF7AD37E43EE0F0FE325F3837B79F193B77A1DDDAF38C5D76D29BCCB63D1D781E5AE63BE6CCC1993DBCDCD77DEB0DB90F38BCBFCC17CECDED67C6CE5D68B7F63C63979DF426B36D4F079E8796F98E397370660F2FF775DF7A43EE030EEF2FF3857373FB99B17317DAAD3DCFD86527BDC96CDBD381E7A165BE63CE1C9CD9C3CB7DDDB7DE90FB80C3FBCB7CE1DCDC7E66ECDC85766BCF3376D9496F32DBF674E0796899EF98330767F6F0725FF7AD37E43EE0F0FE325F3837B79F193B77A1DDDAF38C5D76D29BCCB63D1D781E5AE63BE6CCC1993DBCDCD77DEB0DB90F38BCBFCC6FFEFEFE01A1076E2A7AC5C2F50000000049454E44AE426082, N'POSM Coke Energy Window 3 2019', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'dvthuy', N'Dinh Thi Thu Huong', CAST(N'2020-03-25 00:00:00.000' AS DateTime), N'37214', N'70590651', N'CÔNG TY CỔ PHẦN ĐẦU TƯ KINH DOANH TỔNG HỢP NHẬT THÀNH', N'SỐ 15 ĐƯỜNG LÊ QUANG ĐẠO  - PHƯỜNG PHÚ ĐÔ - ,QUẬN NAM TỪ LIÊM ,Hà Nội', N'Regional focus 2020', N'TRẦN ANH HÒA: 0982 799 988', N'HNV10137214', 24532, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003594944415468438D8D018A6D4908C5DEFE37DD437D0884A0770C146A8E52BFBF23BFDFEFDFA32F76DE85EDD69E67ECBA536F9A4D731DB87F6C99EFE89B4333C07DED32E35CB70C9C010EEF4A7FE1BC397D66ECBC0BDBAD3DCFD875A7DE349BE63A70FFD832DFD137876680FBDA65C6B96E1938031CDE95FEC27973FACCD87917B65B7B9EB1EB4EBD6936CD75E0FEB165BEA36F0ECD00F7B5CB8C73DD32700638BC2BFD85F3E6F499B1F32E6CB7F63C63D79D7AD36C9AEBC0FD63CB7C47DF1C9A01EE6B9719E7BA65E00C707857FA0BE7CDE93363E75DD86EED79C6AE3BF5A6D934D781FBC796F98EBE393403DCD72E33CE75CBC019E0F0AEF417CE9BD367C6CEBBB0DDDAF38C5D77EA4DB369AE03F78F2DF31D7D736806B8AF5D669CEB968133C0E15DE92F9C37A7CF8C9D7761BBB5E719BBEED49B66D35C07EE1F5BE63BFAE6D00C705FBBCC38D72D036780C3BBD25F386F4E9F193BEFC2766BCF3376DDA937CDA6B90EDC3FB6CC77F4CDA119E0BE769971AE5B06CE008777A5BF70DE9C3E3376DE85EDD69E67ECBA536F9A4D731DB87F6C99EFE89B4333C07DED32E35CB70C9C010EEF4A7FE1BC397D66ECBC0BDBAD3DCFD875A7DE349BE63A70FFD832DFD137876680FBDA65C6B96E1938031CDE95FEC27973FACCD87917B65B7B9EB1EB4EBD6936CD75E0FEB165BEA36F0ECD00F7B5CB8C73DD32700638BC2BFD85F3E6F499B1F32E6CB7F63C63D79D7AD36C9AEBC0FD63CB7C47DF1C9A01EE6B9719E7BA65E00C707857FA0BE7CDE93363E75DD86EED79C6AE3BF5A6D934D781FBC796F98EBE393403DCD72E33CE75CBC019E0F0AEF417CE9BD367C6CEBBB0DDDAF38C5D77EA4DB369AE03F78F2DF31D7D736806B8AF5D669CEB968133C0E15DE92F9C37A7CF8C9D7761BBB5E719BBEED49B66D35C07EE1F5BE63BFAE6D00C705FBBCC38D72D036780C3BBD25F386F4E9F193BEFC2766BCF3376DDA937CDA6B90EDC3FB6CC77F4CDA119E0BE769971AE5B06CE008777A5BF70DE9C3E3376DE85EDD69E67ECBA536F9A4D731DB87F6C99EFE89B4333C07DED32E35CB70C9C010EEF4A7FE1BC397D66ECBC0BDBAD3DCFD875A7DE349BE63A70FFD832DFD137876680FBDA65C6B96E1938031CDE95FEC27973FACCD87917B65B7B9EB1EB4EBD6936CD75E0FEB165BEA36F0ECD00F7B5CB8C73DD32700638BC2BFDFFF3F7F71FADC68AFFF27FAE5B0000000049454E44AE426082, N'MUA 4T SAN PHAM NUTRI/SPLASH/TEPPY/FUZE TANG 1 AO MUA NUTRI', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'dvthuy', N'Dinh Thi Thu Huong', CAST(N'2020-03-26 00:00:00.000' AS DateTime), N'38320', N'70590651', N'CÔNG TY CỔ PHẦN ĐẦU TƯ KINH DOANH TỔNG HỢP NHẬT THÀNH', N'SỐ 15 ĐƯỜNG LÊ QUANG ĐẠO  - PHƯỜNG PHÚ ĐÔ - ,QUẬN NAM TỪ LIÊM ,Hà Nội', N'Coke Energy 2020', N'TRẦN ANH HÒA: 0982 799 988', N'HNV10138320', 24533, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003584944415468438D8D018A65310CC3DEFD2FFD970C088471BA119438B643BFDF91EFFBFE1E3AB1E72E6CB7F679C65E76D23799B53D3DB01EB6CC77E8CC99AF7CB864782D0376BCCC87D661A22F9C9BED3363CF5DD86EEDF38CBDECA46F326B7B7A603D6C99EFD099335FF970C9F05A06EC78990FADC3445F3837DB67C69EBBB0DDDAE7197BD949DF64D6F6F4C07AD832DFA13367BEF2E192E1B50CD8F1321F5A8789BE706EB6CF8C3D7761BBB5CF33F6B293BEC9ACEDE981F5B065BE4367CE7CE5C325C36B19B0E3653EB40E137DE1DC6C9F197BEEC2766B9F67EC65277D9359DBD303EB61CB7C87CE9CF9CA874B86D73260C7CB7C681D26FAC2B9D93E33F6DC85EDD63ECFD8CB4EFA26B3B6A707D6C396F90E9D39F3950F970CAF65C08E97F9D03A4CF48573B37D66ECB90BDBAD7D9EB1979DF44D666D4F0FAC872DF31D3A73E62B1F2E195ECB801D2FF3A17598E80BE766FBCCD87317B65BFB3C632F3BE99BCCDA9E1E580F5BE63B74E6CC573E5C32BC96013B5EE643EB30D117CECDF699B1E72E6CB7F679C65E76D23799B53D3DB01EB6CC77E8CC99AF7CB864782D0376BCCC87D661A22F9C9BED3363CF5DD86EEDF38CBDECA46F326B7B7A603D6C99EFD099335FF970C9F05A06EC78990FADC3445F3837DB67C69EBBB0DDDAE7197BD949DF64D6F6F4C07AD832DFA13367BEF2E192E1B50CD8F1321F5A8789BE706EB6CF8C3D7761BBB5CF33F6B293BEC9ACEDE981F5B065BE4367CE7CE5C325C36B19B0E3653EB40E137DE1DC6C9F197BEEC2766B9F67EC65277D9359DBD303EB61CB7C87CE9CF9CA874B86D73260C7CB7C681D26FAC2B9D93E33F6DC85EDD63ECFD8CB4EFA26B3B6A707D6C396F90E9D39F3950F970CAF65C08E97F9D03A4CF48573B37D66ECB90BDBAD7D9EB1979DF44D666D4F0FAC872DF31D3A73E62B1F2E195ECB801D2FF3A17598E80BE766FBCCD87317B65BFB3C632F3BE99BCCDA9E1E580F5BE63B74E6CC573E5C32BC96013B5EE643EB30D117CECDF699B1E72E6CB7F679C65E76D23799B53D3DB01EB6CC77E8CC99AF7CB864782D0376BCCC87D661A22F9C9BED3363CF5DD86EEDF38CBDECA46F326B7B7A603D6C99EFD099335FF970C9F05A06EC78990FADC3445F3837DB67C69EBBB0DDDAE7197BD949DF64D6F6F4C07AD832DFA13367BEF2E192E1B50CD8F1321F5A8789FE3FBFDF3F21FC197181CF951C0000000049454E44AE426082, N'Trả thưởng chương trình Game Coke Energy ', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'dvthuy', N'Dinh Thi Thu Huong', CAST(N'2020-03-27 00:00:00.000' AS DateTime), N'39226', N'70590651', N'CÔNG TY CỔ PHẦN ĐẦU TƯ KINH DOANH TỔNG HỢP NHẬT THÀNH', N'SỐ 15 ĐƯỜNG LÊ QUANG ĐẠO  - PHƯỜNG PHÚ ĐÔ - ,QUẬN NAM TỪ LIÊM ,Hà Nội', N'Regional focus 2020', N'TRẦN ANH HÒA: 0982 799 988', N'HNV10139226', 24534, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000034D4944415468438D8D01AA6D4908C4EEFE37FD86331008A1E47740BA8C4AFFFE1EF9FD7EFF17B9D87917AE5B7BCAD875A7DE74B6FA3A70FEB866BE2377DED765966FA65F7B9D833DE0F07EC92F3C6FAECF8C9D77E1BAB5A78C5D77EA4D67ABAF03E78F6BE63B72E77D5D66F966FAB5D739D8030EEF97FCC2F3E6FACCD87917AE5B7BCAD875A7DE74B6FA3A70FEB866BE2377DED765966FA65F7B9D833DE0F07EC92F3C6FAECF8C9D77E1BAB5A78C5D77EA4D67ABAF03E78F6BE63B72E77D5D66F966FAB5D739D8030EEF97FCC2F3E6FACCD87917AE5B7BCAD875A7DE74B6FA3A70FEB866BE2377DED765966FA65F7B9D833DE0F07EC92F3C6FAECF8C9D77E1BAB5A78C5D77EA4D67ABAF03E78F6BE63B72E77D5D66F966FAB5D739D8030EEF97FCC2F3E6FACCD87917AE5B7BCAD875A7DE74B6FA3A70FEB866BE2377DED765966FA65F7B9D833DE0F07EC92F3C6FAECF8C9D77E1BAB5A78C5D77EA4D67ABAF03E78F6BE63B72E77D5D66F966FAB5D739D8030EEF97FCC2F3E6FACCD87917AE5B7BCAD875A7DE74B6FA3A70FEB866BE2377DED765966FA65F7B9D833DE0F07EC92F3C6FAECF8C9D77E1BAB5A78C5D77EA4D67ABAF03E78F6BE63B72E77D5D66F966FAB5D739D8030EEF97FCC2F3E6FACCD87917AE5B7BCAD875A7DE74B6FA3A70FEB866BE2377DED765966FA65F7B9D833DE0F07EC92F3C6FAECF8C9D77E1BAB5A78C5D77EA4D67ABAF03E78F6BE63B72E77D5D66F966FAB5D739D8030EEF97FCC2F3E6FACCD87917AE5B7BCAD875A7DE74B6FA3A70FEB866BE2377DED765966FA65F7B9D833DE0F07EC92F3C6FAECF8C9D77E1BAB5A78C5D77EA4D67ABAF03E78F6BE63B72E77D5D66F966FAB5D739D8030EEF97FCC2F3E6FACCD87917AE5B7BCAD875A7DE74B6FA3A70FEB866BE2377DED765966FA65F7B9D833DE0F07EC92F3C6FAECF8C9D77E1BAB5A78C5D77EA4D67ABAF03E78F6BE63B72E77D5D66F966FAB5D739D8030EEF97FCC2F3E6FACCD87917AE5B7BCAD875A7DE74B6FA3A70FEB866BE2377DED765966FA65F7B9D833DE0F07EC92F3C6FAECF8C9D77E1BAB5A78C5D77EA4D67ABAF03E78F6BE63B72E77D5D66F966FAB5D739D8030EEF97FCC2F3E6FACCD87917AE5B7BCAD875A7DE74B6FA3A70FEB866BE2377DED765966FA65F7B9D833DE0F07EC9FFE6EFEF3F25881971639F7B8B0000000049454E44AE426082, N'MUA 4T SAN PHAM NUTRI/SPLASH/TEPPY/FUZE TANG 1 AO MUA NUTRI', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'dvcanh', N'Lê Thanh Vân', CAST(N'2020-06-05 00:00:00.000' AS DateTime), N'46291', N'70316253', N'PHẠM VĂN KHÁNH  ', N' THÔN MÔNG THƯỢNG XÃ CHIẾN THẮNG ,HUYỆN AN LÃO ,THÀNH PHỐ HẢI PHÒNG', NULL, N'Đỗ Hữu Hùng 0983246358', N'NEV10146291', 30070, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000033C4944415468439D8D01AAE5400CC37AFF4BBF250B02611C7E184118474EE9F73BF27DDFFF212776BE638CDD4B97BD1D64D7F674E03C6C5DFBCECE3B0E7CC3EBB16B19F0CD65069C6F78C917CE97ED67C6CE778CB17BE9B2B783ECDA9E0E9C87AD6BDFD979C7816F783D762D03BEB9CC80F30D2FF9C2F9B2FDCCD8F98E31762F5DF676905DDBD381F3B075ED3B3BEF38F00DAFC7AE65C037971970BEE1255F385FB69F193BDF31C6EEA5CBDE0EB26B7B3A701EB6AE7D67E71D07BEE1F5D8B50CF8E63203CE37BCE40BE7CBF63363E73BC6D8BD74D9DB41766D4F07CEC3D6B5EFECBCE3C037BC1EBB9601DF5C66C0F986977CE17CD97E66EC7CC718BB972E7B3BC8AEEDE9C079D8BAF69D9D771CF886D763D732E09BCB0C38DFF0922F9C2FDBCF8C9DEF1863F7D2656F07D9B53D1D380F5BD7BEB3F38E03DFF07AEC5A067C739901E71B5EF285F365FB99B1F31D63EC5EBAECED20BBB6A703E761EBDA7776DE71E01B5E8F5DCB806F2E33E07CC34BBE70BE6C3F3376BE638CDD4B97BD1D64D7F674E03C6C5DFBCECE3B0E7CC3EBB16B19F0CD65069C6F78C917CE97ED67C6CE778CB17BE9B2B783ECDA9E0E9C87AD6BDFD979C7816F783D762D03BEB9CC80F30D2FF9C2F9B2FDCCD8F98E31762F5DF676905DDBD381F3B075ED3B3BEF38F00DAFC7AE65C037971970BEE1255F385FB69F193BDF31C6EEA5CBDE0EB26B7B3A701EB6AE7D67E71D07BEE1F5D8B50CF8E63203CE37BCE40BE7CBF63363E73BC6D8BD74D9DB41766D4F07CEC3D6B5EFECBCE3C037BC1EBB9601DF5C66C0F986977CE17CD97E66EC7CC718BB972E7B3BC8AEEDE9C079D8BAF69D9D771CF886D763D732E09BCB0C38DFF0922F9C2FDBCF8C9DEF1863F7D2656F07D9B53D1D380F5BD7BEB3F38E03DFF07AEC5A067C739901E71B5EF285F365FB99B1F31D63EC5EBAECED20BBB6A703E761EBDA7776DE71E01B5E8F5DCB806F2E33E07CC34BBE70BE6C3F3376BE638CDD4B97BD1D64D7F674E03C6C5DFBCECE3B0E7CC3EBB16B19F0CD65069C6F78C917CE97ED67C6CE778CB17BE9B2B783ECDA9E0E9C87AD6BDFD979C7816F783D762D03BEB9CC80F30D2FF9C2F9B2FDCCD8F98E31762F5DF676905DDBD381F3B075ED3B3BEF38F00DAFC7AE65C037971970BEE125FFCDEFF70F265BA7D4B985C4D40000000049454E44AE426082, N'', 1)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'lttvan', N'Lê Thị Tường Vân', CAST(N'2020-06-29 00:00:00.000' AS DateTime), N'47287', N'70249887', N'INTERNAL-DC-EXCLUSIVE NORTH-  ', N'KM17 QUỐC LỘ 1A  ,XÃ DUYÊN THÁI - HUYỆN THƯỜNG TÍN ,THÀNH PHỐ HÀ NỘI', N'2020_DME_POSM_REGIONAL FOCUS_NW', N'0919639135', N'NWV10147287', 30248, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003544944415468438D8D018A65310CC3FEFD2F3D4B170442F8D10A421CDBA5BFBF477EBFDFFF41177BEE31C65E3B6C68D69B8D8666EBAE07D687AF6CBDB3B7B2E2AE079C837BCE6F1AF0DC61A35F786EAECF8C3DF71863AF1D3634EBCD4643B375D703EBC357B6DED95B5971D703CEC13DE7370D78EEB0D12F3C37D767C69E7B8CB1D70E1B9AF566A3A1D9BAEB81F5E12B5BEFECADACB8EB01E7E09EF39B063C77D8E8179E9BEB3363CF3DC6D86B870DCD7AB3D1D06CDDF5C0FAF095AD77F65656DCF5807370CFF94D039E3B6CF40BCFCDF599B1E71E63ECB5C38666BDD96868B6EE7A607DF8CAD63B7B2B2BEE7AC039B8E7FCA601CF1D36FA85E7E6FACCD8738F31F6DA6143B3DE6C34345B773DB03E7C65EB9DBD9515773DE01CDC737ED380E70E1BFDC273737D66ECB9C7187BEDB0A1596F361A9AADBB1E581FBEB2F5CEDECA8ABB1E700EEE39BF69C073878D7EE1B9B93E33F6DC638CBD76D8D0AC371B0DCDD65D0FAC0F5FD97A676F65C55D0F3807F79CDF34E0B9C346BFF0DC5C9F197BEE31C65E3B6C68D69B8D8666EBAE07D687AF6CBDB3B7B2E2AE079C837BCE6F1AF0DC61A35F786EAECF8C3DF71863AF1D3634EBCD4643B375D703EBC357B6DED95B5971D703CEC13DE7370D78EEB0D12F3C37D767C69E7B8CB1D70E1B9AF566A3A1D9BAEB81F5E12B5BEFECADACB8EB01E7E09EF39B063C77D8E8179E9BEB3363CF3DC6D86B870DCD7AB3D1D06CDDF5C0FAF095AD77F65656DCF5807370CFF94D039E3B6CF40BCFCDF599B1E71E63ECB5C38666BDD96868B6EE7A607DF8CAD63B7B2B2BEE7AC039B8E7FCA601CF1D36FA85E7E6FACCD8738F31F6DA6143B3DE6C34345B773DB03E7C65EB9DBD9515773DE01CDC737ED380E70E1BFDC273737D66ECB9C7187BEDB0A1596F361A9AADBB1E581FBEB2F5CEDECA8ABB1E700EEE39BF69C073878D7EE1B9B93E33F6DC638CBD76D8D0AC371B0DCDD65D0FAC0F5FD97A676F65C55D0F3807F79CDF34E0B9C346BFF0DC5C9F197BEE31C65E3B6C68D69B8D8666EBAE07D687AF6CBDB3B7B2E2AE079C837BCE6F1AF0DC61A35F786EAECF8C3DF71863AF1D3634EBCD4643B375D703EBC357B6DED95B5971D703CEC13DE7370D78EEB0D12F3C37D767C69E7B8CB1D70E1B9AF566A3A1D9BAEB81F5E12B5BEFECADACB8EB01E7E09EF39B063C77D8E83B7F7FFF00D9FCA7D43826BEB30000000049454E44AE426082, N'Hỗ trợ CT Food Safety - QSE Culture', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'vndhuong', N'Dinh Thi Thu Huong', CAST(N'2020-03-28 00:00:00.000' AS DateTime), N'39329', N'70244803', N'NGUYỄN THỊ UYÊN  ', N'TỔ 4 KHU XUÂN MAI  ,XUÂN MAI - CHƯƠNG MỸ - HÀ NỘI ,THÀNH PHỐ HÀ NỘI', N'Loyalty 2020', N'433722869', N'HNV10139329', 31581, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003504944415468438D8D018A45410CC2DEFD2FFD972E048258A681A16A2DF3FD8E7CDFF7FFD089337761BB75CE33CEB293B9C95DF39981F5B0ED7C87CEBD27B8EB8EFDD03C33F5CB9BD661A22F9C9BED33E3CC5DD86E9DF38CB3EC646E72D77C66603D6C3BDFA173EF09EEBA633F34CF4CFDF2A67598E80BE766FBCC387317B65BE73CE32C3B999BDC359F19580FDBCE77E8DC7B82BBEED80FCD3353BFBC691D26FAC2B9D93E33CEDC85EDD639CF38CB4EE62677CD6706D6C3B6F31D3AF79EE0AE3BF643F3CCD42F6F5A8789BE706EB6CF8C337761BB75CE33CEB293B9C95DF39981F5B0ED7C87CEBD27B8EB8EFDD03C33F5CB9BD661A22F9C9BED33E3CC5DD86E9DF38CB3EC646E72D77C66603D6C3BDFA173EF09EEBA633F34CF4CFDF2A67598E80BE766FBCC387317B65BE73CE32C3B999BDC359F19580FDBCE77E8DC7B82BBEED80FCD3353BFBC691D26FAC2B9D93E33CEDC85EDD639CF38CB4EE62677CD6706D6C3B6F31D3AF79EE0AE3BF643F3CCD42F6F5A8789BE706EB6CF8C337761BB75CE33CEB293B9C95DF39981F5B0ED7C87CEBD27B8EB8EFDD03C33F5CB9BD661A22F9C9BED33E3CC5DD86E9DF38CB3EC646E72D77C66603D6C3BDFA173EF09EEBA633F34CF4CFDF2A67598E80BE766FBCC387317B65BE73CE32C3B999BDC359F19580FDBCE77E8DC7B82BBEED80FCD3353BFBC691D26FAC2B9D93E33CEDC85EDD639CF38CB4EE62677CD6706D6C3B6F31D3AF79EE0AE3BF643F3CCD42F6F5A8789BE706EB6CF8C337761BB75CE33CEB293B9C95DF39981F5B0ED7C87CEBD27B8EB8EFDD03C33F5CB9BD661A22F9C9BED33E3CC5DD86E9DF38CB3EC646E72D77C66603D6C3BDFA173EF09EEBA633F34CF4CFDF2A67598E80BE766FBCC387317B65BE73CE32C3B999BDC359F19580FDBCE77E8DC7B82BBEED80FCD3353BFBC691D26FAC2B9D93E33CEDC85EDD639CF38CB4EE62677CD6706D6C3B6F31D3AF79EE0AE3BF643F3CCD42F6F5A8789BE706EB6CF8C337761BB75CE33CEB293B9C95DF39981F5B0ED7C87CEBD27B8EB8EFDD03C33F5CB9BD661A22F9C9BED33E3CC5DD86E9DF38CB3EC646E72D77C66603D6C3BDFA173EF09EEBA633F34CF4CFDF2A67598E80BE766FBCC387317B65BE73CE32C3B999BDC359F19580FDBCE77E8DC7B82BBEED80FCD3353BFBC691D26FACDEFF707149FA7D411DEBBC90000000049454E44AE426082, N'IO#22722LOYALTY2020', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'vnhuonglan', N'Dinh Thi Thu Huong', CAST(N'2020-12-18 00:00:00.000' AS DateTime), N'55333', N'82184310', N'ĐỖ THỊ KIM THÔNG  ', N' THÔN ỨNG HÒA  ,XÃ PHÚC TIẾN, HUYỆN PHÚ XUYÊN ,THÀNH PHỐ HÀ NỘI', N'TET P2 2021', N'982857099', N'HNV10155333', 36625, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000034F4944415468438D8D018A65310CC3DEFD2FFD970C088471BA119438B643BFDF91EFFBFE1E3AB1E72E6CB7F679C65E76D23799B53D3DB01E5AC64D66DB8E7EED9EE00EE0E137DD32681D26FAC2B9D93E33F6DC85EDD63ECFD8CB4EFA26B3B6A707D643CBB8C96CDBD1AFDD13DC013CFCA65B06ADC3445F3837DB67C69EBBB0DDDAE7197BD949DF64D6F6F4C07A681937996D3BFAB57B823B8087DF74CBA07598E80BE766FBCCD87317B65BFB3C632F3BE99BCCDA9E1E580F2DE326B36D47BF764F7007F0F09B6E19B40E137DE1DC6C9F197BEEC2766B9F67EC65277D9359DBD303EBA165DC64B6EDE8D7EE09EE001E7ED32D83D661A22F9C9BED3363CF5DD86EEDF38CBDECA46F326B7B7A603DB48C9BCCB61DFDDA3DC11DC0C36FBA65D03A4CF48573B37D66ECB90BDBAD7D9EB1979DF44D666D4F0FAC87967193D9B6A35FBB27B80378F84DB70C5A8789BE706EB6CF8C3D7761BBB5CF33F6B293BEC9ACEDE981F5D0326E32DB76F46BF70477000FBFE99641EB30D117CECDF699B1E72E6CB7F679C65E76D23799B53D3DB01E5AC64D66DB8E7EED9EE00EE0E137DD32681D26FAC2B9D93E33F6DC85EDD63ECFD8CB4EFA26B3B6A707D643CBB8C96CDBD1AFDD13DC013CFCA65B06ADC3445F3837DB67C69EBBB0DDDAE7197BD949DF64D6F6F4C07A681937996D3BFAB57B823B8087DF74CBA07598E80BE766FBCCD87317B65BFB3C632F3BE99BCCDA9E1E580F2DE326B36D47BF764F7007F0F09B6E19B40E137DE1DC6C9F197BEEC2766B9F67EC65277D9359DBD303EBA165DC64B6EDE8D7EE09EE001E7ED32D83D661A22F9C9BED3363CF5DD86EEDF38CBDECA46F326B7B7A603DB48C9BCCB61DFDDA3DC11DC0C36FBA65D03A4CF48573B37D66ECB90BDBAD7D9EB1979DF44D666D4F0FAC87967193D9B6A35FBB27B80378F84DB70C5A8789BE706EB6CF8C3D7761BBB5CF33F6B293BEC9ACEDE981F5D0326E32DB76F46BF70477000FBFE99641EB30D117CECDF699B1E72E6CB7F679C65E76D23799B53D3DB01E5AC64D66DB8E7EED9EE00EE0E137DD32681D26FAC2B9D93E33F6DC85EDD63ECFD8CB4EFA26B3B6A707D643CBB8C96CDBD1AFDD13DC013CFCA65B06ADC3445F3837DB67C69EBBB0DDDAE7197BD949DF64D6F6F4C07A681937996D3BFAB57B823B8087DF74CBA07598E8FFF3FBFD0375C2A7D4A91810780000000049454E44AE426082, N'DME-00000-023329-POSMTETP2 - DELIVERY 1300017768', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'vnhuonglan', N'Dinh Thi Thu Huong', CAST(N'2020-12-18 00:00:00.000' AS DateTime), N'55337', N'82100871', N'NGUYỄN TIẾN NHƯ  ', N' TỔ DÂN PHỐ TẾ TIÊU HUYỆN MỸ ĐỨC ,THỊ TRẤN ĐẠI NGHĨA - ,THÀNH PHỐ HÀ NỘI', N'TET P2 2021', N'982847124', N'HNV10155337', 36626, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003284944415468438D8D018A45310C02DFFD2FFD972E0C0C62DA0C841A35F4FB2DF9BEEF7FD0893D7761BAB5CF187BD949DF64D6F6F4C0FAD0326E329B76F46D379BEC95A7063C7778D11BD6CDF699B1E72E4CB7F619632F3BE99BCCDA9E1E581F5AC64D66D38EBEED6693BDF2D480E70E2F7AC3BAD93E33F6DC85E9D63E63EC65277D9359DBD303EB43CBB8C96CDAD1B7DD6CB2579E1AF0DCE1456F5837DB67C69EBB30DDDA678CBDECA46F326B7B7A607D681937994D3BFAB69B4DF6CA53039E3BBCE80DEB66FBCCD87317A65BFB8CB1979DF44D666D4F0FAC0F2DE326B36947DF76B3C95E796AC0738717BD61DD6C9F197BEEC2746B9F31F6B293BEC9ACEDE981F5A165DC6436EDE8DB6E36D92B4F0D78EEF0A237AC9BED3363CF5D986EED33C65E76D23799B53D3DB03EB48C9BCCA61D7DDBCD267BE5A901CF1D5EF48675B37D66ECB90BD3AD7DC6D8CB4EFA26B3B6A707D687967193D9B4A36FBBD964AF3C35E0B9C38BDEB06EB6CF8C3D7761BAB5CF187BD949DF64D6F6F4C0FAD0326E329B76F46D379BEC95A7063C7778D11BD6CDF699B1E72E4CB7F619632F3BE99BCCDA9E1E581F5AC64D66D38EBEED6693BDF2D480E70E2F7AC3BAD93E33F6DC85E9D63E63EC65277D9359DBD303EB43CBB8C96CDAD1B7DD6CB2579E1AF0DCE1456F5837DB67C69EBB30DDDA678CBDECA46F326B7B7A607D681937994D3BFAB69B4DF6CA53039E3BBCE80DEB66FBCCD87317A65BFB8CB1979DF44D666D4F0FAC0F2DE326B36947DF76B3C95E796AC0738717BD61DD6C9F197BEEC2746B9F31F6B293BEC9ACEDE981F5A165DC6436EDE8DB6E36D92B4F0D78EEF0A237AC9BED3363CF5D986EED33C65E76D23799B53D3DB03EB48C9BCCA61D7DDBCD267BE5A901CF1D5EF48675B37D66ECB90BD3AD7DC6D8CB4EFA26B3B6A707D687967193D9B4A36FBBD964AF3C35E0B9C38BDEB06EB6CF8C3D7761BAB5CF187BD949DF64D6F6F4C0FAD0326E329B76F46D379BEC95A7063C7778D11BD6CDF699B1E72E4CB7F619632F3BE99BCCDA9E1E581F5AC64D66D38EBEED6693BDF2D480E70E2F7AC3BAD93E33F6DC85E9D63E63EC65277D9359DBD303EB43CBB8C96CDAD1B7DD6CB2579E1AF0DCE145BFF9FDFE009FF41971BA0F2C160000000049454E44AE426082, N'DME-00000-023329-POSMTETP2 - DELIVERY 1300017770', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'vnhuonglan', N'Dinh Thi Thu Huong', CAST(N'2020-12-18 00:00:00.000' AS DateTime), N'55361', N'70276766', N'PHẠM VĂN QUỲNH  ', N' THÔN ĐÔNG CỨU  ,XÃ DŨNG TIẾN - HUYỆN THƯỜNG TÍN ,THÀNH PHỐ HÀ NỘI', N'TET P2 2021', N'968595535', N'HNV10155361', 36627, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003314944415468438D8D018A45410CC2DEFD2FFD972E048254A681326A2DF3FD8E7CDFF73FE8C499BBD06E9D33C659763237B9DB7C66603D6C3B6E72D73CFAE5C11A5A7768BE759DFB455F3837B7CF8C3377A1DD3A678CB3EC646E72B7F9CCC07AD876DCE4AE79F4CB8335B4EED07CEB3AF78BBE706E6E9F1967EE42BB75CE1867D9C9DCE46EF39981F5B0EDB8C95DF3E897076B68DDA1F9D675EE177DE1DCDC3E33CEDC8576EB9C31CEB293B9C9DDE63303EB61DB7193BBE6D12F0FD6D0BA43F3ADEBDC2FFAC2B9B97D669CB90BEDD639639C65277393BBCD6706D6C3B6E32677CDA35F1EACA17587E65BD7B95FF4857373FBCC387317DAAD73C638CB4EE626779BCF0CAC876DC74DEE9A47BF3C5843EB0ECDB7AE73BFE80BE7E6F69971E62EB45BE78C71969DCC4DEE369F19580FDB8E9BDC358F7E79B086D61D9A6F5DE77ED117CECDED33E3CC5D68B7CE19E32C3B999BDC6D3E33B01EB61D37B96B1EFDF2600DAD3B34DFBACEFDA22F9C9BDB67C699BBD06E9D33C659763237B9DB7C66603D6C3B6E72D73CFAE5C11A5A7768BE759DFB455F3837B7CF8C3377A1DD3A678CB3EC646E72B7F9CCC07AD876DCE4AE79F4CB8335B4EED07CEB3AF78BBE706E6E9F1967EE42BB75CE1867D9C9DCE46EF39981F5B0EDB8C95DF3E897076B68DDA1F9D675EE177DE1DCDC3E33CEDC8576EB9C31CEB293B9C9DDE63303EB61DB7193BBE6D12F0FD6D0BA43F3ADEBDC2FFAC2B9B97D669CB90BEDD639639C65277393BBCD6706D6C3B6E32677CDA35F1EACA17587E65BD7B95FF4857373FBCC387317DAAD73C638CB4EE626779BCF0CAC876DC74DEE9A47BF3C5843EB0ECDB7AE73BFE80BE7E6F69971E62EB45BE78C71969DCC4DEE369F19580FDB8E9BDC358F7E79B086D61D9A6F5DE77ED117CECDED33E3CC5D68B7CE19E32C3B999BDC6D3E33B01EB61D37B96B1EFDF2600DAD3B34DFBACEFDA22F9C9BDB67C699BBD06E9D33C659763237B9DB7C66603D6C3B6E72D73CFAE5C11A5A7768BE759DFB455F3837B7CF8C3377A1DD3A678CB3EC646E72B7F9CCC07AD876DCE4AE79F4CB8335B4EED07CEB3AF78BBE706E6E9F1967EE42BB75CE1867D9C9DCE46EF39981F5B0EDB8C95DF3E897076B68DDA1F9D675EE17FDE6F7FB03CA268AFFCAB5DBEA0000000049454E44AE426082, N'DME-00000-023329-POSMTETP2 - DELIVERY 1300017782', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'vnhuonglan', N'Dinh Thi Thu Huong', CAST(N'2020-12-23 00:00:00.000' AS DateTime), N'56762', N'82100871', N'NGUYỄN TIẾN NHƯ  ', N' TỔ DÂN PHỐ TẾ TIÊU HUYỆN MỸ ĐỨC ,THỊ TRẤN ĐẠI NGHĨA - ,THÀNH PHỐ HÀ NỘI', N'TET P2 2021', N'982847124', N'HNV10156762', 36628, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003494944415468438D8D01AA6D390CC3EEFE37FD860E0884F0E147106A3B0EFDFD1DF9FD7EFF0FBA387317BE6E9D33C6593BCD4D77CB3703EBC7DA71D35D7D215B5D8FC1F705DFA0EBCDEAF0A22F9C9BEB33E3CC5DF8BA75CE1867ED3437DD2DDF0CAC1F6BC74D77F5856C753D06DF177C83AE37ABC38BBE706EAECF8C3377E1EBD639639CB5D3DC74B77C33B07EAC1D37DDD517B2D5F5187C5FF00DBADEAC0E2FFAC2B9B93E33CEDC85AF5BE78C71D64E73D3DDF2CDC0FAB176DC74575FC856D763F07DC137E87AB33ABCE80BE7E6FACC387317BE6E9D33C6593BCD4D77CB3703EBC7DA71D35D7D215B5D8FC1F705DFA0EBCDEAF0A22F9C9BEB33E3CC5DF8BA75CE1867ED3437DD2DDF0CAC1F6BC74D77F5856C753D06DF177C83AE37ABC38BBE706EAECF8C3377E1EBD639639CB5D3DC74B77C33B07EAC1D37DDD517B2D5F5187C5FF00DBADEAC0E2FFAC2B9B93E33CEDC85AF5BE78C71D64E73D3DDF2CDC0FAB176DC74575FC856D763F07DC137E87AB33ABCE80BE7E6FACC387317BE6E9D33C6593BCD4D77CB3703EBC7DA71D35D7D215B5D8FC1F705DFA0EBCDEAF0A22F9C9BEB33E3CC5DF8BA75CE1867ED3437DD2DDF0CAC1F6BC74D77F5856C753D06DF177C83AE37ABC38BBE706EAECF8C3377E1EBD639639CB5D3DC74B77C33B07EAC1D37DDD517B2D5F5187C5FF00DBADEAC0E2FFAC2B9B93E33CEDC85AF5BE78C71D64E73D3DDF2CDC0FAB176DC74575FC856D763F07DC137E87AB33ABCE80BE7E6FACC387317BE6E9D33C6593BCD4D77CB3703EBC7DA71D35D7D215B5D8FC1F705DFA0EBCDEAF0A22F9C9BEB33E3CC5DF8BA75CE1867ED3437DD2DDF0CAC1F6BC74D77F5856C753D06DF177C83AE37ABC38BBE706EAECF8C3377E1EBD639639CB5D3DC74B77C33B07EAC1D37DDD517B2D5F5187C5FF00DBADEAC0E2FFAC2B9B93E33CEDC85AF5BE78C71D64E73D3DDF2CDC0FAB176DC74575FC856D763F07DC137E87AB33ABCE80BE7E6FACC387317BE6E9D33C6593BCD4D77CB3703EBC7DA71D35D7D215B5D8FC1F705DFA0EBCDEAF0A22F9C9BEB33E3CC5DF8BA75CE1867ED3437DD2DDF0CAC1F6BC74D77F5856C753D06DF177C83AE37ABC38BBE706EAECF8C3377E1EBD639639CB5D3DC74B77C33B07EAC1D37DDD517B2D5F5187C5FF00DBADEAC0E2FFADFFCFDFD0757478AFF2DD2743C0000000049454E44AE426082, N'DME-00000-023329-POSMTETP2 - DELIVERY 1300018284', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'vnhuonglan', N'Dinh Thi Thu Huong', CAST(N'2020-12-23 00:00:00.000' AS DateTime), N'56782', N'70276766', N'PHẠM VĂN QUỲNH  ', N' THÔN ĐÔNG CỨU  ,XÃ DŨNG TIẾN - HUYỆN THƯỜNG TÍN ,THÀNH PHỐ HÀ NỘI', N'TET P2 2021', N'968595535', N'HNV10156782', 36629, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000034E4944415468438D8D01AA6D390CC3EEFE37FD867E1008E19EA920D4B11DFAFB7BE4F7FBFD1B74B1E72EDC6EED33C65E3BF54DB3B5D703EBC3CAB869D6BDE07D75AB3DF5D879578686D5E145BFF0DC5C9F197BEEC2EDD63E63ECB553DF345B7B3DB03EAC8C9B66DD0BDE57B7DA538F9D776568581D5EF40BCFCDF599B1E72EDC6EED33C65E3BF54DB3B5D703EBC3CAB869D6BDE07D75AB3DF5D879578686D5E145BFF0DC5C9F197BEEC2EDD63E63ECB553DF345B7B3DB03EAC8C9B66DD0BDE57B7DA538F9D776568581D5EF40BCFCDF599B1E72EDC6EED33C65E3BF54DB3B5D703EBC3CAB869D6BDE07D75AB3DF5D879578686D5E145BFF0DC5C9F197BEEC2EDD63E63ECB553DF345B7B3DB03EAC8C9B66DD0BDE57B7DA538F9D776568581D5EF40BCFCDF599B1E72EDC6EED33C65E3BF54DB3B5D703EBC3CAB869D6BDE07D75AB3DF5D879578686D5E145BFF0DC5C9F197BEEC2EDD63E63ECB553DF345B7B3DB03EAC8C9B66DD0BDE57B7DA538F9D776568581D5EF40BCFCDF599B1E72EDC6EED33C65E3BF54DB3B5D703EBC3CAB869D6BDE07D75AB3DF5D879578686D5E145BFF0DC5C9F197BEEC2EDD63E63ECB553DF345B7B3DB03EAC8C9B66DD0BDE57B7DA538F9D776568581D5EF40BCFCDF599B1E72EDC6EED33C65E3BF54DB3B5D703EBC3CAB869D6BDE07D75AB3DF5D879578686D5E145BFF0DC5C9F197BEEC2EDD63E63ECB553DF345B7B3DB03EAC8C9B66DD0BDE57B7DA538F9D776568581D5EF40BCFCDF599B1E72EDC6EED33C65E3BF54DB3B5D703EBC3CAB869D6BDE07D75AB3DF5D879578686D5E145BFF0DC5C9F197BEEC2EDD63E63ECB553DF345B7B3DB03EAC8C9B66DD0BDE57B7DA538F9D776568581D5EF40BCFCDF599B1E72EDC6EED33C65E3BF54DB3B5D703EBC3CAB869D6BDE07D75AB3DF5D879578686D5E145BFF0DC5C9F197BEEC2EDD63E63ECB553DF345B7B3DB03EAC8C9B66DD0BDE57B7DA538F9D776568581D5EF40BCFCDF599B1E72EDC6EED33C65E3BF54DB3B5D703EBC3CAB869D6BDE07D75AB3DF5D879578686D5E145BFF0DC5C9F197BEEC2EDD63E63ECB553DF345B7B3DB03EAC8C9B66DD0BDE57B7DA538F9D776568581D5EF40BCFCDF599B1E72EDC6EED33C65E3BF54DB3B5D703EBC3CAB869D6BDE07D75AB3DF5D879578686D5E145FF3F7F7FFF01B9B21971C481E4110000000049454E44AE426082, N'DME-00000-023329-POSMTETP2 - DELIVERY 1300018269', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'nvhai', N'Dinh Thi Thu Huong', CAST(N'2021-01-16 00:00:00.000' AS DateTime), N'59614', N'82182855', N'Metro Thăng Long', N'234 Phạm Văn Đồng-Cổ Nhuế ,Bắc Từ Liêm ,Hà Nội', N'TET P2 2021', N'Phu: 0915193062', N'HNV10159614', 38202, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003824944415468438D8D01AA653108C5EEFE37FD0607022158BE0151E329FD7E47BEEFFB5FCCC5CE5978BDB5A78C5D33F5A6B76DAF03CFC376E34D6FDDE92EE30C34C78E73671E3C4333030EEFCE7CE19CDC3E3376CEC2EBAD3D65EC9AA937BD6D7B1D781EB61B6F7AEB4E771967A039769C3BF3E0199A19707877E60BE7E4F699B173165E6FED2963D74CBDE96DDBEBC0F3B0DD78D35B77BACB3803CDB1E3DC9907CFD0CC80C3BB335F3827B7CF8C9DB3F07A6B4F19BB66EA4D6FDB5E079E87EDC69BDEBAD35DC619688E1DE7CE3C788666061CDE9DF9C239B97D66EC9C85D75B7BCAD835536F7ADBF63AF03C6C37DEF4D69DEE32CE4073EC3877E6C1333433E0F0EECC17CEC9ED3363E72CBCDEDA53C6AE997AD3DBB6D781E761BBF1A6B7EE749771069A63C7B9330F9EA19901877767BE704E6E9F193B67E1F5D69E3276CDD49BDEB6BD0E3C0FDB8D37BD75A7BB8C33D01C3BCE9D79F00CCD0C38BC3BF3857372FBCCD8390BAFB7F694B16BA6DEF4B6ED75E079D86EBCE9AD3BDD659C81E6D871EECC83676866C0E1DD992F9C93DB67C6CE5978BDB5A78C5D33F5A6B76DAF03CFC376E34D6FDDE92EE30C34C78E73671E3C4333030EEFCE7CE19CDC3E3376CEC2EBAD3D65EC9AA937BD6D7B1D781EB61B6F7AEB4E771967A039769C3BF3E0199A19707877E60BE7E4F699B173165E6FED2963D74CBDE96DDBEBC0F3B0DD78D35B77BACB3803CDB1E3DC9907CFD0CC80C3BB335F3827B7CF8C9DB3F07A6B4F19BB66EA4D6FDB5E079E87EDC69BDEBAD35DC619688E1DE7CE3C788666061CDE9DF9C239B97D66EC9C85D75B7BCAD835536F7ADBF63AF03C6C37DEF4D69DEE32CE4073EC3877E6C1333433E0F0EECC17CEC9ED3363E72CBCDEDA53C6AE997AD3DBB6D781E761BBF1A6B7EE749771069A63C7B9330F9EA19901877767BE704E6E9F193B67E1F5D69E3276CDD49BDEB6BD0E3C0FDB8D37BD75A7BB8C33D01C3BCE9D79F00CCD0C38BC3BF3857372FBCCD8390BAFB7F694B16BA6DEF4B6ED75E079D86EBCE9AD3BDD659C81E6D871EECC83676866C0E1DD992F9C93DB67C6CE5978BDB5A78C5D33F5A6B76DAF03CFC376E34D6FDDE92EE30C34C78E73671E3C4333030EEFCE7CE19CDC3E3376CEC2EBAD3D65EC9AA937BD6D7B1D781EB61B6F7AEB4E771967A039769C3BF3E0199A19707877E60BE7E4F699B173165E6FED2963D74CBDE96DDBEBC0F3B0DD78D35B77BACB3803CDB1E3DC9907CFD0CC80C3BB33FFCDEFF70F6C8F8AFF10A339F30000000049454E44AE426082, N'DME-00000-023329-POSMTETP2', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'vnvanle', N'Lê Thanh Vân', CAST(N'2021-02-08 00:00:00.000' AS DateTime), N'61471', N'70217728', N'CÔNG TY TNHH TÂN THỊNH HƯNG THÁI BÌNH ', N' NHÀ ÔNG LÊ NGỌC HƯNG THÔN PHONG LÔI TÂY ,XÃ ĐÔNG HỢP - HUYỆN ĐÔNG HƯNG ,TỈNH THÁI BÌNH', NULL, N'Vũ Đình Đáo 0906569989', N'NEV10161471', 39959, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003484944415468439D8D018A65310CC3DEFD2FFD972C088471985041A923A7F4FB1DF9BEEFFF212776DEE318BB972E7B3BC8AECDE9C079D83ADEE19C87CC6DC6B58E9CD07BA7CD9901E71D6EF285F366FBCCD8798F63EC5EBAECED20BB36A703E761EB7887731E32B719D73A7242EF9D3667069C77B8C917CE9BED3363E73D8EB17BE9B2B783ECDA9C0E9C87ADE31DCE79C8DC665CEBC809BD77DA9C1970DEE1265F386FB6CF8C9DF738C6EEA5CBDE0EB26B733A701EB68E7738E721739B71AD2327F4DE697366C079879B7CE1BCD93E3376DEE318BB972E7B3BC8AECDE9C079D83ADEE19C87CC6DC6B58E9CD07BA7CD9901E71D6EF285F366FBCCD8798F63EC5EBAECED20BB36A703E761EB7887731E32B719D73A7242EF9D3667069C77B8C917CE9BED3363E73D8EB17BE9B2B783ECDA9C0E9C87ADE31DCE79C8DC665CEBC809BD77DA9C1970DEE1265F386FB6CF8C9DF738C6EEA5CBDE0EB26B733A701EB68E7738E721739B71AD2327F4DE697366C079879B7CE1BCD93E3376DEE318BB972E7B3BC8AECDE9C079D83ADEE19C87CC6DC6B58E9CD07BA7CD9901E71D6EF285F366FBCCD8798F63EC5EBAECED20BB36A703E761EB7887731E32B719D73A7242EF9D3667069C77B8C917CE9BED3363E73D8EB17BE9B2B783ECDA9C0E9C87ADE31DCE79C8DC665CEBC809BD77DA9C1970DEE1265F386FB6CF8C9DF738C6EEA5CBDE0EB26B733A701EB68E7738E721739B71AD2327F4DE697366C079879B7CE1BCD93E3376DEE318BB972E7B3BC8AECDE9C079D83ADEE19C87CC6DC6B58E9CD07BA7CD9901E71D6EF285F366FBCCD8798F63EC5EBAECED20BB36A703E761EB7887731E32B719D73A7242EF9D3667069C77B8C917CE9BED3363E73D8EB17BE9B2B783ECDA9C0E9C87ADE31DCE79C8DC665CEBC809BD77DA9C1970DEE1265F386FB6CF8C9DF738C6EEA5CBDE0EB26B733A701EB68E7738E721739B71AD2327F4DE697366C079879B7CE1BCD93E3376DEE318BB972E7B3BC8AECDE9C079D83ADEE19C87CC6DC6B58E9CD07BA7CD9901E71D6EF285F366FBCCD8798F63EC5EBAECED20BB36A703E761EB7887731E32B719D73A7242EF9D3667069C77B8C917CE9BED3363E73D8EB17BE9B2B783ECDA9C0E9C87ADE31DCE79C8DC665CEBC809BD77DA9C1970DEE126FFCDEFF70F3ED11971BBC53B050000000049454E44AE426082, N'', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'lktoan', N'Lê Thanh Vân', CAST(N'2021-02-08 00:00:00.000' AS DateTime), N'61475', N'70664708', N'PHẠM THỊ MẬN', N'SỐ  397, PHỦ THƯỢNG ĐOẠN - PHƯỜNG ĐÔNG HẢI 1 ,QUẬN HẢI AN ,Hải Phòng', N'2021_DME_POSM_WINDOW 1_NE', N'02253629863', N'NEV10161475', 39970, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000035F4944415468439D8D01AA6D490C02EFFE37FD06070A0AB1F9E1148418B5E9DFDF91DFEFF7FFA01B7BEE31C6DE97AC737BD0D9BADB03EBF0CA7887671D5AAF1BAF73B0E7AE7788F640DFA17BDEE80BE7E6FACCD8738F31F6BE649DDB83CED6DD1E588757C63B3CEBD07ADD789D833D77BD43B407FA0EDDF3465F3837D767C69E7B8CB1F725EBDC1E74B6EEF6C03ABC32DEE15987D6EBC6EB1CECB9EB1DA23DD077E89E37FAC2B9B93E33F6DC638CBD2F59E7F6A0B375B707D6E195F10ECF3AB45E375EE760CF5DEF10ED81BE43F7BCD117CECDF599B1E71E63EC7DC93AB7079DADBB3DB00EAF8C7778D6A1F5BAF13A077BEE7A87680FF41DBAE78DBE706EAECF8C3DF71863EF4BD6B93DE86CDDED81757865BCC3B30EADD78DD739D873D73B447BA0EFD03D6FF48573737D66ECB9C7187B5FB2CEED4167EB6E0FACC32BE31D9E7568BD6EBCCEC19EBBDE21DA037D87EE79A32F9C9BEB3363CF3DC6D8FB92756E0F3A5B777B601D5E19EFF0AC43EB75E3750EF6DCF50ED11EE83B74CF1B7DE1DC5C9F197BEE31C6DE97AC737BD0D9BADB03EBF0CA7887671D5AAF1BAF73B0E7AE7788F640DFA17BDEE80BE7E6FACCD8738F31F6BE649DDB83CED6DD1E588757C63B3CEBD07ADD789D833D77BD43B407FA0EDDF3465F3837D767C69E7B8CB1F725EBDC1E74B6EEF6C03ABC32DEE15987D6EBC6EB1CECB9EB1DA23DD077E89E37FAC2B9B93E33F6DC638CBD2F59E7F6A0B375B707D6E195F10ECF3AB45E375EE760CF5DEF10ED81BE43F7BCD117CECDF599B1E71E63EC7DC93AB7079DADBB3DB00EAF8C7778D6A1F5BAF13A077BEE7A87680FF41DBAE78DBE706EAECF8C3DF71863EF4BD6B93DE86CDDED81757865BCC3B30EADD78DD739D873D73B447BA0EFD03D6FF48573737D66ECB9C7187B5FB2CEED4167EB6E0FACC32BE31D9E7568BD6EBCCEC19EBBDE21DA037D87EE79A32F9C9BEB3363CF3DC6D8FB92756E0F3A5B777B601D5E19EFF0AC43EB75E3750EF6DCF50ED11EE83B74CF1B7DE1DC5C9F197BEE31C6DE97AC737BD0D9BADB03EBF0CA7887671D5AAF1BAF73B0E7AE7788F640DFA17BDEE80BE7E6FACCD8738F31F6BE649DDB83CED6DD1E588757C63B3CEBD07ADD789D833D77BD43B407FA0EDDF3465F3837D767C69E7B8CB1F725EBDC1E74B6EEF6C03ABC32DEE15987D6EBC6EB1CECB9EB1DA23DD077E89E37FADFFCFDFD079F218AFFDE698C1F0000000049454E44AE426082, N'DME-00000-023553-POSMWINDOW1.21', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'ddhien', N'Dinh Thi Thu Huong', CAST(N'2021-02-17 00:00:00.000' AS DateTime), N'61850', N'80000005', N'KA ON', N'68/116 NHAN HOA, NHAN CHINH ,THANH XUAN ,Hà Nội', N'POSM WINDOW 1 2021', N'Tuan: 0906 989 669', N'HNV10161850', 39978, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000003574944415468438D8D018A453108C4DEFD2FFD1717026118A981E218957EBF23DFF7FD3F7262E75DD86EED79C62E77D29B9CB53E1D380FDB8C3B9CF3B0F5E9A8F643CE5EBD739B41DBA1922F9C37DB67C6CEBBB0DDDAF38C5DEEA437396B7D3A701EB6197738E761EBD351ED879CBD7AE73683B643255F386FB6CF8C9D7761BBB5E719BBDC496F72D6FA74E03C6C33EE70CEC3D6A7A3DA0F397BF5CE6D066D874ABE70DE6C9F193BEFC2766BCF3376B993DEE4ACF5E9C079D866DCE19C87AD4F47B51F72F6EA9DDB0CDA0E957CE1BCD93E3376DE85EDD69E67EC7227BDC959EBD381F3B0CDB8C3390F5B9F8E6A3FE4ECD53BB719B41D2AF9C279B37D66ECBC0BDBAD3DCFD8E54E7A93B3D6A703E7619B7187731EB63E1DD57EC8D9AB776E33683B54F285F366FBCCD87917B65B7B9EB1CB9DF42667AD4F07CEC336E30EE73C6C7D3AAAFD90B357EFDC66D076A8E40BE7CDF699B1F32E6CB7F63C63973BE94DCE5A9F0E9C876DC61DCE79D8FA7454FB2167AFDEB9CDA0ED50C917CE9BED3363E75DD86EED79C62E77D29B9CB53E1D380FDB8C3B9CF3B0F5E9A8F643CE5EBD739B41DBA1922F9C37DB67C6CEBBB0DDDAF38C5DEEA437396B7D3A701EB6197738E761EBD351ED879CBD7AE73683B643255F386FB6CF8C9D7761BBB5E719BBDC496F72D6FA74E03C6C33EE70CEC3D6A7A3DA0F397BF5CE6D066D874ABE70DE6C9F193BEFC2766BCF3376B993DEE4ACF5E9C079D866DCE19C87AD4F47B51F72F6EA9DDB0CDA0E957CE1BCD93E3376DE85EDD69E67EC7227BDC959EBD381F3B0CDB8C3390F5B9F8E6A3FE4ECD53BB719B41D2AF9C279B37D66ECBC0BDBAD3DCFD8E54E7A93B3D6A703E7619B7187731EB63E1DD57EC8D9AB776E33683B54F285F366FBCCD87917B65B7B9EB1CB9DF42667AD4F07CEC336E30EE73C6C7D3AAAFD90B357EFDC66D076A8E40BE7CDF699B1F32E6CB7F63C63973BE94DCE5A9F0E9C876DC61DCE79D8FA7454FB2167AFDEB9CDA0ED50C917CE9BED3363E75DD86EED79C62E77D29B9CB53E1D380FDB8C3B9CF3B0F5E9A8F643CE5EBD739B41DBA1922F9C37DB67C6CEBBB0DDDAF38C5DEEA437396B7D3A701EB6197738E761EBD351ED879CBD7AE73683B643255F386FB6CF8C9D7761BBB5E719BBDC496F72D6FA74E03C6C33EE70CEC3D6A7A3DA0F397BF5CE6D066D874A7EF3FBFD014E49A7D40424680E0000000049454E44AE426082, N'DME-00000-023551-POSMWINDOW1''21', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'ddhien', NULL, CAST(N'2021-02-17 00:00:00.000' AS DateTime), N'61850', N'', NULL, NULL, NULL, NULL, N'V10161850', 39979, 0x89504E470D0A1A0A0000000D49484452000000790000001008060000003201D0DB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA864000002864944415458478D8D018AC4400CC3FAFF4FEFE103813009134189AD64E8F73BF27DDFFF476EECB8ED7B3BE8DDD4DB8173D876BCC33987ADB763DA87DEB933EDC3AB071CDE937CE17C39FDCCD871DBF776D0BBA9B703E7B0ED7887730E5B6FC7B40FBD7367DA87570F38BC27F9C2F972FA99B1E3B6EFEDA077536F07CE61DBF10EE71CB6DE8E691F7AE7CEB40FAF1E70784FF285F3E5F43363C76DDFDB41EFA6DE0E9CC3B6E31DCE396CBD1DD33EF4CE9D691F5E3DE0F09EE40BE7CBE967C68EDBBEB783DE4DBD1D38876DC73B9C73D87A3BA67DE89D3BD33EBC7AC0E13DC917CE97D3CF8C1DB77D6F07BD9B7A3B700EDB8E7738E7B0F5764CFBD03B77A67D78F580C37B922F9C2FA79F193B6EFBDE0E7A37F576E01CB61DEF70CE61EBED98F6A177EE4CFBF0EA0187F7245F385F4E3F3376DCF6BD1DF46EEAEDC0396C3BDEE19CC3D6DB31ED43EFDC99F6E1D5030EEF49BE70BE9C7E66ECB8ED7B3BE8DDD4DB8173D876BCC33987ADB763DA87DEB933EDC3AB071CDE937CE17C39FDCCD871DBF776D0BBA9B703E7B0ED7887730E5B6FC7B40FBD7367DA87570F38BC27F9C2F972FA99B1E3B6EFEDA077536F07CE61DBF10EE71CB6DE8E691F7AE7CEB40FAF1E70784FF285F3E5F43363C76DDFDB41EFA6DE0E9CC3B6E31DCE396CBD1DD33EF4CE9D691F5E3DE0F09EE40BE7CBE967C68EDBBEB783DE4DBD1D38876DC73B9C73D87A3BA67DE89D3BD33EBC7AC0E13DC917CE97D3CF8C1DB77D6F07BD9B7A3B700EDB8E7738E7B0F5764CFBD03B77A67D78F580C37B922F9C2FA79F193B6EFBDE0E7A37F576E01CB61DEF70CE61EBED98F6A177EE4CFBF0EA0187F7245F385F4E3F3376DCF6BD1DF46EEAEDC0396C3BDEE19CC3D6DB31ED43EFDC99F6E1D5030EEF497EF3FBFD01EA5B0D0D942E8FA90000000049454E44AE426082, NULL, 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'tplam', N'Lê Thị Tường Vân', CAST(N'2021-02-09 00:00:00.000' AS DateTime), N'61732', N'70518664', N'CÔNG TY CỔ PHẦN THƯƠNG MẠI TỔNG HỢP CAO BẰNG ', N' Số 005 đường Hoàng Như  ,Phường Hợp Giang, Thành phố Cao Bằng ,Tỉnh Cao Bằng, Việt Nam', N'2021_DME_POSM_WINDOW 1_NW', N'263852123', N'NWV10161732', 40071, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000037A4944415468438DCD01AA25410C42D1DEFFA6DF9081032209BF2E141AB5E9EFF7C8F77DFF1FDF64963B2FC9AC3714DDF54D7974B7DD9D21FD7075BE93A51FDA6FBDBBBBE1EAF9CE68E73CB60DE55F785E6E3F4B32CB9D9764D61B8AEEFAA63CBADBEECE907EB83ADFC9D20FEDB7DEDDDD70F57C67B4731EDB86F22F3C2FB79F2599E5CE4B32EB0D45777D531EDD6D7767483F5C9DEF64E987F65BEFEE6EB87ABE33DA398F6D43F9179E97DBCF92CC72E72599F586A2BBBE298FEEB6BB33A41FAECE77B2F443FBAD7777375C3DDF19ED9CC7B6A1FC0BCFCBED674966B9F392CC7A43D15DDF944777DBDD19D20F57E73B59FAA1FDD6BBBB1BAE9EEF8C76CE63DB50FE85E7E5F6B324B3DC794966BDA1E8AE6FCAA3BBEDEE0CE987ABF39D2CFDD07EEBDDDD0D57CF77463BE7B16D28FFC2F372FB599259EEBC24B3DE5074D737E5D1DD767786F4C3D5F94E967E68BFF5EEEE86ABE73BA39DF3D836947FE179B9FD2CC92C775E92596F28BAEB9BF2E86EBB3B43FAE1EA7C274B3FB4DF7A7777C3D5F39DD1CE796C1BCABFF0BCDC7E9664963B2FC9AC3714DDF54D7974B7DD9D21FD7075BE93A51FDA6FBDBBBBE1EAF9CE68E73CB60DE55F785E6E3F4B32CB9D9764D61B8AEEFAA63CBADBEECE907EB83ADFC9D20FEDB7DEDDDD70F57C67B4731EDB86F22F3C2FB79F2599E5CE4B32EB0D45777D531EDD6D7767483F5C9DEF64E987F65BEFEE6EB87ABE33DA398F6D43F9179E97DBCF92CC72E72599F586A2BBBE298FEEB6BB33A41FAECE77B2F443FBAD7777375C3DDF19ED9CC7B6A1FC0BCFCBED674966B9F392CC7A43D15DDF944777DBDD19D20F57E73B59FAA1FDD6BBBB1BAE9EEF8C76CE63DB50FE85E7E5F6B324B3DC794966BDA1E8AE6FCAA3BBEDEE0CE987ABF39D2CFDD07EEBDDDD0D57CF77463BE7B16D28FFC2F372FB599259EEBC24B3DE5074D737E5D1DD767786F4C3D5F94E967E68BFF5EEEE86ABE73BA39DF3D836947FE179B9FD2CC92C775E92596F28BAEB9BF2E86EBB3B43FAE1EA7C274B3FB4DF7A7777C3D5F39DD1CE796C1BCABFF0BCDC7E9664963B2FC9AC3714DDF54D7974B7DD9D21FD7075BE93A51FDA6FBDBBBBE1EAF9CE68E73CB60DE55F785E6E3F4B32CB9D9764D61B8AEEFAA63CBADBEECE907EB83ADFC9D20FEDB7DEDDDD70F57C67B4731EDB86F22F3C2FB79F2599E5CE4B32EB0D45777D531EDD6D7767483F5C9DEF64E987F65BEFEE6EB87ABE33DA398F6D43F9BFF9FDFE01BDFA3646888CF6600000000049454E44AE426082, N'DME-00000-023552-POSM WD1''21', 0)
INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] ([Username], [Nguoiyeucau], [Ngaythang], [Sophieu], [Nguoinhancode], [Nguoinhanname], [Diachi], [mucdich], [dienthoai], [seri], [id], [Barcode], [ghichu], [thuhang]) VALUES (N'tr1', N'Mai Van Truong', CAST(N'2021-09-23 00:00:00.000' AS DateTime), N'45698', N'1234124', N'àdsadfasdf', N'ádfasdf ,ádfadf ,Hà Nội', N'NKA on 2020', N'33214132', N'HNV10145698', 40078, 0x89504E470D0A1A0A0000000D494844520000008F000000130806000000A9C75EAB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA86400000321494441546843958D018AED480CC4DEFD2F3D4B2F0884B0F98EA049592E93DFDF91DFEFF7FF23173B7761BBB5E719BB76EA4D77D35C07CE8F6D37DDD97586EE9DEB4CBDBB80FBDAE14BBE706E4E3F3376EEC2766BCF3376EDD49BEEA6B90E9C1FDB6EBAB3EB0CDD3BD7997A7701F7B5C3977CE1DC9C7E66ECDC85EDD69E67ECDAA937DD4D731D383FB6DD7467D719BA77AE33F5EE02EE6B872FF9C2B939FDCCD8B90BDBAD3DCFD8B5536FBA9BE63A707E6CBBE9CEAE3374EF5C67EADD05DCD70E5FF2857373FA99B17317B65B7B9EB16BA7DE7437CD75E0FCD876D39D5D67E8DEB9CED4BB0BB8AF1DBEE40BE7E6F43363E72E6CB7F63C63D74EBDE96E9AEBC0F9B1EDA63BBBCED0BD739DA97717705F3B7CC917CECDE967C6CE5DD86EED79C6AE9D7AD3DD34D781F363DB4D77769DA17BE73A53EF2EE0BE76F8922F9C9BD3CF8C9DBBB0DDDAF38C5D3BF5A6BB69AE03E7C7B69BEEEC3A43F7CE75A6DE5DC07DEDF0255F3837A79F193B7761BBB5E719BB76EA4D77D35C07CE8F6D37DDD97586EE9DEB4CBDBB80FBDAE14BBE706E4E3F3376EEC2766BCF3376EDD49BEEA6B90E9C1FDB6EBAB3EB0CDD3BD7997A7701F7B5C3977CE1DC9C7E66ECDC85EDD69E67ECDAA937DD4D731D383FB6DD7467D719BA77AE33F5EE02EE6B872FF9C2B939FDCCD8B90BDBAD3DCFD8B5536FBA9BE63A707E6CBBE9CEAE3374EF5C67EADD05DCD70E5FF2857373FA99B17317B65B7B9EB16BA7DE7437CD75E0FCD876D39D5D67E8DEB9CED4BB0BB8AF1DBEE40BE7E6F43363E72E6CB7F63C63D74EBDE96E9AEBC0F9B1EDA63BBBCED0BD739DA97717705F3B7CC917CECDE967C6CE5DD86EED79C6AE9D7AD3DD34D781F363DB4D77769DA17BE73A53EF2EE0BE76F8922F9C9BD3CF8C9DBBB0DDDAF38C5D3BF5A6BB69AE03E7C7B69BEEEC3A43F7CE75A6DE5DC07DEDF0255F3837A79F193B7761BBB5E719BB76EA4D77D35C07CE8F6D37DDD97586EE9DEB4CBDBB80FBDAE14BBE706E4E3F3376EEC2766BCF3376EDD49BEEA6B90E9C1FDB6EBAB3EB0CDD3BD7997A7701F7B5C3977CE1DC9C7E66ECDC85EDD69E67ECDAA937DD4D731D383FB6DD7467D719BA77AE33F5EE02EE6B872FF9DFFCFDFD07955019718F09B0230000000049454E44AE426082, N'fd', 0)
SET IDENTITY_INSERT [dbo].[tbl_MKT_headRpt_Phieuissue] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKT_IO_Programe] ON 

INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21786', N'Region Local KA 2019', 1, N'Local KA', N'VN12', N'HN', N'OTH', 0, NULL, NULL, N'Region Local KA 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21721', N'Region focus 2019', 2, N'Region focus', N'VN12', N'HN', N'TTH;OTH;DAS;GRO;ERL;EDU;E&D;ATW', 0, NULL, NULL, N'Region focus 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22056', N'Chung niem tu hao - Ba mien dai thang', 3, N'', N'VN12', N'HN', N'TTH;GRO;ERL;EDU;E&D;ATW', 0, NULL, NULL, N'Window 2 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21949', N'Trưng bày kệ Nutri kids 2019', 4, N'', N'VN12', N'HN', N'GRO;E&D', 0, NULL, NULL, N'NUTR TETRA 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21807', N'2019_DME_GIFT_BEACH 2019_NE', 5, N'', N'VN16', N'NE', N'TTH;GRO;E&D', 0, NULL, NULL, N'2019_DME_GIFT_BEACH 2019_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'10152', N'NKA on 2020', 6, N'', N'VN12', N'HN', N'TTH;OTH;DAS;GRO;ERL;EDU;E&D;ATW', 0, NULL, NULL, N'NKA on 2020 -IO304220')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'10153', N'NKA off 2019', 7, N'', N'VN12', N'HN', N'SUP', 0, NULL, NULL, N'NKA off 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'1234T', N'NKA OFF', 8, N'', N'VN16', N'NE', N'SUP', 0, NULL, NULL, N'NKA OFF')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22021', N'Display vip rack 2019', 9, N'', N'VN12', N'HN', N'TTH;OTH;GRO;E&D', 0, NULL, NULL, N'VIP rack 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21526', N'Tet an uong P2 2019', 10, N'', N'VN12', N'HN', N'OTH;GRO;E&D', 0, NULL, NULL, N'Tet 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21183', N'Picos 2019', 11, N'', N'VN12', N'HN', N'TTH;OTH;DAS;GRO;ERL;EDU;E&D', 0, NULL, NULL, N'POSM Picos 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'1235T', N'ME - NE', 12, N'', N'VN16', N'NE', N'GRO;E&D', 0, NULL, NULL, N'ME - NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'1236T', N'Payment LKA', 13, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'Payment LKA')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21948', N'T SHIRT NUTRI TETRA 2019', 14, N'Ao cho nhan vien', N'VN12', N'HN', N'OTH;GRO;ERL;E&D', 0, NULL, NULL, N'POSM NUTRI TETRA 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'1237T', N'Nutriboost tháng 5', 15, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'Nutriboost tháng 5')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'1238T', N'Tri ân khách hàng 2018', 16, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'Tri ân khách hàng 2018')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21722', N'Regional focus 2019', 17, N'', N'VN19', N'NW', N'SUP;OTH;GRO;E&D', 0, NULL, NULL, N'Region focus 2019-NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21722', N'Regional focus 2019', 18, N'', N'VN19', N'NW', N'SUP;OTH;GRO;E&D', 0, NULL, NULL, N'Region focus 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21787', N'Regional LKA 2019', 19, N'', N'VN19', N'NW', N'SUP;OTH;GRO;EDU;E&D', 0, NULL, NULL, N'LKA 2019 -NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22022', N'Vip rack 2019', 20, N'kệ vip 2019', N'VN19', N'NW', N'SUP;OTH;GRO', 0, NULL, NULL, N'Vip rack 2019-NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'1239T', N'Xuất hàng trả NCC', 21, N'', N'VN16', N'NE', N'OTH', 0, NULL, NULL, N'Xuất hàng trả NCC')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21532', N'2018_TET_2019_NW', 22, N'', N'VN19', N'NW', N'SUP;OTH;GRO;E&D', 0, NULL, NULL, N'Tet 2019 NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'302561', N'DFR TET 2019_NW', 23, N'', N'VN12', N'NE', N'SUP;OTH;GRO;E&D', 0, NULL, NULL, N'Tet 2019 -NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21594', N'2018_DME_TET RURAL 2019_NW', 24, N'', N'VN19', N'NW', N'SUP;OTH;GRO;E&D', 0, NULL, NULL, N'Tet Rural 2019 NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'12346', N'Mutant 2019', 27, N'', N'VN19', N'NW', N'SUP;OTH;GRO;E&D', 0, NULL, NULL, N'Mutant 2019-NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22044', N'2019_DME_POSM_WINDOW 2_NE', 28, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2019_DME_POSM_WINDOW 2_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21687', N'2019_DME_POSM_WINDOW 1_NE', 29, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2019_DME_POSM_WINDOW 1_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'1240T', N'ASMPQ', 30, N'', N'VN16', N'NE', N'GRO;E&D', 0, NULL, NULL, N'ASMPQ')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21424', N'Mutant lauching 2018', 31, N'', N'VN19', N'NW', N'SUP;OTH;GRO;E&D', 0, NULL, NULL, N'Mutant lauching 2018 - NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21883', N'2019_DME_POSM_MERCHANDISE_BEACH_NE', 32, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2019_DME_POSM_MERCHANDISE_BEACH_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'1234N', N'ME-NW', 33, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'ME-NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'1240T', N'Hỗ trợ Mutant - Tháng 5,6 2019', 34, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'Hỗ trợ Mutant - Tháng 5,6 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'303000', N'2019_DFR_GIFT_MUTANT 2019_NW', 35, N'', N'VN19', N'NW', N'SUP;OTH;GRO;E&D', 0, NULL, NULL, N'Tra thuong Mutant 2019-NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'302851', N'2019_DFR_GIFT_WINDOW 1_NW', 36, N'', N'VN19', N'NW', N'SUP;OTH;GRO;E&D', 0, NULL, NULL, N'Tra thuong Fanta soda kem W1.2019 NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21800', N'Khai lộc đầu xuân - sung túc đầy đủ', 37, N'', N'VN12', N'HN', N'GRO;E&D', 0, NULL, NULL, N'Window 1 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21287', N'POSM NUTRI TETRA', 38, N'', N'VN12', N'HN', N'GRO;E&D', 0, NULL, NULL, N'NUTRI TETRA 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22043', N'2019_DME_POSM_WINDOW 2_NW', 39, N'', N'VN19', N'NW', N'SUP;OTH;GRO;E&D', 0, NULL, NULL, N'Posm Window2.2019 -NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'302951', N'2019_DFR_GIFT_FANTA CREAM LKA_NE', 40, N'', N'VN16', N'NE', N'OTH;E&D', 0, NULL, NULL, N'2019_DFR_GIFT_FANTA CREAM LKA_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21811', N'2019_DME_POSM_BEACH 2019_NE', 41, N'', N'VN16', N'NE', N'GRO;E&D', 0, NULL, NULL, N'2019_DME_POSM_BEACH 2019_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'1241T', N'Regional Focus - NE', 42, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'Regional Focus - NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21292', N'2018_DME NTB tetra pack launching  _NW', 43, N'', N'VN19', N'NW', N'TTH;SUP;OTH;DAS;GRO;ERL;EDU;E&D', 0, NULL, NULL, N'NutriTetra-NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21686', N'2019_DME_POSM_WINDOW 1_NW', 44, N'', N'VN19', N'NW', N'SUP;OTH;ERL;EDU;E&D', 0, NULL, NULL, N'Window1.2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21735', N'Red execution 2019', 45, N'', N'VN12', N'HN', N'OTH;GRO;E&D', 0, NULL, NULL, N'RED 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22148', N'2019_DME_POSM_WINDOW 3_NE', 46, N'', N'VN16', N'NE', N'GRO;E&D', 0, NULL, NULL, N'2019_DME_POSM_WINDOW 3_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22146', N'POSM Window 3 2019', 47, N'', N'VN12', N'HN', N'OTH;GRO;E&D', 0, NULL, NULL, N'Window 3 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22147', N'2019_DME_POSM_WINDOW 3_NW', 48, N'', N'VN19', N'NW', N'TTH;SUP;OTH;DAS;GRO;ERL;EDU;E&D', 0, NULL, NULL, N'POSM Window 3.2019 -NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22154', N'Gift Window3.2019.NW-Aquarius Zero', 49, N'', N'VN19', N'NW', N'TTH;SUP;OTH;DAS;GRO;ERL;EDU;E&D', 0, NULL, NULL, N'2019_DME_GIFT_WINDOW 3_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21949', N'POSTER NUTRI BEAUTY- TOGO', 50, N'', N'VN12', N'HN', N'GRO;E&D', 0, NULL, NULL, N'NUTRI 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21949', N'2019_DME_R&W_HN_POSM', 51, N'', N'VN19', N'NW', N'TTH;SUP;OTH;DAS;GRO;ERL;EDU;E&D', 0, NULL, NULL, N'Hỗ trợ posm R&W -NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'1242T', N'Hỗ trợ R&W - NE', 52, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'Hỗ trợ R&W - NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22242', N'2019_DME_GIFT_COKE ED_NE', 53, N'', N'VN16', N'NE', N'GRO;E&D', 0, NULL, NULL, N'2019_DME_GIFT_COKE ED_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22241', N'Gift Coke Energy_ NW', 54, N'', N'VN19', N'NW', N'TTH;SUP;OTH;GRO;ERL;EDU;E&D', 0, NULL, NULL, N'Gift-Coke Enerrgy_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21764', N'2019_DME_SAMPLING_OTHERS_NE', 55, N'', N'VN16', N'NE', N'OTH', 0, NULL, NULL, N'2019_DME_SAMPLING_OTHERS_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22298', N'Trung bay Tet 2020', 56, N'', N'VN12', N'HN', N'SUP;OTH;GRO;ERL;E&D;ATW', 0, NULL, NULL, N'Tet 2020')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22299', N'Kick off Tet 2020 NW', 57, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'Kick off Tet 2020 NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'303381', N'2019_DFR_GIFT_WINDOW 3_NE', 58, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2019_DFR_GIFT_WINDOW 3_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22327', N'2020_DME_ACT_TET 2020 POSM_NE', 59, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2020_DME_ACT_TET 2020 POSM_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22155', N'2019_DME_GIFT_WINDOW 3_NE', 60, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2019_DME_GIFT_WINDOW 3_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'303382', N'2019_DFR_GIFT_WINDOW 3_NW', 61, N'', N'VN19', N'NW', N'TTH;SUP;OTH;DAS;GRO;ERL;EDU;E&D', 0, NULL, NULL, N'2019_DFR_GIFT_WINDOW 3_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22326', N'2019_DME_ACT_TET 2020 POSM_NW', 62, N'', N'VN19', N'NW', N'TTH;SUP;OTH;DAS;GRO;EDU;E&D', 0, NULL, NULL, N'2019_DME_ACT_TET 2020 POSM_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22294', N' 2019_DME_R&W_NW_Gift ', 63, N'', N'VN19', N'NW', N'TTH;SUP;OTH;DAS;GRO;ERL;EDU;E&D', 0, NULL, NULL, N' 2019_DME_R&W_NW_Gift ')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22291', N'Nutri Kids', 1063, N'Nutri tetra', N'VN12', N'HN', N'TTH;SUP;OTH;GRO;ERL;EDU;E&D', 0, NULL, NULL, N'Nutri kids 2019')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22574', N'2020_DME_POSM_FESTIVAL NORTH 2020_NE', 1064, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2020_DME_POSM_FESTIVAL NORTH 2020_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'303602', N'2019_DFR_GIFT_COKE ED NOV-DEC_NW', 1065, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'2019_DFR_GIFT_COKE ED NOV-DEC_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22197', N'2019_DME_POSM_MARKET SUPPORT_NE', 1066, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2019_DME_POSM_MARKET SUPPORT_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22196', N'2019_DME_POSM_MARKET SUPPORT_NW', 1067, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'2019_DME_POSM_MARKET SUPPORT_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22561', N'2019_DME_POSM_WINTER MELON_NW', 1068, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'2019_DME_POSM_WINTER MELON_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'303603', N'2019_DFR_GIFT_COKE ED NOV-DEC_NE', 1069, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2019_DFR_GIFT_COKE ED NOV-DEC_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22326', N'2019_DME_ACT_TET 2020 POSM_NW', 1070, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'2019_DME_ACT_TET 2020 POSM_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22573', N'FESTIVAL NW 2020', 1071, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'2019_DME_POSM_FESTIVAL NORTH 2020_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'303697', N'Lễ hội 2020 Hà Nội', 1072, N'', N'VN12', N'HN', N'TTH;OTH;GRO;ERL;E&D', 0, NULL, NULL, N'Festival 2020')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'303501', N'2019_DFR_GIFT_TET 2020 PHASE 1_NW', 1073, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'2019_DFR_GIFT_TET 2020 PHASE 1_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21736', N'2019_DME_POSM_OTHERS_NW', 1074, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'2019_DME_POSM_OTHERS_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22449', N'2019_DME_GIFT_TET 2020_NE', 1075, N'', N'VN16', N'NE', N'GRO;E&D', 0, NULL, NULL, N'2019_DME_GIFT_TET 2020_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'303502', N'2019_DFR_GIFT_TET 2020 PHASE 1_NE', 1076, N'', N'VN16', N'NE', N'GRO;E&D', 0, NULL, NULL, N'2019_DFR_GIFT_TET 2020 PHASE 1_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'21737', N'2019_DME_POSM_OTHERS_NE', 1077, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2019_DME_POSM_OTHERS_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'303699', N'DFR_GIFT_FESTIVAL NORTH 2020_NE', 1078, N'', N'VN16', N'NE', N'OTH;GRO;EDU', 0, NULL, NULL, N'DFR_GIFT_FESTIVAL NORTH 2020_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22628', N'2019_DME_GIFT_NTB SUPPORT_NE', 1079, N'', N'VN16', N'NE', N'GRO;E&D', 0, NULL, NULL, N'2019_DME_GIFT_NTB SUPPORT_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'70249887', N'PAC-NW', 1080, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'PAC-NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22681', N'2020_DME_POSM_REGIONAL FOCUS_NW', 1081, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'Regional Focus 2020-NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22593', N'Mua Nutri 297ml tặng áo mưa Nutri ', 1082, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'2019_DME_GIFT_NTB RAINCOAT_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22627', N'2019_DME_GIFT_NTB SUPPORT_NW', 1083, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'2019_DME_GIFT_NTB SUPPORT_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'10152', N'NKA on 2020', 1084, N'', N'VN12', N'HN', N'TTH;OTH;DAS;GRO;ERL;EDU;E&D;ATW', 0, NULL, NULL, N'NKA on 2020')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22680', N'Regional focus 2020', 1085, N'', N'VN12', N'HN', N'TTH;OTH;DAS;GRO;ERL;EDU;E&D;ATW', 0, NULL, NULL, N'Regional focus 2020')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22687', N'Regional Local KA 2020', 1086, N'', N'VN12', N'HN', N'TTH;OTH;DAS;GRO;ERL;EDU;E&D;ATW', 0, NULL, NULL, N'Regional Local KA 2020')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'10153', N'NKA off 2020', 1087, N'', N'VN12', N'HN', N'SUP;OTH', 0, NULL, NULL, N'NKA off 2020')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22248', N'2019_DME_POSM_COKE ED_NW', 1088, N'', N'VN19', N'NW', N'OTH', 0, NULL, NULL, N'2019_DME_POSM_COKE ED_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22841', N'DME_POSM_FESTIVAL NORTH 2020_NE', 1089, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'DME_POSM_FESTIVAL NORTH 2020_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22249', N'2019_DME_POSM_COKE ED_NE', 1090, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2019_DME_POSM_COKE ED_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22247', N'Coke Energy 2020', 1092, N'', N'VN12', N'HN', N'OTH;GRO;E&D', 0, NULL, NULL, N'Coke Energy 2020')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22734', N'Window 1 2020', 1093, N'', N'VN12', N'HN', N'OTH;GRO;E&D', 0, NULL, NULL, N'Window 1 2020')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22736', N'2020_DME_POSM_WINDOW 1_NE', 1094, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2020_DME_POSM_WINDOW 1_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22753', N'2020_DME_POSM_WINDOW 1_NW', 1095, N'', N'VN19', N'NW', N'SUP;OTH;GRO;E&D', 0, NULL, NULL, N'2020_DME_POSM_WINDOW 1_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22722', N'2020_DME_POSM_LOYALTY PROGRAM_NE', 1097, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2020_DME_POSM_LOYALTY PROGRAM_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22720', N'Loyalty 2020', 1098, N'', N'VN12', N'HN', N'OTH;GRO;E&D', 0, NULL, NULL, N'Loyalty 2020')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22968', N'NUOC RUA TAY', 1099, N'', N'VN12', N'HN', N'OTH;GRO;E&D', 0, NULL, NULL, N'NUOC RUA TAY')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22941', N'2020_DME_POSM_BEACH 2020_NE', 1100, N'', N'VN16', N'NE', N'OTH;GRO;E&D', 0, NULL, NULL, N'2020_DME_POSM_BEACH 2020_NE')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22695', N'Payment LKA NW 2020', 1101, N'', N'VN19', N'NW', N'TTH;SUP;OTH;DAS;GRO;ERL;EDU;E&D', 0, NULL, NULL, N'2020_DME_POSM_REGIONAL LKA CONTRACT_NW')
INSERT [dbo].[tbl_MKT_IO_Programe] ([IO_number], [IO_Name], [id], [ghichu], [Sales_Org], [Region], [ChannelGroup], [Budget], [Avaiable_Budget], [Spent_Budget], [ProgrameIDDocno]) VALUES (N'22721', N'LOYALTY 2020', 1102, N'', N'VN19', N'NW', N'GRO;E&D', 0, NULL, NULL, N'2020_DME_POSM_LOYALTY PROGRAM_NW')
GO
SET IDENTITY_INSERT [dbo].[tbl_MKT_IO_Programe] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKT_khoMKT] ON 

INSERT [dbo].[tbl_MKT_khoMKT] ([tenkho], [makho], [id], [diachikho], [ghichu], [storeright]) VALUES (N'Hà nội branch', N'V101', 1, N'Duyên Thái- Thường Tín -Hà Nội', N'', N'HN')
INSERT [dbo].[tbl_MKT_khoMKT] ([tenkho], [makho], [id], [diachikho], [ghichu], [storeright]) VALUES (N'HCM', N'V050', 2, N'THỦ ĐỨC - HCM', N'', N'HN')
SET IDENTITY_INSERT [dbo].[tbl_MKT_khoMKT] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKt_ListLoadhead] ON 

INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'29', CAST(N'2019-05-13 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 29, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29c 39967', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'32', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Luu Khanh Toan', 32, N'Delivering', N'lktoan', N'V101', N'TM', N'Cty Thành Mỹ', N'29U7 - 1426', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'34', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Luu Khanh Toan', 34, N'Delivering', N'lktoan', N'V101', N'01234', N'Hoàng Dương', N'29C 578.02', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'41', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Luu Khanh Toan', 41, N'Delivering', N'lktoan', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C 399.67', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'42', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Luu Khanh Toan', 42, N'Delivering', N'lktoan', N'V101', N'HT', N'Công ty Hưng Thinh', N'29c 399.67', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'47', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Luu Khanh Toan', 47, N'Delivering', N'lktoan', N'V101', N'DT', N'Cty Đại Thành', N'29C 57306', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'48', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Luu Khanh Toan', 48, N'Delivering', N'lktoan', N'V101', N'HT', N'Công ty Hưng Thinh', N'29c 39967', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'49', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Luu Khanh Toan', 49, N'Delivering', N'lktoan', N'V101', N'HT', N'Công ty Hưng Thinh', N'29c39967', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'50', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Luu Khanh Toan', 50, N'Delivering', N'lktoan', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C40277', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'51', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 51, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29c 37363', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'54', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 54, N'Delivering', N'nvhai', N'V101', N'TM', N'Cty Thành Mỹ', N'29c 68711', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'56', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 56, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29c45215', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'58', CAST(N'2019-05-14 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 58, N'Delivering', N'nvhai', N'V101', N'HL', N'HTX Hồng Liên', N'29c 57059', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'62', CAST(N'2019-05-15 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 62, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C 39967', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'65', CAST(N'2019-05-15 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 65, N'Delivering', N'nvhai', N'V101', N'BV', N'Cty Bình Vinh', N'43c01017', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'68', CAST(N'2019-05-15 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 68, N'Delivering', N'nvhai', N'V101', N'DT', N'Cty Đại Thành', N'29C 59423', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'70', CAST(N'2019-05-15 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 70, N'Delivering', N'nvhai', N'V101', N'TM', N'Cty Thành Mỹ', N'29c 68811', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (NULL, NULL, NULL, 73, N'TMP', N'dxuandien', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'75', CAST(N'2019-05-16 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 75, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C 39967', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'76', CAST(N'2019-05-16 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 76, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C37363', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'77', CAST(N'2019-05-16 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 77, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C38605', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'78', CAST(N'2019-05-16 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 78, N'Delivering', N'nvhai', N'V101', N'BV', N'Cty Bình Vinh', N'43C07692', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'79', CAST(N'2019-05-16 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 79, N'Delivering', N'nvhai', N'V101', N'TM', N'Cty Thành Mỹ', N'29C48161', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'80', CAST(N'2019-05-16 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 80, N'Delivering', N'nvhai', N'V101', N'HL', N'HTX Hồng Liên', N'29c 43686', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'85', CAST(N'2019-05-16 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 85, N'Delivering', N'nvhai', N'V101', N'HL', N'HTX Hồng Liên', N'29c38688', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'88', CAST(N'2019-05-17 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 88, N'Delivering', N'nvhai', N'V101', N'HL', N'HTX Hồng Liên', N'29c38688', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'93', CAST(N'2019-05-17 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 93, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29c 39967', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'94', CAST(N'2019-05-17 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 94, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29c 37363', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'97', CAST(N'2019-05-17 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 97, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C00593', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'99', CAST(N'2019-05-17 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 99, N'Delivering', N'nvhai', N'V101', N'HL', N'HTX Hồng Liên', N'29C 36868', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'101', CAST(N'2019-05-20 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 101, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C 39967', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'116', CAST(N'2019-05-20 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 116, N'Delivering', N'nvhai', N'V101', N'012', N'Quang Huy', N'0123', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'158', CAST(N'2019-05-20 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 158, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C00721', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'171', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 171, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C37363', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'174', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Luu Khanh Toan', 174, N'Delivering', N'LKTOAN', N'V101', N'01234', N'Hoàng Dương', N'29c 578.02', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'175', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 175, N'Delivering', N'nvhai', N'V101', N'01234', N'Hoàng Dương', N'29C57802', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'176', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Luu Khanh Toan', 176, N'Delivering', N'LKTOAN', N'V101', N'01234', N'Hoàng Dương', N'29c 578.02', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'179', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 179, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C39967', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'180', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 180, N'Delivering', N'nvhai', N'V101', N'01234', N'Hoàng Dương', N'29C66594', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'181', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 181, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C 39967', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'183', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 183, N'Delivering', N'nvhai', N'V101', N'TM', N'Cty Thành Mỹ', N'29c38611', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'184', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 184, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29c39967', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'186', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 186, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29c 373.63', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'197', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 197, N'Delivering', N'nvhai', N'V101', N'DT', N'Cty Đại Thành', N'29C59423', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'198', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 198, N'Delivering', N'nvhai', N'V101', N'DT', N'Cty Đại Thành', N'29C06386', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'199', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 199, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C36085', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'204', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 204, N'Delivering', N'nvhai', N'V101', N'TM', N'Cty Thành Mỹ', N'29C36046', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'207', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 207, N'Delivering', N'nvhai', N'V101', N'BV', N'Cty Bình Vinh', N'43C08796', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'209', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 209, N'Delivering', N'nvhai', N'V101', N'TM', N'Cty Thành Mỹ', N'29C48681', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'216', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 216, N'Delivering', N'nvhai', N'V101', N'TM', N'Cty Thành Mỹ', N'29C68988', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'221', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 221, N'Delivering', N'nvhai', N'V101', N'TM', N'Cty Thành Mỹ', N'29C37124', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'233', CAST(N'2019-05-21 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 233, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C37363', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'243', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 243, N'Delivering', N'tplam', N'V101', N'HL', N'HTX Hồng Liên', N'29C394.48', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'245', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 245, N'Delivering', N'tplam', N'V101', N'DT', N'Cty Đại Thành', N'29H-064.11', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'247', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 247, N'Delivering', N'tplam', N'V101', N'DT', N'Cty Đại Thành', N'29H-002.66', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'249', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 249, N'Delivering', N'tplam', N'V101', N'HL', N'HTX Hồng Liên', N'29C412.45', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'256', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 256, N'Delivering', N'tplam', N'V101', N'TM', N'Cty Thành Mỹ', N'29C394.48', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'260', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 260, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'43C095.59', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'267', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 267, N'Delivering', N'tplam', N'V101', N'TM', N'Cty Thành Mỹ', N'43C097.35', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'272', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 272, N'Delivering', N'tplam', N'V101', N'DT', N'Cty Đại Thành', N'29H-083-70', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'273', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 273, N'Delivering', N'tplam', N'V101', N'DT', N'Cty Đại Thành', N'29H-083-70', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'274', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 274, N'Delivering', N'tplam', N'V101', N'HL', N'HTX Hồng Liên', N'29C384.93', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'275', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 275, N'Delivering', N'tplam', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C-537.06', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'279', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 279, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C39967', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'281', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 281, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'43C037.83', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'282', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 282, N'Delivering', N'tplam', N'V101', N'TM', N'Cty Thành Mỹ', N'43C037.83', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'283', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 283, N'Delivering', N'nvhai', N'V101', N'HL', N'HTX Hồng Liên', N'29C38688', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'284', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 284, N'Delivering', N'tplam', N'V101', N'TM', N'Cty Thành Mỹ', N'43C037.83', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'286', CAST(N'2019-05-22 00:00:00.000' AS DateTime), N'Nguyen Van Hai', 286, N'Delivering', N'nvhai', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C37363', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'308', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 308, N'Delivering', N'tplam', N'V101', N'TM', N'Cty Thành Mỹ', N'29C 448-21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'311', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 311, N'Delivering', N'tplam', N'V101', N'TM', N'Cty Thành Mỹ', N'29C 448-21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'312', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 312, N'Delivering', N'tplam', N'V101', N'DT', N'Cty Đại Thành', N'29C 448-21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'313', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 313, N'Delivering', N'tplam', N'V101', N'DT', N'Cty Đại Thành', N'29C 448-21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'314', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 314, N'Delivering', N'nvhai', N'V101', N'DT', N'Cty Đại Thành', N'29c06386', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'315', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 315, N'Delivering', N'tplam', N'V101', N'DT', N'Cty Đại Thành', N'29C 448-21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'316', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 316, N'Delivering', N'tplam', N'V101', N'DT', N'Cty Đại Thành', N'29C-395.57', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'317', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 317, N'Delivering', N'tplam', N'V101', N'TM', N'Cty Thành Mỹ', N'29C-593.97', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'318', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 318, N'Delivering', N'tplam', N'V101', N'HT', N'Công ty Hưng Thinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'319', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 319, N'Delivering', N'tplam', N'V101', N'HT', N'Công ty Hưng Thinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'320', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 320, N'Delivering', N'tplam', N'V101', N'TM', N'Cty Thành Mỹ', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'321', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 321, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'322', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 322, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'323', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 323, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'324', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 324, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'325', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 325, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'326', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 326, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'327', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 327, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'328', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 328, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'329', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 329, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'331', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 331, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'332', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 332, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'334', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 334, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'335', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 335, N'Delivering', N'tplam', N'V101', N'BV', N'Cty Bình Vinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'337', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 337, N'Delivering', N'tplam', N'V101', N'HT', N'Công ty Hưng Thinh', N'29C593.08', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'338', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 338, N'Delivering', N'tplam', N'V101', N'HT', N'Công ty Hưng Thinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'339', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 339, N'Delivering', N'tplam', N'V101', N'HT', N'Công ty Hưng Thinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'340', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 340, N'Delivering', N'tplam', N'V101', N'HT', N'Công ty Hưng Thinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'342', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 342, N'Delivering', N'tplam', N'V101', N'HT', N'Công ty Hưng Thinh', N'29H007.21', NULL)
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (N'343', CAST(N'2019-05-23 00:00:00.000' AS DateTime), N'Truong Phuc Lam', 343, N'Delivering', N'tplam', N'V101', N'HT', N'Công ty Hưng Thinh', N'29H007.21', NULL)
GO
INSERT [dbo].[tbl_MKt_ListLoadhead] ([LoadNumber], [Date_Created], [Created_by], [id], [Status], [Username], [ShippingPoint], [TransposterCode], [TransposterName], [Truckno], [pallet]) VALUES (NULL, NULL, NULL, 345, N'TMP', N'tr1', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_MKt_ListLoadhead] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKt_Listphieudetail] ON 

INSERT [dbo].[tbl_MKt_Listphieudetail] ([Gate_pass], [Date_Received_Issued], [Requested_by], [Customer_SAP_Code], [Receiver_by], [Address], [Tel], [Purpose], [Item], [Materiacode], [Description], [Issued], [Ngaytaophieu], [id], [MateriaSAPcode], [Soluongdaxuat], [Soluongconlai], [Status], [Ngayhoanthanh], [Username], [Purposeid], [Unit], [ShippingPoint], [Materialname], [Loadingby], [ShipmentNumber], [Shipmentby], [Tranposterby], [Truck], [Region], [Completed_by], [Price], [NetValue], [Returnby], [Returndate], [ReturnQuantity], [Delivery_date], [Issued_dated], [Included_Shipment], [pallet], [Note], [shiptocity], [Return_reason], [Returnrequest]) VALUES (N'45698', NULL, N'Mai Van Truong', N'1234124', N'àdsadfasdf', N'ádfasdf ,ádfadf ,Hà Nội', N'33214132', N'NKA on 2020', NULL, N'13', NULL, 12, CAST(N'2021-09-23 00:00:00.000' AS DateTime), 128, N'124', NULL, NULL, N'CRT', NULL, N'tr1', N'10152', N'cái', N'V101', N'adfasf', NULL, NULL, NULL, NULL, NULL, N'HN', NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, N'fd', N'Hà Nội', NULL, NULL)
INSERT [dbo].[tbl_MKt_Listphieudetail] ([Gate_pass], [Date_Received_Issued], [Requested_by], [Customer_SAP_Code], [Receiver_by], [Address], [Tel], [Purpose], [Item], [Materiacode], [Description], [Issued], [Ngaytaophieu], [id], [MateriaSAPcode], [Soluongdaxuat], [Soluongconlai], [Status], [Ngayhoanthanh], [Username], [Purposeid], [Unit], [ShippingPoint], [Materialname], [Loadingby], [ShipmentNumber], [Shipmentby], [Tranposterby], [Truck], [Region], [Completed_by], [Price], [NetValue], [Returnby], [Returndate], [ReturnQuantity], [Delivery_date], [Issued_dated], [Included_Shipment], [pallet], [Note], [shiptocity], [Return_reason], [Returnrequest]) VALUES (N'45698', NULL, N'Mai Van Truong', N'1234124', N'àdsadfasdf', N'ádfasdf ,ádfadf ,Hà Nội', N'33214132', N'NKA on 2020', NULL, N'13', NULL, 1, CAST(N'2021-09-23 00:00:00.000' AS DateTime), 129, N'124', NULL, NULL, N'CRT', NULL, N'tr1', N'10152', N'cái', N'V101', N'adfasf', NULL, NULL, NULL, NULL, NULL, N'HN', NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, N'fd', N'Hà Nội', NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_MKt_Listphieudetail] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKt_Listphieuhead] ON 

INSERT [dbo].[tbl_MKt_Listphieuhead] ([Gate_pass], [Date_Received_Issued], [Requested_by], [Customer_SAP_Code], [Receiver_by], [Address], [Tel], [Purpose], [Ngaytaophieu], [id], [Status], [Username], [Purposeid], [ShippingPoint], [LoadNumber], [completed], [completedby], [Tranposterby], [Region], [ShiptoCode], [ShiptoName], [ShiptoAddress], [Note], [Trucknumber], [requestReturn]) VALUES (N'45697', NULL, N'Mai Van Truong', 1234124, N'àdsadfasdf', N'ádfasdf ,ádfadf ,Hà Nội', N'33214132', N'NKA on 2020', CAST(N'2021-09-23 00:00:00.000' AS DateTime), 45697, N'CRT', N'tr1', N'10152', N'V101', NULL, 0, NULL, NULL, N'HN', 1234124, N'àdsadfasdf', N'ádfasdf ,ádfadf ,Hà Nội', N'ádadf', NULL, 0)
INSERT [dbo].[tbl_MKt_Listphieuhead] ([Gate_pass], [Date_Received_Issued], [Requested_by], [Customer_SAP_Code], [Receiver_by], [Address], [Tel], [Purpose], [Ngaytaophieu], [id], [Status], [Username], [Purposeid], [ShippingPoint], [LoadNumber], [completed], [completedby], [Tranposterby], [Region], [ShiptoCode], [ShiptoName], [ShiptoAddress], [Note], [Trucknumber], [requestReturn]) VALUES (N'45698', NULL, N'Mai Van Truong', 1234124, N'àdsadfasdf', N'ádfasdf ,ádfadf ,Hà Nội', N'33214132', N'NKA on 2020', CAST(N'2021-09-23 00:00:00.000' AS DateTime), 45698, N'CRT', N'tr1', N'10152', N'V101', NULL, 0, NULL, NULL, N'HN', 1234124, N'àdsadfasdf', N'ádfasdf ,ádfadf ,Hà Nội', N'fd', NULL, 0)
SET IDENTITY_INSERT [dbo].[tbl_MKt_Listphieuhead] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKT_Nhacungungvantai] ON 

INSERT [dbo].[tbl_MKT_Nhacungungvantai] ([tenNVT], [maNVT], [diachiNVT], [masothueNVT], [dienthoaiNVT], [id]) VALUES (N'NP', N'NP', N'Duyen thai', N'098797897', N'09797807', 1)
SET IDENTITY_INSERT [dbo].[tbl_MKT_Nhacungungvantai] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKT_Region] ON 

INSERT [dbo].[tbl_MKT_Region] ([Region], [id], [Note]) VALUES (N'VN12', 1, N'VN12')
INSERT [dbo].[tbl_MKT_Region] ([Region], [id], [Note]) VALUES (N'VN16', 2, N'VN16')
SET IDENTITY_INSERT [dbo].[tbl_MKT_Region] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKT_SaleOrg] ON 

INSERT [dbo].[tbl_MKT_SaleOrg] ([SaleOrg], [id], [Note]) VALUES (N'Vn12', 1, N'Vn12')
SET IDENTITY_INSERT [dbo].[tbl_MKT_SaleOrg] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKT_Soldtocode] ON 

INSERT [dbo].[tbl_MKT_Soldtocode] ([Customer], [ShiptoCode], [Soldtype], [FullNameN], [id], [Telephone1], [Note], [District], [SalesOrg], [Street], [City], [Region], [PaymentTerms], [PriceList], [KeyAcc], [SalesDistrict], [VATregistrationNo], [Createdon], [Createby], [Chanel]) VALUES (N'12343214', N'1234', 1, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_MKT_Soldtocode] ([Customer], [ShiptoCode], [Soldtype], [FullNameN], [id], [Telephone1], [Note], [District], [SalesOrg], [Street], [City], [Region], [PaymentTerms], [PriceList], [KeyAcc], [SalesDistrict], [VATregistrationNo], [Createdon], [Createby], [Chanel]) VALUES (N'1234124', N'1234124', 1, N'àdsadfasdf', 2, N'33214132', N'ádfsadf', N'ádfadf', N'Vn12', N'ádfasdf', N'Hà Nội', N'VN12', NULL, NULL, NULL, NULL, NULL, CAST(N'2021-09-23 00:00:00.000' AS DateTime), N'tr1', N'ATW')
INSERT [dbo].[tbl_MKT_Soldtocode] ([Customer], [ShiptoCode], [Soldtype], [FullNameN], [id], [Telephone1], [Note], [District], [SalesOrg], [Street], [City], [Region], [PaymentTerms], [PriceList], [KeyAcc], [SalesDistrict], [VATregistrationNo], [Createdon], [Createby], [Chanel]) VALUES (N'1234', N'1234', 1, N'dáDSAd', 3, N'2341234', N'ádfadf', N'ádfdasf', N'Vn12', N'aDSads', N'Hà Nội', N'VN12', NULL, NULL, NULL, NULL, NULL, CAST(N'2021-09-23 00:00:00.000' AS DateTime), N'tr1', N'ATW')
SET IDENTITY_INSERT [dbo].[tbl_MKT_Soldtocode] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKT_Stockend] ON 

INSERT [dbo].[tbl_MKT_Stockend] ([SAP_CODE], [ITEM_Code], [MATERIAL], [Description], [UNIT], [END_STOCK], [id], [Store_code], [TransferingOUT], [Ordered], [RegionBudgeted], [ON_Hold], [Quantity_Per_Pallet], [End_Stock_By_Pallet]) VALUES (N'124', N'13', N'adfasf', NULL, N'cái', 100, 1, N'V101', 0, 26, 0, NULL, NULL, NULL)
INSERT [dbo].[tbl_MKT_Stockend] ([SAP_CODE], [ITEM_Code], [MATERIAL], [Description], [UNIT], [END_STOCK], [id], [Store_code], [TransferingOUT], [Ordered], [RegionBudgeted], [ON_Hold], [Quantity_Per_Pallet], [End_Stock_By_Pallet]) VALUES (N'234', N'1234', N'dfasfdasf', N'fasfdafdasf', N'cái', 0, 2, N'V101', NULL, NULL, 0, NULL, NULL, NULL)
INSERT [dbo].[tbl_MKT_Stockend] ([SAP_CODE], [ITEM_Code], [MATERIAL], [Description], [UNIT], [END_STOCK], [id], [Store_code], [TransferingOUT], [Ordered], [RegionBudgeted], [ON_Hold], [Quantity_Per_Pallet], [End_Stock_By_Pallet]) VALUES (N'r56', N'r56', N'adfadsfadf', N'adsfadsf', N'cái', 0, 3, N'V101', NULL, NULL, 0, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_MKT_Stockend] OFF
SET IDENTITY_INSERT [dbo].[tbl_MKT_StoreRight] ON 

INSERT [dbo].[tbl_MKT_StoreRight] ([makho], [storeright], [id]) VALUES (N'V100', N'HN', 1)
INSERT [dbo].[tbl_MKT_StoreRight] ([makho], [storeright], [id]) VALUES (N'V101', N'HN', 2)
SET IDENTITY_INSERT [dbo].[tbl_MKT_StoreRight] OFF
SET IDENTITY_INSERT [dbo].[tbl_Temp] ON 

INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (1, 80, N'HN', N'tr1                                                                                                                                                                                                                              ', N'123123                                                                                                                                                                                                                           ', N'Mai Van Truong', 1, 1, N'HN', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (2, 80, N'NE', N'vnvanle                                                                                                                                                                                                                          ', N'vanle                                                                                                                                                                                                                            ', N'Lê Thanh Vân', 0, 1, N'HN', 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (3, 80, N'North', N'vnhuonglan                                                                                                                                                                                                                       ', N'123456                                                                                                                                                                                                                           ', N'Lê Thị Hương Lan', 0, 0, N'HN', 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (4, 80, N'HN', N'vndhuong                                                                                                                                                                                                                         ', N'211217                                                                                                                                                                                                                           ', N'Dinh Thi Thu Huong', 0, 1, N'HN', 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (5, 80, N'NW', N'lttvan                                                                                                                                                                                                                           ', N'lttvan                                                                                                                                                                                                                           ', N'Lê Thị Tường Vân', 0, 1, N'HN', 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (6, 80, N'North', N'nvson                                                                                                                                                                                                                            ', N'02031990                                                                                                                                                                                                                         ', N'Nguyễn Văn Sơn', 0, 0, N'HN', 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (7, 80, N'North', N'lktoan                                                                                                                                                                                                                           ', N'lktoan312                                                                                                                                                                                                                        ', N'Luu Khanh Toan', 0, 0, N'HN', 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (8, 80, N'North', N'nvhai                                                                                                                                                                                                                            ', N'sodagau123+                                                                                                                                                                                                                      ', N'Nguyen Van Hai', 0, 0, N'HN', 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (9, 80, N'North', N'dvthuy                                                                                                                                                                                                                           ', N'dvthuy                                                                                                                                                                                                                           ', N'Do Van Thuy', 0, 0, N'HN', 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (10, 80, N'North', N'thunt                                                                                                                                                                                                                            ', N'thunt                                                                                                                                                                                                                            ', N'Nguyen Thi Thu', 0, 0, N'HN', 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (11, 80, N'North', N'dxuandien                                                                                                                                                                                                                        ', N'dxuandien                                                                                                                                                                                                                        ', N'Dinh Xuan Dien', 0, 0, N'HN', 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (12, 80, N'North', N'tbichloan                                                                                                                                                                                                                        ', N'tbichloan                                                                                                                                                                                                                        ', N'Tran Thi Bich Loan', 0, 0, N'HN', 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (13, 80, N'North', N'tplam                                                                                                                                                                                                                            ', N'tplam                                                                                                                                                                                                                            ', N'Truong Phuc Lam', 0, 0, N'HN', 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (14, 80, N'North', N'ddhien                                                                                                                                                                                                                           ', N'ddhien                                                                                                                                                                                                                           ', N'Do Duc Hien', 0, 0, N'HN', 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (15, 80, N'North', N'dvcanh                                                                                                                                                                                                                           ', N'dvcanh                                                                                                                                                                                                                           ', N'Dao Van Canh', 0, 0, N'HN', 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (16, 80, N'North', N'loant                                                                                                                                                                                                                            ', N'loant                                                                                                                                                                                                                            ', N'Tran Thi Loan', 0, 0, N'HN', 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0)
INSERT [dbo].[tbl_Temp] ([id], [Version], [Region], [Username], [Password], [Name], [System], [MakettingRight], [storeright], [LoadRight], [WareHouseRight], [ReportsRight], [Inventory], [InventoryAprroval], [StoreLocationmanage], [addNewProduct], [IOprogamecreatRight], [Loadcreated], [StoreIssue], [TransferOut], [TransferIN], [ChanelManage], [IOmanageright], [SetPOSMprogrameright], [ViewProgramePDFright], [AprovalPaymentRequestright], [updateGatePassDeliveredright], [RequestpaymentApproval], [uploadBeginStoreright], [ControlUsername], [CustomerEdit], [CustomerUploadright], [SalesLocationright], [SalesRegionManageright], [ChannelsalesManageright], [ReturnTicket], [doMoreReturnticket], [doViewcounting], [changeProduct], [deleteProduct]) VALUES (17, 80, N'North', N'Nga                                                                                                                                                                                                                              ', N'Nga                                                                                                                                                                                                                              ', N'Tran Thi Hong Nga', 0, 0, N'HN', 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[tbl_Temp] OFF
ALTER TABLE [dbo].[tbl_MKT_IO_ProgrameTMP] ADD  DEFAULT ((0)) FOR [Budget]
GO
ALTER TABLE [dbo].[tbl_MKt_POdetail] ADD  CONSTRAINT [DF_tbl_MKt_POdetail_RecieptedQuantity]  DEFAULT ((0)) FOR [RecieptedQuantity]
GO
ALTER TABLE [dbo].[tbl_MKT_Stockcount] ADD  CONSTRAINT [DF_tbl_MKT_Stockcount_Aproved]  DEFAULT ((0)) FOR [Aproved]
GO
ALTER TABLE [dbo].[tbl_MKt_TransferINdetail] ADD  CONSTRAINT [DF_tbl_MKt_TransferINdetail_QuantityInConfirm]  DEFAULT ((0)) FOR [Reciepted_Quantity]
GO
ALTER TABLE [dbo].[tbl_MKt_TransferINdetail] ADD  CONSTRAINT [DF_tbl_MKt_TransferINdetail_IssueIDsub]  DEFAULT ((0)) FOR [IssueIDsub]
GO
ALTER TABLE [dbo].[tbl_MKt_Transferoutdetail] ADD  CONSTRAINT [DF_tbl_MKt_Transferoutdetail_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[tbl_MKt_Transferoutdetail] ADD  CONSTRAINT [DF_tbl_MKt_Transferoutdetail_AvaiableQuantity]  DEFAULT ((0)) FOR [AvaiableQuantity]
GO
ALTER TABLE [dbo].[tbl_MKt_Transferoutdetail] ADD  CONSTRAINT [DF_tbl_MKt_Transferoutdetail_QuantityInConfirm]  DEFAULT ((0)) FOR [Reciepted_Quantity]
GO
ALTER TABLE [dbo].[tbl_MKt_TransferoutdetailTMP] ADD  DEFAULT ((0)) FOR [AvaiableQuantity]
GO
ALTER TABLE [dbo].[tbl_MKt_TransferoutdetailTMP] ADD  DEFAULT ((0)) FOR [QuantityInConfirm]
GO
/****** Object:  StoredProcedure [dbo].[DailysaveEndstockMKT]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure  [dbo].[DailysaveEndstockMKT]

as
		
	
begin

insert into tbl_MKT_Stockenddailysave([SAP_CODE],[ITEM_Code],[MATERIAL],[Description],[UNIT],[END_STOCK],[Store_code],[TransferingOUT],[ON_Hold],[End_date])
select tbl_MKT_Stockend.[SAP_CODE],tbl_MKT_Stockend.[ITEM_Code],tbl_MKT_Stockend.[MATERIAL],tbl_MKT_Stockend.[Description],tbl_MKT_Stockend.[UNIT],tbl_MKT_Stockend.[END_STOCK],tbl_MKT_Stockend.[Store_code],tbl_MKT_Stockend.TransferingOUT,tbl_MKT_Stockend.ON_Hold, GETDATE() from tbl_MKT_Stockend

		
end






GO
/****** Object:  StoredProcedure [dbo].[UpdateBudgetuse]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure  [dbo].[UpdateBudgetuse]
( @location nvarchar(10)
)

as
		begin   --update edlp

	--	IF OBJECT_ID(N'tempdb..#TempResults', N'U') IS NOT NULL 
 --       DROP TABLE #TempResults;

	--	CREATE TABLE #TempResults
	--		(
	--		ITEM_Code nvarchar,
			
	--		balance  float
	--		)
 
 ---- tạo tổng
 --begin
 --      insert into #TempResults (ITEM_Code,balance)
	--	SELECT  tbl_MKT_StockendRegionBudget.ITEM_Code, sum(tbl_MKT_StockendRegionBudget.QuantityInputbyPO)+sum(tbl_MKT_StockendRegionBudget.QuantityOutput)+sum(tbl_MKT_StockendRegionBudget.QuantityInputbyReturn)+sum(tbl_MKT_StockendRegionBudget.QuantitybyDevice)
	--	FROM tbl_MKT_StockendRegionBudget 
	--	where tbl_MKT_StockendRegionBudget.Store_code =@location
	--	group by  tbl_MKT_StockendRegionBudget.ITEM_Code, tbl_MKT_StockendRegionBudget.Store_code
		
	--	ORDER BY tbl_MKT_StockendRegionBudget.ITEM_Code
	--end
	
	    begin -- update this by col value
					update tbl_MKT_Stockend 
					set  tbl_MKT_Stockend.RegionBudgeted = isnull((select sum(isnull(tbl_MKT_StockendRegionBudget.QuantitybyDevice,0)) +sum(isnull(tbl_MKT_StockendRegionBudget.QuantityInputbyPO,0)) + sum(isnull(tbl_MKT_StockendRegionBudget.QuantityInputbyReturn,0))-sum(isnull(tbl_MKT_StockendRegionBudget.QuantityOutput,0)) from tbl_MKT_StockendRegionBudget where  tbl_MKT_StockendRegionBudget.Store_code = @location and tbl_MKT_StockendRegionBudget.ITEM_Code = tbl_MKT_Stockend.ITEM_Code group by tbl_MKT_StockendRegionBudget.ITEM_Code ) ,0)
	    
					from tbl_MKT_Stockend
					where   tbl_MKT_Stockend.Store_code = @location
		end

	

			--IF OBJECT_ID(N'tempdb..#TempResults', N'U') IS NOT NULL 
   --     DROP TABLE #TempResults;
end




GO
/****** Object:  StoredProcedure [dbo].[UpdatePalletforCRTorderdetail]    Script Date: 23/09/2021 2:27:09 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure  [dbo].[UpdatePalletforCRTorderdetail]

as
		begin   --update edlp

	
	
	  
					update tbl_MKt_Listphieudetail 
					set  tbl_MKt_Listphieudetail.pallet = tbl_MKt_Listphieudetail.Issued/ tbl_MKT_Stockend.Quantity_Per_Pallet
					from tbl_MKT_Stockend,tbl_MKt_Listphieudetail
					where   tbl_MKT_Stockend.ITEM_Code = tbl_MKt_Listphieudetail.Materiacode
					and tbl_MKt_Listphieudetail.Status ='CRT'
		and tbl_MKT_Stockend.Quantity_Per_Pallet <> 0
		
end





GO
USE [master]
GO
ALTER DATABASE [MKTing] SET  READ_WRITE 
GO

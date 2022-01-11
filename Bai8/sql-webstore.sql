USE [master]
GO
--Tạo cơ sở dữ liệu
CREATE DATABASE [WineStore]
GO
USE [WineStore]
GO
--Tạo bảng
CREATE TABLE [dbo].[Catalogy](
[CatalogyID] [nchar](10) NOT NULL,
[CatalogyName] [nvarchar](50) NOT NULL,
[Description] [nvarchar](100) NULL,
CONSTRAINT [PK_Catalogies] PRIMARY KEY CLUSTERED
(
[CatalogyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Product](
[ProductID] [int] NOT NULL,
[ProductName] [nvarchar](50) NOT NULL,
[Description] [text] NULL,
[PurchasePrice] [numeric](8, 2) NOT NULL,
[Price] [numeric](8, 2) NOT NULL,
[Quantity] [int] NOT NULL,
[Vintage] [nchar](20) NULL,
[CatalogyID] [nchar](10) NOT NULL,
[Image] [text] NULL,
[Region] [nvarchar](100) NOT NULL,
CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED
(

[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
--Chèn dữ liệu cho các bảng
--Tạo các khóa ngoài
ALTER TABLE [dbo].[Product] WITH CHECK ADD CONSTRAINT [FK_Products_Catalogy] FOREIGN
KEY([CatalogyID])
REFERENCES [dbo].[Catalogy] ([CatalogyID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Products_Catalogy]
GO

Insert into Catalogy(CatalogyID,CatalogyName,Description) values('01',N'Rượu vang',N'Đây
là rượu vang' )
Insert into Catalogy(CatalogyID,CatalogyName,Description) values('02',N'Rượu VODKA',N'Đây
là rượu VODKA' )
--Chèn dữ liệu cho bảng Product
Insert into Product(ProductID,ProductName,Description,PurchasePrice,Price,Quantity,Vintage,CatalogyID,Image,Region)
values(1,N'RƯỢU VANG PETRUS',N'Rượu vang đỏ Chateau Petrus Pomerol, huyền thoại của của
thương hiệu vang hàng đầu thế giới. Vườn nho nhà Petrus tọa lạc trên một cao nguyên ở
phía đông Pomerol, tiểu vùng sản xuất rượu vang đỏ thượng hạng của xứ Bordeaux, Pháp. Đặc
điểm của đất nơi đây là đất sét xanh, chỉ thích với giống nho Merlot (chiếm 95%) và
Cabernet Franc.',600,800,200,1992,'01','h1.png',N'Pháp' )
Insert into Product(ProductID,ProductName,Description,PurchasePrice,Price,Quantity,Vintage,CatalogyID,Image,Region)
values(2,N'RƯỢU VODKA PUTINKA LIMITED',N'Rượu Vodka Putinka limited Edition Chai Vuông
(Vodka Putinka Limited Edition) thuộc Moscow Distillery Cristall, Nga. Rượu Putinka ra
đời năm 2003 nhằm tôn vinh Tổng thống Putin.',800,900,140,1990,'02','h2.png',N'Nga' )

Select *from Product
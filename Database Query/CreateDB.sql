create database ADB1_6_DATH1
go 

use ADB1_6_DATH1
go
create table KhachHang
(
	MaKH varchar(15) NOT NULL,
	Ho nvarchar(50),
	Ten nvarchar(50),
	Ngsinh date,
	SoNha int,
	Duong nvarchar(50),
	Phuong nvarchar(50),
	Quan nvarchar(50),
	Tpho nvarchar(50),
	DienThoai varchar(10),
	primary key (MaKH)
)

create table HoaDon
(
	MaHD varchar(15) NOT NULL,
	MaKH varchar(15) NOT NULL,
	NgayLap date NOT NULL,
	TongTien int,
	primary key (MaHD)
)

create table CT_HoaDon
(
	MaHD varchar(15) NOT NULL,
	MaSP varchar(15) NOT NULL,
	SoLuong int,
	GiaBan int,
	GiaGiam int,
	ThanhTien int,
	primary key (MaHD,MaSP)
)

create table SanPham
(
	MaSP varchar(15) NOT NULL,
	TenSP varchar(50),
	SoLuongTon int,
	Mota nvarchar(50),
	Gia int,
	primary key(MaSP)
)

go

alter table CT_HoaDon
	add	constraint FK_CTHD_HD
	foreign key (MaHD)
	references HoaDon(MaHD)

alter table CT_HoaDon
	add	constraint FK_CTHD_SP
	foreign key (MaSP)
	references SanPham(MaSP)

alter table HoaDon
	add	constraint FK_HD_KH
	foreign key (MaKH)
	references KhachHang(MaKH)

go

create function fn_tinhtong (@mahd varchar(15))
returns int
begin
	return (SELECT SUM(thanhtien) FROM dbo.CT_HoaDon WHERE mahd = @mahd)
END

GO

CREATE trigger tg_ThanhTien 
on dbo.CT_HoaDon for INSERT,DELETE,UPDATE
as
BEGIN
	update  dbo.CT_HoaDon set dbo.CT_HoaDon.GiaBan = dbo.SanPham.gia from inserted,dbo.SanPham
	where Inserted.MaSP = dbo.SanPham.MaSP and  dbo.CT_HoaDon.MaHD = inserted.MaHD   AND Inserted.MaSP = dbo.CT_HoaDon.MaSP

	declare @thanhtien int
	SELECT @thanhtien =  (dbo.CT_HoaDon.GiaBan - dbo.CT_HoaDon.GiaGiam)*dbo.CT_HoaDon.SoLuong 
	FROM  dbo.CT_HoaDon,Inserted 
	where Inserted.MaHD = dbo.CT_HoaDon.MaHD AND Inserted.MaSP = dbo.CT_HoaDon.MaSP
	update dbo.CT_HoaDon set ThanhTien = @thanhtien from inserted,dbo.CT_HoaDon where dbo.CT_HoaDon.MaHD = inserted.MaHD   AND Inserted.MaSP = dbo.CT_HoaDon.MaSP
	update dbo.HoaDon set TongTien = dbo.fn_tinhtong(Inserted.MaHD) FROM dbo.HoaDon,Inserted WHERE dbo.HoaDon.MaHD = Inserted.MaHD
END
go

CREATE trigger tg_TongTien 
on dbo.HoaDon for UPDATE
as
BEGIN
	update dbo.HoaDon set TongTien = dbo.fn_tinhtong(Inserted.MaHD) FROM dbo.HoaDon,Inserted WHERE dbo.HoaDon.MaHD = Inserted.MaHD
END
go



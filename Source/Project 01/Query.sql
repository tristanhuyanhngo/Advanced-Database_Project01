USE ADB1_6_DATH1
GO

 ----Cho danh sach cac hoa don lap trong nam 2020
SELECT * FROM dbo.HoaDon HD 
WHERE YEAR(HD.NgayLap) = 2020

----Cho danh sach cac khach hang o TPHCM
SELECT *
FROM dbo.KhachHang KH 
WHERE KH.Tpho = N'Hồ Chí Minh'

----Cho danh sach cac san pham co gia trong mot khoang tu...den...
SELECT * FROM SanPham SP 
WHERE SP.Gia BETWEEN 10000 AND 100000

----Cho danh sach cac san pham co so luong ton <100
SELECT * FROM SanPham SP 
WHERE SP.SoLuongTon < 100

----Cho danh sach cac san pham ban chay nhat (so luong ban nhieu nhat)
SELECT ct.MaSP,sp.TenSP,  SUM(ct.SoLuong) AS soluong
FROM dbo.CT_HoaDon ct JOIN dbo.SanPham sp ON sp.MaSP = ct.MaSP 
GROUP BY  ct.MaSP, sp.TenSP
ORDER BY SUM(ct.SoLuong) DESC 

----Cho danh sach cac san pham co doanh thu cao nhat
SELECT SP.*, DoanhThu = (CT.SoLuong*CT.GiaBan)
FROM SanPham AS SP, CT_HoaDon AS CT
WHERE SP.MaSP = CT.MaSP AND (CT.SoLuong*CT.GiaBan) = (
	SELECT MAX(ct.SoLuong*ct.GiaBan) FROM CT_HoaDon AS ct
)



--a. Select * from A join B join C on.... Và Select * from A,B,C where A.x = B.x....
SELECT * FROM dbo.HoaDon JOIN dbo.CT_HoaDon ON CT_HoaDon.MaHD = HoaDon.MaHD 
						 JOIN dbo.KhachHang ON KhachHang.MaKH = HoaDon.MaKH 

SELECT * FROM dbo.HoaDon,dbo.KhachHang, dbo.CT_HoaDon
WHERE dbo.HoaDon.MaHD = dbo.CT_HoaDon.MaHD
AND dbo.KhachHang.MaKH = dbo.HoaDon.MaKH



--b. Select * from A jọin B (A có số dòng nhỏ, B rất lớn) và Select * from B JOIN A
SELECT * FROM dbo.SanPham JOIN dbo.CT_HoaDon ON CT_HoaDon.MaSP = dbo.SanPham.MaSP

SELECT * FROM dbo.SanPham ,dbo.CT_HoaDon 
WHERE CT_HoaDon.MaSP = dbo.SanPham.MaSP
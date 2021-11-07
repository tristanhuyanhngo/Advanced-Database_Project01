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
SELECT CT.MaSP,SP.TenSP,  SUM(CT.SoLuong) AS SoLuong
FROM dbo.CT_HoaDon CT JOIN dbo.SanPham SP ON SP.MaSP = CT.MaSP 
GROUP BY  CT.MaSP, SP.TenSP
ORDER BY SUM(CT.SoLuong) DESC 

----Cho danh sach cac san pham co doanh thu cao nhat
SELECT SP.MaSP, SP.TenSP, SUM(CTHD.ThanhTien) AS DoanhThu
FROM SanPham SP JOIN CT_HoaDon CTHD ON SP.MaSP = CTHD.MaSP
GROUP BY SP.MaSP, SP.TenSP
ORDER BY SUM(CTHD.ThanhTien) DESC 

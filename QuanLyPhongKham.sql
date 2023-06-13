Drop Database QuanLyPhongKham
Go
CREATE DATABASE QuanLyPhongKham
GO

USE QuanLyPhongKham
GO

SET DATEFORMAT DMY

-- Tạo các bảng
CREATE TABLE BENHNHAN (
    MaBenhNhan INT IDENTITY (1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    GioiTinh NVARCHAR(4),
    NamSinh SMALLDATETIME,
    DiaChi NVARCHAR(100)
)

CREATE TABLE LOAIBENH (
    MaLoaiBenh INT IDENTITY (1,1) PRIMARY KEY,
    TenLoaiBenh NVARCHAR(100)
)

CREATE TABLE THUOC (
    MaThuoc INT IDENTITY (1,1) PRIMARY KEY,
    TenThuoc NVARCHAR(100),
)

CREATE TABLE DONVI (
    MaDonVi INT IDENTITY (1,1) PRIMARY KEY,
    TenDonVi NVARCHAR(100)
)

CREATE TABLE CACHDUNG (
    MaCachDung INT IDENTITY (1,1) PRIMARY KEY,
    TenCachDung NVARCHAR(100)
)

CREATE TABLE CHITIETTHUOC ( 
	MaCTThuoc INT IDENTITY (1,1) PRIMARY KEY,
    MaThuoc INT FOREIGN KEY REFERENCES THUOC(MaThuoc),
    MaDonVi INT FOREIGN KEY REFERENCES DONVI(MaDonVi),
    DonGia INT
)

CREATE TABLE PHIEUKHAM (
    MaPhieuKham INT IDENTITY (1,1) PRIMARY KEY,
    NgayKham SMALLDATETIME,
    TrieuChung NVARCHAR(100),
    MaLoaiBenh INT FOREIGN KEY REFERENCES LOAIBENH(MaLoaiBenh),
    MaBenhNhan INT FOREIGN KEY REFERENCES BENHNHAN(MaBenhNhan)
)

CREATE TABLE CHITIETPHIEUKHAM (
    MaChiTietPhieuKham INT IDENTITY (1,1) PRIMARY KEY,	
    MaPhieuKham INT FOREIGN KEY REFERENCES PHIEUKHAM(MaPhieuKham),
    MaCTThuoc INT FOREIGN KEY REFERENCES CHITIETTHUOC(MaCTThuoc),
    MaCachDung INT FOREIGN KEY REFERENCES CACHDUNG(MaCachDung),
    SoLuong INT
)

CREATE TABLE PHIEUNHAPTHUOC (
    MaPhieuNhapThuoc INT IDENTITY (1,1) PRIMARY KEY,
    NgayNhap SMALLDATETIME,
    NhaCungCap NVARCHAR(100),
    TongTien INT
)

CREATE TABLE CHITIETPHIEUNHAPTHUOC (
    MaChiTietPhieuNhapThuoc INT IDENTITY (1,1) PRIMARY KEY,
    MaPhieuNhapThuoc INT FOREIGN KEY REFERENCES PHIEUNHAPTHUOC(MaPhieuNhapThuoc),
    MaCTThuoc INT FOREIGN KEY REFERENCES CHITIETTHUOC(MaCTThuoc),
    SoLuong INT,
    ThanhTien INT
)

CREATE TABLE HOADON (
    MaHoaDon INT IDENTITY (1,1) PRIMARY KEY,
    MaPhieuKham INT FOREIGN KEY REFERENCES PHIEUKHAM(MaPhieuKham),
    NgayKham SMALLDATETIME,
    TienKham INT,
    TienThuoc INT
)

CREATE TABLE THAMSO (
	MaTs INT IDENTITY (1, 1) PRIMARY KEY,
    SoBenhNhanToiDaTrongNgay INT,
    SoLuongLoaiBenh INT,
    SoLuongLoaiThuoc INT,
    SoLuongDonVi INT,
    SoLuongCachDung INT,
    TienKham INT,
)

CREATE TABLE CTHOADON (
	MaCTHoaDon INT IDENTITY (1, 1) PRIMARY KEY,
	MaHoaDon INT FOREIGN KEY REFERENCES HOADON(MaHoaDon),
	TenThuoc NVARCHAR(100),
	TenDonVi NVARCHAR(100),
	SoLuong INT,
	TongTien INT,
)
GO

-- Tạo các ràng buộc
-- Ràng buộc số lượng bệnh nhân tối đa trong ngày
CREATE TRIGGER CHECK_SLBN ON PHIEUKHAM
FOR INSERT, UPDATE
AS
    DECLARE @NgayKham1 SMALLDATETIME, @NgayKham2 SMALLDATETIME, @SLBN INT, @MAXQ INT
    SELECT @NgayKham1 = NgayKham
    FROM INSERTED
	SELECT @NgayKham2 = NgayKham, @SLBN = COUNT(MaPhieuKham)
    FROM PHIEUKHAM
	GROUP BY NgayKham
    SELECT @MAXQ = SoBenhNhanToiDaTrongNgay
    FROM THAMSO
    IF (@NgayKham1 = @NgayKham2 AND @SLBN > @MAXQ)
        BEGIN
            PRINT 'Moi ngay chi kham toi da ' + CAST(@MAXQ AS NVARCHAR) + ' benh nhan'
            ROLLBACK TRAN
        END
GO

-- Ràng buộc số lượng loại bệnh
CREATE TRIGGER CHECK_SLLOAIBENH ON LOAIBENH
FOR INSERT, UPDATE
AS
    DECLARE @SLLB INT, @MAXQ INT
    SELECT *
    FROM INSERTED
    SELECT @SLLB = COUNT(MaLoaiBenh)
    FROM LOAIBENH
    SELECT @MAXQ = SoLuongLoaiBenh
    FROM THAMSO
    IF (@SLLB > @MAXQ)
        BEGIN
            PRINT 'Co toi da ' + CAST(@MAXQ AS NVARCHAR) + ' loai benh'
            ROLLBACK TRAN
        END
GO

-- Ràng buộc số lượng loại thuốc
CREATE TRIGGER CHECK_SLTHUOC ON THUOC
FOR INSERT, UPDATE
AS
    DECLARE @SLLB INT, @MAXQ INT
    SELECT *
    FROM INSERTED
    SELECT @SLLB = COUNT(MaThuoc)
    FROM THUOC
    SELECT @MAXQ = SoLuongLoaiThuoc
    FROM THAMSO
    IF (@SLLB > @MAXQ)
        BEGIN
            PRINT 'Co toi da ' + CAST(@MAXQ AS NVARCHAR) + ' loai thuoc'
            ROLLBACK TRAN
        END
GO

-- Ràng buộc số lượng đơn vị
CREATE TRIGGER CHECK_SLDONVI ON DONVI
FOR INSERT, UPDATE
AS
    DECLARE @SL INT, @MAXQ INT
    SELECT *
    FROM INSERTED
    SELECT @MAXQ = COUNT(MaDonVi)
    FROM DONVI
    SELECT @MAXQ = SoLuongDonVi
    FROM THAMSO
    IF (@SL > @MAXQ)
        BEGIN
            PRINT 'Co toi da ' + CAST(@MAXQ AS NVARCHAR) + ' loai don vi'
            ROLLBACK TRAN
        END
GO

-- Ràng buộc số lượng cách dùng
CREATE TRIGGER CHECK_SLCACHDUNG ON CACHDUNG
FOR INSERT, UPDATE
AS
    DECLARE @SLLB INT, @MAXQ INT
    SELECT *
    FROM INSERTED
    SELECT @SLLB = COUNT(MaCachDung)
    FROM CACHDUNG
    SELECT @MAXQ = SoLuongCachDung
    FROM THAMSO
    IF (@SLLB > @MAXQ)
        BEGIN
            PRINT 'Co toi da ' + CAST(@MAXQ AS NVARCHAR) + ' cach dung'
            ROLLBACK TRAN
        END
GO

-- Ràng buộc tiền khám
CREATE TRIGGER CHECK_TIENKHAM ON HOADON
FOR INSERT, UPDATE
AS
    DECLARE @TienKham INT, @CONSTQ INT
    SELECT @TienKham = TienKham
    FROM INSERTED
    SELECT @CONSTQ = TienKham
    FROM THAMSO
    IF (@TienKham != @CONSTQ)
        BEGIN
            PRINT 'Tien kham la ' + CAST(@CONSTQ AS NVARCHAR) + ' dong'
            ROLLBACK TRAN
        END
GO

-- Chèn dữ liệu vào các bảng
INSERT INTO THAMSO (SoBenhNhanToiDaTrongNgay, SoLuongLoaiBenh, SoLuongLoaiThuoc, SoLuongDonVi, SoLuongCachDung, TienKham)
VALUES
    ('40', '5', '30', '2', '4', '30000');


INSERT INTO LOAIBENH (TenLoaiBenh)
VALUES 
    (N'Cảm cúm'),
    (N'Gãy chân'),
    (N'Gãy tay'),
    (N'Lao'),
    (N'HIV');

INSERT INTO THUOC (TenThuoc)
VALUES
    ('Thuoc 01'),
    ('Thuoc 02'),
    ('Thuoc 03'),
    ('Thuoc 04'),
    ('Thuoc 05'),
    ('Thuoc 06'),
    ('Thuoc 07'),
    ('Thuoc 08'),
    ('Thuoc 09'),
    ('Thuoc 10'),
    ('Thuoc 11');

INSERT INTO DONVI (TenDonVi)
VALUES
    (N'Viên'),
    (N'Chai');

INSERT INTO CACHDUNG (TenCachDung)
VALUES
    (N'Uống'),
    (N'Nhai'),
    (N'Dán'),
    (N'Đắp');

INSERT INTO CHITIETTHUOC (MaThuoc, MaDonVi, DonGia)
VALUES
    ('1', '1', '1000'),
	('1', '2', '20000'),
    ('2', '2', '20000'),
	('2', '1', '2000'),
    ('3', '1', '3000'),
	('3', '2', '30000'),
    ('4', '2', '4000'),
    ('5', '1', '5000'),
    ('6', '2', '6000'),
    ('7', '1', '7000'),
    ('8', '2', '8000'),
    ('9', '1', '9000'),
    ('10', '2', '10000'),
    ('11', '1', '11000')
	;

SELECT * FROM BENHNHAN
SELECT * FROM LOAIBENH
SELECT * FROM THUOC
SELECT * FROM DONVI
SELECT * FROM CACHDUNG
SELECT * FROM CHITIETTHUOC
SELECT * FROM PHIEUKHAM
SELECT * FROM CHITIETPHIEUKHAM
SELECT * FROM PHIEUNHAPTHUOC
SELECT * FROM CHITIETPHIEUNHAPTHUOC
SELECT * FROM HOADON
SELECT * FROM THAMSO

-- Bảng báo cáo doanh thu 
SELECT DAY(PK.NgayKham) Ngay, MONTH(PK.NgayKham) Thang, YEAR(PK.NgayKham) Nam, 
COUNT(PK.MaBenhNhan) SLBN, SUM(TienKham + TienThuoc) DoanhThu
FROM PHIEUKHAM PK, HOADON HD
WHERE PK.MaPhieuKham = HD.MaPhieuKham
GROUP BY DAY(PK.NgayKham), MONTH(PK.NgayKham), YEAR(PK.NgayKham)
--
-- Bảng báo cáo sử dụng thuốc
SELECT DAY(PK.NgayKham) Ngay, MONTH(PK.NgayKham) Thang, YEAR(PK.NgayKham) Nam,
CTPK.MaCTThuoc, CTPNT.SoLuong, CTPK.SoLuong SoLanDung
FROM PHIEUKHAM PK, CHITIETPHIEUKHAM CTPK, CHITIETPHIEUNHAPTHUOC CTPNT
WHERE PK.MaPhieuKham = CTPK.MaPhieuKham
AND CTPK.MaCTThuoc = CTPNT.MaCTThuoc

SELECT * FROM PHIEUKHAM
WHERE MaPhieuKham = 6 AND MaPhieuKham IN (SELECT MaPhieuKham FROM HOADON);

SELECT PK.MaPhieuKham, T.TenThuoc, D.TenDonVi, CT.DonGia, CTPK.SoLuong, CT.DonGia * CTPK.SoLuong AS ThanhTien
FROM CHITIETPHIEUKHAM AS CTPK
JOIN CHITIETTHUOC AS CT ON CT.MaCTThuoc = CTPK.MaCTThuoc
JOIN THUOC AS T ON T.MaThuoc = CT.MaThuoc
JOIN DONVI AS D ON D.MaDonVi = CT.MaDonVi
JOIN PHIEUKHAM AS PK ON PK.MaPhieuKham = CTPK.MaPhieuKham
WHERE PK.MaPhieuKham = 1;
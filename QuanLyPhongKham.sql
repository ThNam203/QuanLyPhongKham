CREATE DATABASE QuanLyPhongKham
GO

USE QuanLyPhongKham
GO

SET DATEFORMAT DMY

-- Tạo các bảng
CREATE TABLE BENHNHAN (
    MaBenhNhan INT IDENTITY (1,1) PRIMARY KEY,
    HoTen VARCHAR(24),
    GioiTinh VARCHAR(4),
    NamSinh SMALLDATETIME,
    DiaChi VARCHAR(24)
)

CREATE TABLE LOAIBENH (
    MaLoaiBenh INT IDENTITY (1,1) PRIMARY KEY,
    TenLoaiBenh VARCHAR(24)
)

CREATE TABLE THUOC (
    MaThuoc INT IDENTITY (1,1) PRIMARY KEY,
    TenThuoc VARCHAR(24),
)

CREATE TABLE DONVI (
    MaDonVi INT IDENTITY (1,1) PRIMARY KEY,
    TenDonVi VARCHAR(24)
)

CREATE TABLE CACHDUNG (
    MaCachDung INT IDENTITY (1,1) PRIMARY KEY,
    TenCachDung VARCHAR(24)
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
    TrieuChung VARCHAR(24),
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
    NhaCungCap VARCHAR(24),
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
	TenThuoc VARCHAR(24),
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
    SELECT @NgayKham2 = NgayKham
	FROM PHIEUKHAM
	SELECT @SLBN = COUNT(MaBenhNhan)
    FROM PHIEUKHAM
    SELECT @MAXQ = SoBenhNhanToiDaTrongNgay
    FROM THAMSO
    IF (@NgayKham1 = @NgayKham2 AND @SLBN > @MAXQ)
        BEGIN
            PRINT 'Moi ngay chi kham toi da ' + CAST(@MAXQ AS VARCHAR) + ' benh nhan'
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
            PRINT 'Co toi da ' + CAST(@MAXQ AS VARCHAR) + ' loai benh'
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
            PRINT 'Co toi da ' + CAST(@MAXQ AS VARCHAR) + ' loai thuoc'
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
            PRINT 'Co toi da ' + CAST(@MAXQ AS VARCHAR) + ' loai don vi'
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
            PRINT 'Co toi da ' + CAST(@MAXQ AS VARCHAR) + ' cach dung'
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
            PRINT 'Tien kham la ' + CAST(@CONSTQ AS VARCHAR) + ' dong'
            ROLLBACK TRAN
        END
GO

-- Chèn dữ liệu vào các bảng
INSERT INTO THAMSO (SoBenhNhanToiDaTrongNgay, SoLuongLoaiBenh, SoLuongLoaiThuoc, SoLuongDonVi, SoLuongCachDung, TienKham)
VALUES
    ('40', '5', '30', '2', '4', '30000');

INSERT INTO BENHNHAN (HoTen, GioiTinh, NamSinh, DiaChi)
VALUES 
    ('Nguyen Van A', 'Nam', '1985', 'Ho Chi Minh'),
    ('Tran Thi B', 'Nu', '1990', 'Ha Noi'),
    ('Le Van C', 'Nam', '1988', 'Da Nang'),
    ('Pham Thi D', 'Nu', '1982', 'Can Tho'),
    ('Hoang Van E', 'Nam', '1995', 'Hai Phong');

INSERT INTO LOAIBENH (TenLoaiBenh)
VALUES 
    ('Loai benh 1'),
    ('Loai benh 2'),
    ('Loai benh 3'),
    ('Loai benh 4'),
    ('Loai benh 5');

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
    ('Thuoc 11'),
    ('Thuoc 12'),
    ('Thuoc 13'),
    ('Thuoc 14'),
    ('Thuoc 15'),
    ('Thuoc 16'),
    ('Thuoc 17'),
    ('Thuoc 18'),
    ('Thuoc 19'),
    ('Thuoc 20'),
    ('Thuoc 21'),
    ('Thuoc 22'),
    ('Thuoc 23'),
    ('Thuoc 24'),
    ('Thuoc 25'),
    ('Thuoc 26'),
    ('Thuoc 27'),
    ('Thuoc 28'),
    ('Thuoc 29'),
    ('Thuoc 30');

INSERT INTO DONVI (TenDonVi)
VALUES
    ('Vien'),
    ('Chai');

INSERT INTO CACHDUNG (TenCachDung)
VALUES
    ('Cach dung 1'),
    ('Cach dung 2'),
    ('Cach dung 3'),
    ('Cach dung 4');

INSERT INTO CHITIETTHUOC (MaThuoc, MaDonVi, DonGia)
VALUES
    ('1', '1', '1000'),
    ('2', '2', '2000'),
    ('3', '1', '3000'),
    ('4', '2', '4000'),
    ('5', '1', '5000'),
    ('6', '2', '6000'),
    ('7', '1', '7000'),
    ('8', '2', '8000'),
    ('9', '1', '9000'),
    ('10', '2', '10000'),
    ('11', '1', '11000'),
    ('12', '2', '12000'),
    ('13', '1', '13000'),
    ('14', '2', '14000'),
    ('15', '1', '15000'),
    ('16', '2', '16000'),
    ('17', '1', '17000'),
    ('18', '2', '18000'),
    ('19', '1', '19000'),
    ('20', '2', '20000'),
    ('21', '1', '21000'),
    ('22', '2', '22000'),
    ('23', '1', '23000'),
    ('24', '2', '24000'),
    ('25', '1', '25000'),
    ('26', '2', '26000'),
    ('27', '1', '27000'),
    ('28', '2', '28000'),
    ('29', '1', '29000'),
    ('30', '2', '30000');

INSERT INTO PHIEUKHAM (NgayKham, TrieuChung, MaLoaiBenh, MaBenhNhan)
VALUES 
    ('01/02/2023', 'Trieu chung 1', '1', '1'),
    ('01/02/2023', 'Trieu chung 2', '2', '2'),
    ('02/02/2023', 'Trieu chung 3', '3', '3'),
    ('01/03/2023', 'Trieu chung 4', '4', '4'),
    ('01/04/2023', 'Trieu chung 5', '5', '5');

INSERT INTO CHITIETPHIEUKHAM (MaPhieuKham, MaCTThuoc, MaCachDung, SoLuong)
VALUES
    ('1', '1', '1', '5'),
    ('2', '2', '2', '5'),
    ('3', '3', '3', '5'),
    ('4', '4', '4', '5'),
    ('5', '5', '1', '5');

INSERT INTO PHIEUNHAPTHUOC (NgayNhap, NhaCungCap, TongTien)
VALUES
    ('01/01/2023', 'NCC01', '1350000'),
    ('02/01/2023', 'NCC02', '4650000'),
    ('03/01/2023', 'NCC03', '7650000');

INSERT INTO CHITIETPHIEUNHAPTHUOC (MaPhieuNhapThuoc, MaCTThuoc, SoLuong, ThanhTien)
VALUES
    ('1', '1', '30', '30000'),
    ('1', '2', '30', '60000'),
    ('1', '3', '30', '90000'),
    ('1', '4', '30', '120000'),
    ('1', '5', '30', '150000'),
    ('1', '6', '30', '180000'),
    ('1', '7', '30', '210000'),
    ('1', '8', '30', '240000'),
    ('1', '9', '30', '270000'),
    ('1', '10', '30', '300000'),
    ('2', '11', '30', '330000'),
    ('2', '12', '30', '360000'),
    ('2', '13', '30', '390000'),
    ('2', '14', '30', '420000'),
    ('2', '15', '30', '450000'),
    ('2', '16', '30', '480000'),
    ('2', '17', '30', '510000'),
    ('2', '18', '30', '540000'),
    ('2', '19', '30', '570000'),
    ('2', '20', '30', '600000'),
    ('3', '21', '30', '630000'),
    ('3', '22', '30', '660000'),
    ('3', '23', '30', '690000'),
    ('3', '24', '30', '720000'),
    ('3', '25', '30', '750000'),
    ('3', '26', '30', '780000'),
    ('3', '27', '30', '810000'),
    ('3', '28', '30', '840000'),
    ('3', '29', '30', '870000'),
    ('3', '30', '30', '900000');

INSERT INTO HOADON (MaPhieuKham, NgayKham, TienKham, TienThuoc)
VALUES 
    ('1', '01/02/2023', '30000', '5000'),
    ('2', '01/02/2023', '30000', '10000'),
    ('3', '02/02/2023', '30000', '15000'),
    ('4', '01/03/2023', '30000', '20000'),
    ('5', '01/04/2023', '30000', '25000');
GO

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
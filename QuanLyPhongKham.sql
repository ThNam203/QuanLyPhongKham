CREATE DATABASE QuanLyPhongKham
GO

USE QuanLyPhongKham
GO

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

CREATE TABLE PHIEUKHAM (
    MaPhieuKham INT IDENTITY (1,1) PRIMARY KEY,
    NgayKham SMALLDATETIME,
    TrieuChung VARCHAR(24),
    MaLoaiBenh INT FOREIGN KEY REFERENCES LOAIBENH(MaLoaiBenh),
    MaBenhNhan INT FOREIGN KEY REFERENCES BENHNHAN(MaBenhNhan)
)

CREATE TABLE THUOC (
    MaThuoc INT IDENTITY (1,1) PRIMARY KEY,
    TenThuoc VARCHAR(24),
	DonGia INT,
)

CREATE TABLE DONVI (
    MaDonVi INT IDENTITY (1,1) PRIMARY KEY,
    TenDonVi VARCHAR(24)
)

CREATE TABLE CACHDUNG (
    MaCachDung INT IDENTITY (1,1) PRIMARY KEY,
    TenCachDung VARCHAR(24)
)

CREATE TABLE CHITIETPHIEUKHAM (
    MaChiTietPhieuKham INT IDENTITY (1,1) PRIMARY KEY,	
    MaPhieuKham INT FOREIGN KEY REFERENCES PHIEUKHAM(MaPhieuKham),
    MaThuoc INT FOREIGN KEY REFERENCES THUOC(MaThuoc),
    MaDonVi INT FOREIGN KEY REFERENCES DONVI(MaDonVi),
    MaCachDung INT FOREIGN KEY REFERENCES CACHDUNG(MaCachDung),
    SoLuong INT
)

CREATE TABLE PHIEUNHAPTHUOC (
    MaPhieuNhapThuoc INT IDENTITY (1,1) PRIMARY KEY,
    NgayNhap SMALLDATETIME,
    NhaCungCap VARCHAR(24),
    TongTien SMALLMONEY
)

CREATE TABLE CHITIETPHIEUNHAPTHUOC (
    MaChiTietPhieuNhapThuoc INT IDENTITY (1,1) PRIMARY KEY,
    MaThuoc INT FOREIGN KEY REFERENCES THUOC(MaThuoc),
    MaDonVi INT FOREIGN KEY REFERENCES DONVI(MaDonVi),
    MaPhieuNhapThuoc INT FOREIGN KEY REFERENCES PHIEUNHAPTHUOC(MaPhieuNhapThuoc),
    MaCachDung INT FOREIGN KEY REFERENCES CACHDUNG(MaCachDung),
    DonGia SMALLMONEY,
    SoLuong INT,
    ThanhTien SMALLMONEY,
    CONSTRAINT CHECK_ThanhTien CHECK (ThanhTien = SoLuong * DonGia)
)

CREATE TABLE HOADON (
    MaHoaDon INT IDENTITY (1,1) PRIMARY KEY,
    MaPhieuKham INT FOREIGN KEY REFERENCES PHIEUKHAM(MaPhieuKham),
    NgayKham SMALLDATETIME,
    TienKham SMALLMONEY,
    TienThuoc SMALLMONEY
)

CREATE TABLE THAMSO (
    SoBenhNhanToiDaTrongNgay INT,
    SoLuongLoaiBenh INT,
    SoLuongLoaiThuoc INT,
    SoLuongDonVi INT,
    SoLuongCachDung INT,
    TienKham SMALLMONEY,
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
    DECLARE @TienKham SMALLMONEY, @CONSTQ SMALLMONEY
    SELECT @TienKham = TienKham
    FROM INSERTED
    SELECT @CONSTQ = TienKham
    FROM THAMSO
    IF (@TienKham != @CONSTQ)
        BEGIN
            PRINT 'Tiền khám là ' + CAST(@CONSTQ AS VARCHAR) + ' đồng'
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
    ('Hoang Van E', 'Nam', '1995', 'Hai Phong'),
    ('Nguyen Thi F', 'Nu', '1998', 'Vung Tau'),
    ('Tran Van G', 'Nam', '1979', 'Hue'),
    ('Pham Thi H', 'Nu', '1984', 'Nha Trang'),
    ('Le Van I', 'Nam', '1992', 'Bien Hoa'),
    ('Hoang Thi K', 'Nu', '1996', 'Bac Ninh'),
    ('Nguyen Van X', 'Nam', '1993', 'Ha Giang'),
    ('Tran Thi Y', 'Nu', '1999', 'Quang Ninh'),
    ('Le Van Z', 'Nam', '1987', 'Lao Cai'),
    ('Pham Thi P', 'Nu', '1986', 'Lang Son'),
    ('Hoang Van Q', 'Nam', '1991', 'Cao Bang'),
    ('Nguyen Thi R', 'Nu', '1997', 'Bac Kan'),
    ('Tran Van S', 'Nam', '1983', 'Thai Nguyen'),
    ('Pham Thi T', 'Nu', '1989', 'Bac Giang'),
    ('Le Van U', 'Nam', '1994', 'Phu Tho'),
    ('Hoang Thi V', 'Nu', '1998', 'Tuyen Quang'),
    ('Nguyen Van W', 'Nam', '1981', 'Yen Bai'),
    ('Tran Thi X', 'Nu', '1980', 'Hai Duong'),
    ('Le Van Y', 'Nam', '1996', 'Hung Yen'),
    ('Pham Thi Z', 'Nu', '1992', 'Nam Dinh'),
    ('Hoang Van P', 'Nam', '1988', 'Thai Binh'),
    ('Nguyen Thi Q', 'Nu', '1984', 'Ha Nam'),
    ('Tran Van R', 'Nam', '1990', 'Ninh Binh'),
    ('Pham Thi S', 'Nu', '1995', 'Thanh Hoa'),
    ('Le Van T', 'Nam', '1982', 'Nghe An'),
    ('Hoang Thi U', 'Nu', '1987', 'Ha Tinh'),
    ('Nguyen Van V', 'Nam', '1993', 'Quang Binh'),
    ('Tran Thi W', 'Nu', '1999', 'Quang Tri'),
    ('Le Van X', 'Nam', '1989', 'Thua Thien Hue'),
    ('Pham Thi Y', 'Nu', '1986', 'Da Nang'),
    ('Hoang Van Z', 'Nam', '1991', 'Quang Nam'),
    ('Nguyen Thi P', 'Nu', '1997', 'Quang Ngai'),
    ('Tran Van Q', 'Nam', '1983', 'Binh Dinh'),
    ('Pham Thi R', 'Nu', '1988', 'Phu Yen'),
    ('Le Van S', 'Nam', '1994', 'Khanh Hoa'),
    ('Hoang Thi T', 'Nu', '1998', 'Ninh Thuan');

INSERT INTO LOAIBENH (TenLoaiBenh)
VALUES 
    ('Loai benh 1'),
    ('Loai benh 2'),
    ('Loai benh 3'),
    ('Loai benh 4'),
    ('Loai benh 5');

INSERT INTO PHIEUKHAM (NgayKham, TrieuChung, MaLoaiBenh, MaBenhNhan)
VALUES 
    ('01/02/2023', 'Trieu chung 1', 1, 1),
    ('01/02/2023', 'Trieu chung 2', 2, 2),
    ('01/02/2023', 'Trieu chung 3', 3, 3),
    ('01/02/2023', 'Trieu chung 4', 4, 4),
    ('01/02/2023', 'Trieu chung 5', 5, 5),
    ('01/02/2023', 'Trieu chung 1', 1, 6),
    ('01/02/2023', 'Trieu chung 2', 2, 7),
    ('01/02/2023', 'Trieu chung 3', 3, 8),
    ('01/02/2023', 'Trieu chung 4', 4, 9),
    ('01/02/2023', 'Trieu chung 5', 5, 10),
    ('01/03/2023', 'Trieu chung 1', 1, 11),
    ('01/03/2023', 'Trieu chung 2', 2, 12),
    ('01/03/2023', 'Trieu chung 3', 3, 13),
    ('01/03/2023', 'Trieu chung 4', 4, 14),
    ('01/03/2023', 'Trieu chung 5', 5, 15);

INSERT INTO THUOC (TenThuoc, DonGia)
VALUES
    ('Thuoc 01', 300000),
    ('Thuoc 02', 400000),
    ('Thuoc 03', 700000),
    ('Thuoc 04', 800000),
    ('Thuoc 05', 200000),
    ('Thuoc 06', 200000),
    ('Thuoc 07', 100000),
    ('Thuoc 08', 200000),
    ('Thuoc 09', 800000),
    ('Thuoc 10', 300000),
    ('Thuoc 11', 700000),
    ('Thuoc 12', 500000),
    ('Thuoc 13', 400000),
    ('Thuoc 14', 300000),
    ('Thuoc 15', 600000),
    ('Thuoc 16', 700000),
    ('Thuoc 17', 200000),
    ('Thuoc 18', 500000),
    ('Thuoc 19', 200000),
    ('Thuoc 20', 600000),
    ('Thuoc 21', 200000),
    ('Thuoc 22', 200000),
    ('Thuoc 23', 100000),
    ('Thuoc 24', 1000000),
    ('Thuoc 25', 40000),
    ('Thuoc 26', 200000),
    ('Thuoc 27', 2200000),
    ('Thuoc 28', 1100000),
    ('Thuoc 29', 13200000),
    ('Thuoc 30', 2100000);

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

INSERT INTO CHITIETPHIEUKHAM (MaPhieuKham, MaThuoc, MaDonVi, MaCachDung, SoLuong)
VALUES
    (1, 1, 1, 1, '5'),
    (1, 2, 2, 2, '3'),
    (2, 3, 1, 3, '2'),
    (2, 4, 2, 4, '1'),
    (3, 5, 1, 1, '4'),
    (3, 6, 2, 2, '2'),
    (4, 7, 1, 3, '3'),
    (4, 8, 2, 4, '1'),
    (5, 9, 1, 1, '6'),
    (5, 10, 2, 1, '2'),
    (6, 11, 1, 3, '2'),
    (6, 12, 2, 4, '3'),
    (7, 13,	1, 1, '4'),
    (7, 14, 2, 2, '1'),
    (8, 15, 1, 3, '2'),
    (8, 16, 2, 4, '3'),
    (9, 17, 1, 1, '5'),
    (9, 18, 2, 2, '2'),
    (10, 19, 1, 3, '3'),
    (10, 20, 2, 4, '1'),
    (10, 21, 1, 1, '5'),
    (11, 22, 2, 2, '3'),
    (12, 23, 1, 3, '2'),
    (12, 24, 2, 4, '1'),
    (12, 25, 1, 1, '4'),
    (13, 26, 2, 2, '2'),
    (14, 27, 1, 3, '3'),
    (14, 28, 2, 4, '1'),
    (15, 29, 2, 1, '6'),
    (15, 30, 2, 2, '2');


INSERT INTO PHIEUNHAPTHUOC (NgayNhap, NhaCungCap, TongTien)
VALUES
    ('01/01/2023', 1, '90'),
    ('01/01/2023', 2, '210'),
    ('01/01/2023', 3, '300'),
    ('01/01/2023', 4, '210'),
    ('01/01/2023', 5, '90'),
    ('01/01/2023', 1, '90'),
    ('01/01/2023', 2, '210'),
    ('01/01/2023', 3, '300'),
    ('01/01/2023', 4, '210'),
    ('01/01/2023', 5, '90'),
    ('01/01/2023', 1, '90'),
    ('01/01/2023', 2, '210'),
    ('01/01/2023', 3, '300'),
    ('01/01/2023', 4, '210'),
    ('01/01/2023', 5, '90');

INSERT INTO CHITIETPHIEUNHAPTHUOC (MaThuoc, MaDonVi, MaPhieuNhapThuoc, MaCachDung, DonGia, SoLuong, ThanhTien)
VALUES
    ('MTH01', 1, 1, 1, '1', '30', '30'),
    ('MTH02', 2, 1, 2, '2', '30', '60'),
    ('MTH03', 1, 2, 3, '3', '30', '90'),
    ('MTH04', 2, 2, 4, '4', '30', '120'),
    ('MTH05', 1, 3, 1, '5', '30', '150'),
    ('MTH06', 2, 3, 2, '5', '30', '150'),
    ('MTH07', 1, 4, 3, '4', '30', '120'),
    ('MTH08', 2, 4, 4, '3', '30', '90'),
    ('MTH09', 1, 5, 1, '2', '30', '60'),
    ('MTH10', 2, 5, 2, '1', '30', '30'),
    ('MTH11', 1, 6, 1, '1', '30', '30'),
    ('MTH12', 2, 6, 2, '2', '30', '60'),
    ('MTH13', 1, 7, 3, '3', '30', '90'),
    ('MTH14', 2, 7, 4, '4', '30', '120'),
    ('MTH15', 1, 8, 1, '5', '30', '150'),
    ('MTH16', 2, 8, 2, '5', '30', '150'),
    ('MTH17', 1, 9, 3, '4', '30', '120'),
    ('MTH18', 2, 9, 4, '3', '30', '90'),
    ('MTH19', 1, 10, 1, '2', '30', '60'),
    ('MTH20', 2, 10, 2, '1', '30', '30'),
    ('MTH21', 1, 11, 3, '1', '30', '30'),
    ('MTH22', 2, 11, 4, '2', '30', '60'),
    ('MTH23', 1, 12, 1, '3', '30', '90'),
    ('MTH24', 2, 12, 2, '4', '30', '120'),
    ('MTH25', 1, 13, 3, '5', '30', '150'),
    ('MTH26', 2, 13, 4, '5', '30', '150'),
    ('MTH27', 1, 14, 1, '4', '30', '120'),
    ('MTH28', 2, 14, 2, '3', '30', '90'),
    ('MTH29', 1, 15, 3, '2', '30', '60'),
    ('MTH30', 2, 15, 4, '1', '30', '30');

	SELECT * FROM HOADON
INSERT INTO HOADON (MaPhieuKham, NgayKham, TienKham, TienThuoc)
VALUES 
    (1, '01/02/2023', '30000', '5'),
    (2, '01/02/2023', '30000', '25'),
    (3, '01/02/2023', '30000', '50'),
    (4, '01/02/2023', '30000', '25'),
    (5, '01/02/2023', '30000', '5'),
    (6, '01/02/2023', '30000', '5'),
    (7, '01/02/2023', '30000', '25'),
    (8, '01/02/2023', '30000', '50'),
    (9, '01/02/2023', '30000', '25'),
    (10, '01/02/2023', '30000', '5'),
    (11, '01/03/2023', '30000', '5'),
    (12, '01/03/2023', '30000', '25'),
    (13, '01/03/2023', '30000', '50'),
    (14, '01/03/2023', '30000', '25'),
    (15, '01/03/2023', '30000', '5');


-- Bảng báo cáo doanh thu 
SELECT DAY(PK.NgayKham) Ngay, MONTH(PK.NgayKham) Thang, YEAR(PK.NgayKham) Nam, 
COUNT(PK.MaBenhNhan) SLBN, SUM(TienKham + TienThuoc) DoanhThu
FROM PHIEUKHAM PK, HOADON HD
WHERE PK.MaPhieuKham = HD.MaPhieuKham
GROUP BY DAY(PK.NgayKham), MONTH(PK.NgayKham), YEAR(PK.NgayKham)

-- Bảng báo cáo sử dụng thuốc
SELECT DAY(PK.NgayKham) Ngay, MONTH(PK.NgayKham) Thang, YEAR(PK.NgayKham) Nam,
CTPK.MaThuoc, CTPNT.SoLuong, CTPK.SoLuong SoLanDung
FROM PHIEUKHAM PK, CHITIETPHIEUKHAM CTPK, CHITIETPHIEUNHAPTHUOC CTPNT
WHERE PK.MaPhieuKham = CTPK.MaPhieuKham
AND CTPK.MaThuoc = CTPNT.MaThuoc

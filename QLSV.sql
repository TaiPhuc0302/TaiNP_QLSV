CREATE DATABASE QuanLySinhVienDB;
GO
USE QuanLySinhVienDB;
GO

-- Bảng Tài Khoản (Đăng nhập)
CREATE TABLE TaiKhoan (
	ID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
	Email VARCHAR(50) UNIQUE NOT NULL,
    [Password] VARCHAR(50) NOT NULL
);
GO

-- Bảng Lớp Học
CREATE TABLE LopHoc (
    MaLop VARCHAR(20) PRIMARY KEY,
    TenLop NVARCHAR(100) NOT NULL,
    SiSo INT DEFAULT 0
);
GO

-- Bảng Sinh Viên
CREATE TABLE SinhVien (
    MaSV VARCHAR(20) PRIMARY KEY,
    TenSV NVARCHAR(100) NOT NULL,
	GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    Lop VARCHAR(20),
    FOREIGN KEY (Lop) REFERENCES LopHoc(MaLop)
);
GO

-- Dữ liệu
INSERT INTO TaiKhoan (Username, Email, Password) 
VALUES 
('TaiNP', 'tai@gmail.com', '0024268'),
('admin1', 'admin1@gmail.com', '123456');
GO

INSERT INTO LopHoc (MaLop, TenLop, SiSo)
VALUES 
('CNTT01', '68PM1', 30),
('CNTT02', '68PM1', 20),
('MMT01', '69MH1', 20),
('MMT02', '69MH2', 30),
('CNTT03', '67PM3', 10);
GO

INSERT INTO SinhVien (MaSV, TenSV, GioiTinh, NgaySinh, Lop)
VALUES 
('123456', N'Nguyễn Văn Tuấn', N'Nam', '2003-05-15', 'CNTT01'),
('246810', N'Trần Thị Mai', N'Nữ', '2003-08-22', 'CNTT01'),
('493723', N'Lê Hoàng Nam', N'Nam', '2004-01-10', 'CNTT01'),
('284019', N'Phạm Văn Dũng', N'Nam', '2003-11-05', 'CNTT02'),
('498571', N'Hoàng Thị Yến', N'Nữ', '2004-02-28', 'CNTT02'),
('091283', N'Đỗ Minh Trí', N'Nam', '2003-07-19', 'MMT01'),
('123098', N'Vũ Bích Ngọc', N'Nữ', '2003-12-01', 'MMT01'),
('983742', N'Nguyễn Đức Huy', N'Nam', '2004-04-14', 'MMT02'),
('232841', N'Trần Mai Linh', N'Nữ', '2003-09-09', 'MMt02'),
('502308', N'Lê Tuấn Khang', N'Nam', '2004-06-30', 'CNTT03');
GO
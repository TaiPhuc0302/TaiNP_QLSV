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
    NgaySinh DATE,
    MaLop VARCHAR(20),
    FOREIGN KEY (MaLop) REFERENCES LopHoc(MaLop)
);
GO

-- Dữ liệu
INSERT INTO TaiKhoan (Username, Email, Password) 
VALUES 
('DatTT', 'dat@gmail.com', '4000568'),
('admin1', 'admin1@gmail.com', '246810');
GO

INSERT INTO LopHoc (MaLop, TenLop, SiSo)
VALUES 
('CNTT01', '68PM3', 30),
('CNTT02', '68PM4', 20),
('MMT01', '69MH1', 20),
('MMT02', '69MH3', 30),
('CNTT03', '67PM2', 10);
GO

INSERT INTO SinhVien (MaSV, TenSV, NgaySinh, MaLop)
VALUES 
('123456', N'Nguyễn Văn Tuấn', '2003-05-15', 'CNTT01'),
('246810', N'Trần Thị Mai', '2003-08-22', 'CNTT01'),
('493723', N'Lê Hoàng Nam', '2004-01-10', 'CNTT01'),
('284019', N'Phạm Văn Dũng', '2003-11-05', 'CNTT02'),
('498571', N'Hoàng Thị Yến', '2004-02-28', 'CNTT02'),
('091283', N'Đỗ Minh Trí', '2003-07-19', 'MMT01'),
('123098', N'Vũ Bích Ngọc', '2003-12-01', 'MMT01'),
('983742', N'Nguyễn Đức Huy', '2004-04-14', 'MMT02'),
('232841', N'Trần Mai Linh', '2003-09-09', 'MMt02'),
('502308', N'Lê Tuấn Khang', '2004-06-30', 'CNTT03');
GO
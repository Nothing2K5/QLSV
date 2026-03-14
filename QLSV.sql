CREATE DATABASE QLSV;
GO
USE QLSV;
GO

-- Bảng Người dùng 
CREATE TABLE Users (
    Username VARCHAR(50) PRIMARY KEY,
    Password VARCHAR(50) NOT NULL
);

-- Bảng Lớp học
CREATE TABLE LopHoc (
    MaLop INT PRIMARY KEY IDENTITY(1,1),
    TenLop NVARCHAR(100) NOT NULL,
	Khoa NVARCHAR(100) NOT NULL
);

-- Bảng Sinh viên
CREATE TABLE SinhVien (
    MaSV INT PRIMARY KEY IDENTITY(1,1),
    TenSV NVARCHAR(100) NOT NULL,
	NgaySinh DATE,
	GioiTinh NVARCHAR(10),
	MaLop INT,
    FOREIGN KEY (MaLop) REFERENCES LopHoc(MaLop)
);

-- Thêm tài khoản admin mặc định
INSERT INTO Users (Username, Password) VALUES ('hanh', '0009468');
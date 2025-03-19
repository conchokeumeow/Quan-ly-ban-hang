﻿CREATE DATABASE Nhom48K21106;
USE Nhom48K21106
-- Tạo bảng taiKhoan
CREATE TABLE taiKhoan (
	tenDangNhap nvarchar(50) primary key,
    matKhau nVARCHAR(50)not null
);

-- Tạo bảng nguoiDung
CREATE TABLE nguoiDung (
    SDT CHAR(10) NOT NULL PRIMARY KEY,
    tenDangNhap VARCHAR(50) NOT NULL,
    hoTen VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    diaChi VARCHAR(100) NOT NULL,
    FOREIGN KEY (tenDangNhap) REFERENCES taiKhoan(tenDangNhap)
);

-- Tạo bảng khachHang
CREATE TABLE khachHang (
    maKH INT NOT NULL PRIMARY KEY IDENTITY(1,1),    
    hoTen VARCHAR(50) NOT NULL,
    SDT CHAR(10) NOT NULL
);

-- Tạo bảng nhaCungCap
CREATE TABLE nhaCungCap (
    maNCC INT NOT NULL PRIMARY KEY IDENTITY(1,1),    
    tenNCC VARCHAR(50) NOT NULL,
    SDT CHAR(10) unique
);

-- Tạo bảng sanPham
CREATE TABLE sanPham (
    maSP INT NOT NULL PRIMARY KEY IDENTITY(1,1),    
    tenSP VARCHAR(50) NOT NULL,
    soLuongSP INT NOT NULL,                           
    hinhAnhSP IMAGE,  
	giaBan NUMERIC(15,0) NOT NULL,
	giaNhap NUMERIC(15,0) NOT NULL,
    HSD DATE NOT NULL                                  
);

-- Tạo bảng donHangBan
CREATE TABLE donHangBan (
    maDHB INT NOT NULL PRIMARY KEY IDENTITY(1,1),    
    maKH INT NOT NULL,
    ngayTao DATE NOT NULL,
    tongTien NUMERIC(15,0) NOT NULL,
    FOREIGN KEY (maKH) REFERENCES khachHang(maKH)
);

-- Tạo bảng donHangBanCT
CREATE TABLE donHangBanCT (
    maDHBCT INT NOT NULL PRIMARY KEY IDENTITY(1,1),   
    maDHB INT NOT NULL,
    maSP INT NOT NULL,
	giaBan NUMERIC(15,0) NOT NULL,
    soLuong INT NOT NULL,
    thanhTien NUMERIC(15,0) NOT NULL,
    FOREIGN KEY (maDHB) REFERENCES donHangBan(maDHB),
    FOREIGN KEY (maSP) REFERENCES sanPham(maSP)
);

-- Tạo bảng donHangNhap
CREATE TABLE donHangNhap (
    maDHN INT NOT NULL PRIMARY KEY IDENTITY(1,1),      
    SDT CHAR(10) NOT NULL,                                  
    ngayTao DATE NOT NULL,                              
    tongTien NUMERIC(15,0) NOT NULL,                              
    FOREIGN KEY (SDT) REFERENCES nhaCungCap(SDT) 
);

-- Tạo bảng donHangNhapCT
CREATE TABLE donHangNhapCT (
    maDHNCT INT NOT NULL PRIMARY KEY IDENTITY(1,1),    
    maDHN INT NOT NULL,                                  
    tenSP VARCHAR(50) NOT NULL,  
	giaNhap NUMERIC(15,0) NOT NULL,
    soLuong INT NOT NULL,                                
    thanhTien NUMERIC(15,0) NOT NULL,                            
    FOREIGN KEY (maDHN) REFERENCES donHangNhap(maDHN),  
    FOREIGN KEY (tenSP) REFERENCES sanPham(tenSP)        
);

-- Tạo bảng noPhaiTraKH
CREATE TABLE noPhaiTraKH (
    maNPTKH INT NOT NULL PRIMARY KEY IDENTITY(1,1),      
    maDHB INT NOT NULL,
    tienNo NUMERIC(15,0) NOT NULL,
    ngayNoTien DATE NOT NULL,
    trangThaiTraTien BIT NOT NULL,
    ngayTraTien DATE,
    FOREIGN KEY (maDHB) REFERENCES donHangBan(maDHB)
);

-- Tạo bảng noPhaiTraNCC
CREATE TABLE noPhaiTraNCC (
    maNPTNCC INT NOT NULL PRIMARY KEY IDENTITY(1,1),     
    maDHN INT NOT NULL,
    tienNo NUMERIC(15,0) NOT NULL,
    ngayNoTien DATE NOT NULL,
    trangThaiTraTien BIT NOT NULL,
    ngayTraTien DATE,
    FOREIGN KEY (maDHN) REFERENCES donHangNhap(maDHN)
);

drop table donHangNhap
drop table nhaCungCap
drop table donHangNhapCT

select * from donHangBan

ALTER TABLE donHangNhapCT
ADD CONSTRAINT FK_donHangNhapCT_maSP
FOREIGN KEY (maSP)
REFERENCES sanPham(maSP)
ON DELETE CASCADE;

ALTER TABLE sanPham
ADD CONSTRAINT UQ_tenSP UNIQUE (tenSP);

ALTER TABLE donHangBan DROP CONSTRAINT FK__donHangBan__SDT__29221CFB;

ALTER TABLE donHangNhapCT
ADD CONSTRAINT FK_donHangNhapCT_sanPham
FOREIGN KEY (maSP) REFERENCES sanPham(maSP)
ON UPDATE CASCADE
ON DELETE CASCADE; 
-- Bạn có thể thay đổi hành vi xóa nếu cần

ALTER TABLE donHangNhap
ADD CONSTRAINT FK_donHangNhap_NCC
FOREIGN KEY (SDT) REFERENCES nhaCungCap(SDT)
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE donHangNhapCT
ADD CONSTRAINT FK_donHangNhap_DHNCT
FOREIGN KEY (maDHN) REFERENCES donHangNhap(maDHN)
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE noPhaiTraNCC
ADD CONSTRAINT FK_donHangNhap_NoNCC
FOREIGN KEY (maDHN) REFERENCES donHangNhap(maDHN)
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE noPhaiTraKH
ADD CONSTRAINT FK_donHangBan_NoKH
FOREIGN KEY (maDHB) REFERENCES donHangBan(maDHB)
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE khachHang
ADD CONSTRAINT UQ_khachHang_SDT UNIQUE (SDT);

ALTER TABLE khachHang
drop CONSTRAINT UQ_khachHang_SDT


ALTER TABLE donHangBan
ADD CONSTRAINT FK_donHangBan_KH
FOREIGN KEY (SDT) REFERENCES khachHang(SDT)
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE donHangBanCT
ADD CONSTRAINT FK_donHangBanCT_KH
FOREIGN KEY (maSP) REFERENCES sanPham(maSP)
ON UPDATE CASCADE
ON DELETE CASCADE;



CREATE DATABASE QuanLyQuanTraSua
GO

USE QuanLyQuanTraSua
GO

CREATE TABLE NhanVien
(
  MaNhanVien VARCHAR(4),
  TenNhanVien NVARCHAR(40),
  TenTaiKhoan VARCHAR(10),
  LuongTrenGio INT,
  NgayVaoLam DateTime,
  GioiTinh NVARCHAR,
  NgaySinh NVARCHAR,
  SoDienThoai NVARCHAR,
  DiaChi NVARCHAR,
  LoaiNhanVien INT,
  CONSTRAINT PK_NhanVien_MaNhanVien PRIMARY KEY (MaNhanVien)
)
GO
CREATE TABLE TaiKhoan
(
  TenTaiKhoan NVARCHAR,
  MatKhau NVARCHAR,
  LoaiTaiKhoan NVARCHAR,
  CONSTRAINT PK_TaiKhoan_TenTaiKhoan PRIMARY KEY (TenTaiKhoan)
)
GO
CREATE TABLE LichLam
(
    MaLich NVARCHAR,
    NgayBatDau DateTime,
    NgayKetThUC DateTime,
    CONSTRAINT PK_LichLam_MaLich PRIMARY KEY (MaLich)
)
GO
CREATE TABLE VatLieu
(
    MaVatLieu NVARCHAR,
    TenVatLieu NVARCHAR,
    NhaCungCap NVARCHAR,
    SoLuong INT,
    Gia FLOAT,
    DonViTinh NVARCHAR,
    CONSTRAINT PK_VatLieu_MaVatLieu PRIMARY KEY (MaVatLieu)
)
GO
CREATE TABLE SanPham
(
    MaSanPham NVARCHAR,
    TenSanPham NVARCHAR,
    CongThuc NVARCHAR,
    ThanhPhan NVARCHAR,
    DanhGia INT,
    Gia FLOAT,
    CONSTRAINT PK_SanPham_MaSanPham PRIMARY KEY (MaSanPham)
)
GO
CREATE TABLE Menu
(
    PhienBan NVARCHAR,
    NgayCapNhat DateTime,
    CONSTRAINT PK_Menu_PhienBan PRIMARY KEY (PhienBan)
)
GO
CREATE TABLE KhoHang
(
    MaKho NVARCHAR,
    TenKho NVARCHAR,
    DiaChi NVARCHAR,
    DienTich FLOAT,
    CONSTRAINT PK_KhoHang_MaKho PRIMARY KEY (MaKho) 
)
GO
CREATE TABLE BaoCao
(
    MaBaoCao NVARCHAR,
    DoanhThu FLOAT,
    GiaVonHangBan FLOAT,
    LoiNhuanGop FLOAT,
    ThuNhap FLOAT,
    LoiNhuan FLOAT,
    CONSTRAINT PK_BaoCao_MaBaoCao PRIMARY KEY (MaBaoCao)
)

GO
insert into NhanVien values
('1235','Tung', 'Tungchinchin', '123456789','15000đ/h','16/02/2018','nam','25/4/2000', '0816148776','362 Truong Cong Dinh',   'phuc vu'),
('1354','Ngan', 'NganChinChin', '123456789','18000đ/h','26/03/2018','nu', '25/5/1999', '0542136161','46 Hoang Hoa Tham',      'thu ngan'),
('1563','Thu',  'Thuchinchin',  '123456789','15000đ/h','20/01/2018','nu', '12/06/2000','0654782153','491 Ton Sach',           'phuc vu'),
('4192','Trung','Trungchinchin','123456789','20000đ/h','27/06/2018','nam','16/08/1996','0541278961','45/12 Nguyen Binh Khiem','quan ly'),
('5214','thinh','Tinhchinchin', '123456789','15000đ/h','14/09/2018','nam','11/04/2001','0475963214','78 Trung Truc',          'phuc vu')

GO
insert into TaiKhoan values
('Tungchinchin',  '123456789'),
('NganChinChin',  '123456789'),
('Thuchinchin',   '123456789'),
('Trungchinchin', '123456789'),
('Tinhchinchin',  '123456789')

GO
insert into LichLam
values ('1877a0f84b35a698c87fb47db0920100','29','29'),
('0939adf3fb6225e811802184fe26c79a','28','28'),
('ed521923fbb40621dc250517cc0c9e0e','27','27'),
('6498667c85740f33bb0806fe96b1d72f','26','26'),
('693b363e987a38515fb07a063706dab9','25','25')

GO
insert into VatLieu
values ('T254','Sua bo','Long Thanh','1000','800000','VND'),
('S241','Tran Trau','Chin Chin','100000','7500000','VND'),
('C2561','Cafe','Trung Nguyen','50000','1200000','VND'),
('F524','Duong Phen','Long An','200','410000','VND'),
('V0254','Tra','tea plus', '100000','15000000','VND')
﻿USE QuanLyQuanTraSua
GO

--Test Insert 1 Record
INSERT into NhanVien (
MaNhanVien, 
TenNhanVien, 
TenTaiKhoan, 
LuongTrenGio, 
NgayVaoLam, 
GioiTinh,
NgaySinh,
SoDienThoai,
DiaChi,
LoaiNhanVien
)
values
('1235','Tung', '1234567890','15000','20180216','nam','25/4/2000', '0816148776',
'362 Truong Cong Dinh',   
'1'
)

-- Insert Lượng Lớn
insert into NhanVien (
MaNhanVien, 
TenNhanVien, 
TenTaiKhoan, 
LuongTrenGio, 
NgayVaoLam, 
GioiTinh,
NgaySinh,
SoDienThoai,
DiaChi,
LoaiNhanVien
)
values
('1235','Tung', '123456789','15000','20180216','nam','20000425', '0816148776',
'362 Truong Cong Dinh',   
'phuc vu'
),
('1354','Ngan', '123456789','18000','26/03/2018','nu', '25/5/1999', '0542136161',
'46 Hoang Hoa Tham',      
'thu ngan'
),
('1563','Thu',  '123456789','15000','20/01/2018','nu', '12/06/2000','0654782153',
'491 Ton Sach',           
'phuc vu'
),
('4192','Trung','123456789','20000','27/06/2018','nam','16/08/1996','0541278961',
'45/12 Nguyen Binh Khiem',
'quan ly'
),
('5214','thinh','123456789','15000','14/09/2018','nam','11/04/2001','0475963214',
'78 Trung Truc',          
'phuc vu'
)

GO
insert into TaiKhoan (
TenTaiKhoan,
MatKhau,
LoaiTaiKhoan
)
values
('chuquan','cq'),
('quanly1','ql'),
('thungan','tn'),
('phache', 'pc'),
('quanly2','ql')

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
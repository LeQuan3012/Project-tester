create database QuanLyDiemTHPT
use QuanLyDiemTHPT

create table TaiKhoan
(
	TenDangNhap varchar(20) primary key,
	MatKhau varchar(20),
	VaiTro nvarchar(30),
	TinhTrang nvarchar(50)
)

create table GiaoVien
(
	TenDangNhap varchar(20) foreign key references TaiKhoan(TenDangNhap),
	TenGiaoVien nvarchar(100),
	NamSinh date,
	GioiTinh nvarchar(10),
	NgayVaoLam date,
	SDT varchar(10),
	DiaChi nvarchar(100),
	TinhTrang nvarchar(50),
	ChuyenMon nvarchar(100)
)

create table KhoaHoc
(
	MaKhoaHoc varchar(20) primary key,
	TenKhoa nvarchar(20),
	TinhTrang nvarchar(50)
) 


create table Lop
(
	MaLop varchar(20) primary key,
	TenLop nvarchar(20),
	NamHoc varchar(20),
	TenDangNhap varchar(20) foreign key references TaiKhoan(TenDangNhap),
	MaKhoaHoc varchar(20) foreign key references KhoaHoc(MaKhoaHoc)
)

create table SinhVien
(
	TenDangNhap varchar(20) foreign key references TaiKhoan(TenDangNhap),
	TenSinhVien nvarchar(100),
	NamSinh date,
	GioiTinh nvarchar(10),
	NgayNhapHoc date,
	MaKhoaHoc varchar(20) foreign key references KhoaHoc(MaKhoaHoc),
	TinhTrang nvarchar(50),
	MaLop varchar(20) foreign key references Lop(MaLop)
)

create table MonHoc
(
	MaMonHoc varchar(20) primary key,
	TenMonHoc nvarchar(50),
	TinhTrang nvarchar(50)
)

create table GV_MH
(
	TenDangNhap varchar(20) foreign key references TaiKhoan(TenDangNhap),
	MaMonHoc varchar(20) foreign key references MonHoc(MaMonHoc),
	HocKy varchar(20),
	NamHoc nvarchar(50),
	MaLop varchar(20) foreign key references Lop(MaLop)
)

insert into GV_MH values ('TenDN','MaMH','HK','NamHoc','MaLop')
update GV_MH set TenDangNhap = '', MaMonHoc = '', HocKy = '', NamHoc='', MaLop = '' where TenDangNhap = '' and MaMonHoc='' and HocKy='' and NamHoc='' and MaLop=''
create table SV_MH
(
	TenDangNhapSV varchar(20) foreign key references TaiKhoan(TenDangNhap),
	TenDangNhapGV varchar(20) foreign key references TaiKhoan(TenDangNhap),
	MaMonHoc varchar(20) foreign key references MonHoc(MaMonHoc),
	HocKy varchar(50),
	NamHoc varchar(50),
	DiemMieng float,
	DiemGK float,
	DiemCK float,
	NgayThi date
)

select * 
from SV_MH


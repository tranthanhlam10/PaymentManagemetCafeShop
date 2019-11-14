create database PaymentCoffeeShop

use  PaymentCoffeeShop

Create table KhachHang
(
	SoKH int identity(1,1) not null,
	MaKH as 'VN' + Right('000000' + CAST(SoKH as varchar(6)),6) persisted primary key,
	SDT varchar(15) not null,
	HoTen varchar(50) not null,
	GioiTinh bit,
	email varchar(50),
	ngaysinh date,
)

Create table HoaDon
(
	SoHd int identity(1,1) not null primary key,
	MaKH varchar(8) default NULL,
	NgHD date,
	ThoigianHD time,
	TriGia money,
	constraint FK_HoaDon_KhachHang foreign key (MaKH) references KhachHang (MaKH)
)

create table SanPham
(
	MaSP int identity(1,1) not null primary key,
	Ten varchar(30) not null,
)

create table CTSP
(
	MaSP int not null,
	Size varchar(1) not null,
	Gia int not null,
	constraint FK_CTSP_SanPham foreign key (MaSP) references SanPham (MaSP)
)

create table CTHD
(
	SoHD int not null,
	MaSP int not null,
	Size varchar(1) not null,
	constraint FK_CTHD_SanPham foreign key (MaSP) references SanPham (MaSP)
)

create table pass
(
	username varchar(30) not null,
	MatKhau varchar(30) not null,
)

drop table CTHD

insert into KhachHang (SDT,HoTen) values ('0767062905','Banh Phuc Thinh')

insert into KhachHang (SDT,HoTen) values ('0984657443','Tran Thanh Lam')





select * 
from HoaDon 
where NgHD ='2019-11-14'
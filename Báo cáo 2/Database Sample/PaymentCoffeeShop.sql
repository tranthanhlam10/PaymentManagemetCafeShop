create database PaymentCoffeeShop

use  PaymentCoffeeShop

Create table GUEST
(
	SoKH int identity(1,1) not null,
	MaKH as 'VN' + Right('000000' + CAST(SoKH as varchar(6)),6) persisted primary key,
	SDT varchar(15) not null,
	HoTen varchar(50) not null,
	GioiTinh bit,
	Email varchar(50),
	DoB date,
)

Create table BILL
(
 -- SoHD int identity(1,1) not null primary key,
  --	MaKH varchar(8) default NULL,
 ---	NgHD date,
 ---	ThoigianHD time,
    TenSP varchar(30) not null,
	SoLuong varchar(10),
	Size varchar(1) not null,


	-- TriGia money,
	-- SoBan varchar(10),
	 -- SoLuong varchar(10),
	 -- Size varchar(1) not null,
	






	constraint FK_HoaDon_KhachHang1 foreign key (MaKH) references KhachHang (MaKH)
)

create table MONAN
(
	MaSP int identity(1,1) not null primary key,
	TenSP varchar(30) not null,
)

create table CTSANPHAM
(
	MaSP int not null,
	Size varchar(1) not null,
	GiaSP int not null,
	constraint FK_CTSP_SanPham foreign key (MaSP) references SanPham (MaSP)
)

create table CTHOADON
(
	SoHD int not null,
	MaSP int not null,
	Size varchar(1) not null,
	
	constraint FK_CTHD_HoaDon foreign key (SoHD) references HoaDon(SoHD),
	constraint FK_CTHD_SanPham foreign key (MaSP) references SanPham (MaSP)
)

create table PASSUSER
(
	 Usernames varchar(30) not null,
	 Passwords varchar(30) not null,
)

drop table CTHOADON

insert into GUEST (SDT,HoTen) values ('0767062905','Banh Phuc Thinh')

insert into GUEST (SDT,HoTen) values ('0984657443','Tran Thanh Lam')







select * 
from HoaDon 
where NgHD ='2019-11-14'
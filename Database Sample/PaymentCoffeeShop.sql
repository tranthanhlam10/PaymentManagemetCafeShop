create database Payment

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
	TriGia money not null,
	TienKhachDua money not null,
	constraint FK_HoaDon_KhachHang foreign key (MaKH) references KhachHang (MaKH)
)

create table DongSanPham
(
	DongSP varchar(30) not null primary key, 
)

create table SanPham
(
	MaSP int identity(1,1) not null primary key,
	DongSP varchar(30) not null,
	Ten nvarchar(30) unique not null,
	constraint FK_SanPham_DongSanPham foreign key (DongSP) references DongSanPham (DongSP)
)

create table CTSP
(
	MaSP int not null,
	Size varchar(1) not null,
	Gia money not null,
	constraint FK_CTSP_SanPham foreign key (MaSP) references SanPham (MaSP)
)

create table CTHD
(
	SoHD int not null,
	MaSP int not null,
	Size varchar(1) not null default 'M', 
	SoLuong int not null,
	constraint FK_CTHD_SanPham foreign key (MaSP) references SanPham (MaSP),
	constraint FK_CTHD_HoaDon foreign key (SoHD) references HoaDon (SoHD)
)

create table Nhanvien
(
	MaNV int identity(1,1) primary key,
	MatKhau varchar(50) not null,
	HoTen varchar(40) not null,
	SDT varchar(15) not null,
	GioiTinh bit not null,
	email varchar(50) not null,
	ngaysinh date not null,
)


insert into KhachHang (SDT,HoTen) values ('0767062905','Banh Phuc Thinh')

insert into KhachHang (SDT,HoTen) values ('0984657443','Tran Thanh Lam')

insert into HoaDon (MaKH,NgHD,ThoigianHD,TriGia) values ((select MaKH from KhachHang where SDT='0767062905'),GETDATE(),GETDATE(),100000)

select *
from HoaDon
where day(NgHD)=day(GETDATE())

insert into CTHD values ((select top 1 SoHD from HoaDon order by SoHD desc),1,'S',3)

insert into CTHD values ((select top 1 SoHD from HoaDon order by SoHD desc),1,'M',3)

select SanPham.Ten,SUM(CTHD.SoLuong)
from SanPham,CTHD
where	CTHD.MaSP=SanPham.MaSP
group by SanPham.Ten,CTHD.SoLuong

insert into SanPham (DongSP,Ten) values ('Cafe','Black cafe')
insert into SanPham (DongSP,Ten) values ('Cafe','Milk ')
insert into SanPham (DongSP,Ten) values ('Cafe','Espresso')
insert into SanPham (DongSP,Ten) values ('Cafe','Americano')
insert into SanPham (DongSP,Ten) values ('Tea','Trà đào')
insert into SanPham (DongSP,Ten) values ('Cafe','Cappuchino')
insert into SanPham (DongSP,Ten) values ('Tea','Trà vải')
insert into SanPham (DongSP,Ten) values ('Tea','Trà Oolong')
insert into SanPham (DongSP,Ten) values ('Tea','Trà sữa')
insert into SanPham (DongSP,Ten) values ('Food','Bánh mì que')
insert into SanPham (DongSP,Ten) values ('Food','Bánh mì chà bông phô mai')
insert into SanPham (DongSP,Ten) values ('Food','Pudding đào')
insert into SanPham (DongSP,Ten) values ('Smoothie','Oreo')
insert into SanPham (DongSP,Ten) values ('Smoothie','Rasberry')
insert into SanPham (DongSP,Ten) values ('Smoothie','ChocolateMint')
--Cafe
insert into CTSP values (1,'S',29000)
insert into CTSP values (1,'M',35000)
insert into CTSP values (1,'L',39000)
insert into CTSP values (2,'S',29000)
insert into CTSP values (2,'M',35000)
insert into CTSP values (2,'L',39000)
insert into CTSP values (3,'S',45000)
insert into CTSP values (3,'M',55000)
insert into CTSP values (3,'M',65000)
insert into CTSP values (4,'S',40000)
insert into CTSP values (4,'M',45000)
insert into CTSP values (12,'S',50000)
insert into CTSP values (12,'M',55000)
--Tea
insert into CTSP values (5,'S',45000)
insert into CTSP values (5,'M',52000)
insert into CTSP values (5,'L',59000)
insert into CTSP values (13,'S',45000)
insert into CTSP values (13,'M',52000)
insert into CTSP values (13,'L',59000)
insert into CTSP values (14,'S',38000)
insert into CTSP values (14,'M',45000)
insert into CTSP values (14,'L',50000)
insert into CTSP values (15,'S',45000)
insert into CTSP values (15,'M',52000)
insert into CTSP values (15,'L',59000)
--Food
insert into CTSP values (16,'M',10000)
insert into CTSP values (17,'M',29000)
insert into CTSP values (18,'M',29000)
--Smoothie
insert into CTSP values (19,'M',59000)
insert into CTSP values (19,'L',65000)
insert into CTSP values (20,'M',59000)
insert into CTSP values (20,'L',65000)
insert into CTSP values (21,'M',59000)
insert into CTSP values (21,'L',65000)
--Hoa don fake de test
insert into HoaDon (NgHD,ThoigianHD,TriGia,TienKhachDua) values (GETDATE(),GETDATE(),70000,100000)
insert into CTHD (SoHD,MaSP,Size,SoLuong) values ((select top 1	SoHd  from HoaDon order by SoHd desc),1,'M',2)

insert into HoaDon (NgHD,ThoigianHD,TriGia,TienKhachDua) values (GETDATE(),GETDATE(),104000,104000)
insert into CTHD (SoHD,MaSP,Size,SoLuong) values ((select top 1	SoHd  from HoaDon order by SoHd desc),5,'M',2)

insert into HoaDon (NgHD,ThoigianHD,TriGia,TienKhachDua) values (GETDATE(),GETDATE(),0,0)
insert into CTHD (SoHD,MaSP,Size,SoLuong) values ((select top 1	SoHd  from HoaDon order by SoHd desc),5,'M',1)
insert into CTHD (SoHD,MaSP,Size,SoLuong) values ((select top 1	SoHd  from HoaDon order by SoHd desc),5,'L',1)

insert into HoaDon (NgHD,ThoigianHD,TriGia,TienKhachDua) values (GETDATE(),GETDATE(),81000,100000)
insert into CTHD (SoHD,MaSP,Size,SoLuong) values ((select top 1	SoHd  from HoaDon order by SoHd desc),2,'S',1)
insert into CTHD (SoHD,MaSP,Size,SoLuong) values ((select top 1	SoHd  from HoaDon order by SoHd desc),13,'M',1)

insert into HoaDon (NgHD,ThoigianHD,TriGia,TienKhachDua) values (GETDATE(),GETDATE(),29000,30000)
insert into CTHD (SoHD,MaSP,Size,SoLuong) values ((select top 1	SoHd  from HoaDon order by SoHd desc),17,'M',1)

--bill
select ten as Ten,sum(sl) as soluong,sum(a2) as tongtien
from
(
select Ten as ten,SoLuong as sl,(sum(SoLuong)*Gia) as a2
from SanPham,CTHD,CTSP
where	CTHD.MaSP=SanPham.MaSP
and		CTHD.Size=CTSP.Size
and		SanPham.MaSP=CTSP.MaSP
and		DongSP='tea'
group by SanPham.Ten,CTSP.Gia,CTHD.SoLuong
) asd
group by ten

select	Gia
from	SanPham,CTSP
where	SanPham.MaSP=CTSP.MaSP
and		Ten='Black cafe'
and		Size='M'

select Gia from SanPham, CTSP where SanPham.MaSP = CTSP.MaSP and Ten = 'Black cafe' and Size = 'M'

select	SoHd from HoaDon where day(NgHD)=day(GETDATE())

select	Ten,sum(SoLuong)
from	CTHD,SanPham,HoaDon
where	cthd.MaSP=SanPham.MaSP
and		HoaDon.SoHd=CTHD.SoHD
and		NgHD>='11/19/2019'
and		NgHD<='12/19/2019'
group by CTHD.MaSP,Ten
order by sum(SoLuong) desc


select	SoHd,NgHD,TriGia from HoaDon where (NgHD)='12/12/2019'

select top 1 sohd from hoadon order by sohd desc
select top 1 sohd from hoadon order by sohd desc
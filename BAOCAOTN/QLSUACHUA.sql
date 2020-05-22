use QLSUACHUA;
create table NHANVIEN(
	manv nvarchar(30) not null,
	tennv nvarchar(30),
	macv NVARCHAR(10) not null,
	SDT nvarchar(11),
	namsinh Date,
	diachi nvarchar(50),
	Matkhau nvarchar(100)
)
create table CHUCVU(
	macv NVARCHAR(10) not null,
	tencv nvarchar(30)
)
create table KHACHHANG(
	makh int identity(1,1) not null,
	tenkh nvarchar(30),
	sdt nvarchar(11),
	diachi nvarchar(50)
)
create table trangthai(
	matt NVARCHAR(10) not null,
	tentt nvarchar(30)
)
create table SPDV(
	maspdv NVARCHAR(10) not null,
	tenspdv nvarchar(30),
	dvt nvarchar(10)
)
create table phieunhan(
	makh int not null,
	maphieu int identity(1,1) not null,
	serisp nvarchar(20),
	tensp nvarchar(30),
	manv nvarchar(30) not null,
	yeucauKH nvarchar(100),
	ngaynhanhs datetime,
	ngayhentra datetime,
	ghichu nvarchar(100),
)
create table hoadon(
	mahd int identity(1,1) not null,
	maphieu int not null,
	manv nvarchar(30) not null,
	ngaylaphd datetime,
)
create table chitiethd(
	mahd int not null,
	maspdv NVARCHAR(10) not null,
	soluong int,
	dongia float
)
create table xuly(
	maxl int identity(1,1) not null,
	maphieu int not null,
	manv nvarchar(30) not null,
	matt nvarchar(10) not null,
	thoigian datetime,
)
alter table chucvu
add constraint pk_chucvu primary key
(
	macv
)
alter table nhanvien
add constraint pk_nhanvien primary key
(
	manv
)
alter table khachhang
add constraint pk_khachhang primary key
(
	makh
)
alter table trangthai
add constraint pk_trangthai primary key
(
	matt
)
alter table spdv
add constraint pk_spdv primary key
(
	maspdv
)
alter table phieunhan
add constraint pk_phieunhan primary key
(
	maphieu
)
alter table hoadon
add constraint pk_hoadon primary key
(
	mahd
)
alter table chitiethd
add constraint pk_chitiethd primary key
(
	mahd,maspdv
)
alter table xuly
add constraint pk_xuly primary key
(
	maxl
)
alter table nhanvien
add constraint fk_nhanvien_chucvu
foreign key
(
	macv
)
references chucvu
(
	macv
)
alter table phieunhan
add constraint fk_phieunhan_khachhang
foreign key
(
	makh
)
references khachhang
(
	makh
)
alter table phieunhan
add constraint fk_phieunhan_nhanvien
foreign key
(
	manv
)
references nhanvien
(
	manv
)

alter table hoadon
add constraint fk_hoadon_phieunhan
foreign key
(
	maphieu
)
references phieunhan
(
	maphieu
)
alter table hoadon
add constraint fk_hoadon_nhanvien
foreign key
(
	manv
)
references nhanvien
(
	manv
)
alter table chitiethd
add constraint fk_chitiethd_hoadon
foreign key
(
	mahd
)
references hoadon
(
	mahd
)
alter table chitiethd
add constraint fk_chitiethd_spdv
foreign key
(
	maspdv
)
references spdv
(
	maspdv
)
alter table xuly
add constraint fk_xuly_phieunhan
foreign key
(
	maphieu
)
references phieunhan
(
	maphieu
)
alter table xuly
add constraint fk_xuly_nhanvien
foreign key
(
	manv
)
references nhanvien
(
	manv
)
alter table xuly
add constraint fk_xuly_trangthai
foreign key
(
	matt
)
references trangthai
(
	matt
)
INSERT INTO trangthai VALUES(N'DN',N'Đã Nhận')
INSERT INTO trangthai VALUES(N'KT',N'Kiểm Tra')
INSERT INTO trangthai VALUES(N'SSTK',N'Sẵn Sàng Trả Khách')
INSERT INTO trangthai VALUES(N'HT',N'Hoàn Thành')
INSERT INTO CHUCVU VALUES(N'ADMIN',N'ADMIN')
INSERT INTO NHANVIEN VALUES(N'ADMIN',N'ADMIN',N'ADMIN',N'0911580144','1/1/1996',N'Cái Nước - Cà Mau',N'73ACD9A5972130B75066C82595A1FAE3')
alter table xuly add ghichu nvarchar(20)
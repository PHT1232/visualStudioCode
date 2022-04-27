use ThuVien

create table nhaxuatban
(
	manhaxuatban nvarchar(20) primary key,
	tennhaxuatban nvarchar(30),
	diachi nvarchar(50),
	email nvarchar(30),
	nguoidaidien nvarchar(40)
)

alter table tacgia 
add email nvarchar(30) 

alter table tacgia 
add gioitinh nvarchar(4) 

create table tacgia 
(
	matacgia nvarchar(30) primary key,
	tentacgia nvarchar(30),
	ghichu nvarchar(255)
)

create table theloai 
(
	matheloai nvarchar(30) primary key,
	tentheloai nvarchar(30),
	ghichu nvarchar(50)
)

create table sach 
(
	masach nvarchar(30) primary key,
	tensach nvarchar(30),
	matacgia nvarchar(30),
	matheloai nvarchar(30),
	manhaxuatban nvarchar(20),
	namxuatban nvarchar(20),
	hinhanh nvarchar(50),
	trangthai int,
	mota varchar(100)
	foreign key (matacgia) references tacgia(matacgia),
	foreign key (matheloai) references theloai(matheloai),
	foreign key (manhaxuatban) references nhaxuatban(manhaxuatban)
)

create table docgia 
(
	madocgia nvarchar(50) primary key,
	tendocgia nvarchar(50),
	diachi nvarchar(50),
	trangthai int
)

create table trasach 
(
	id nvarchar(30) primary key,
	madocgia nvarchar(50),
	masachtra nvarchar(30),
	tensachtra nvarchar(30),
	mota nvarchar(50),
	ngaymuon nvarchar(30),
	songaymuon varchar(30),
	ngaytra nvarchar(30),
	songaycham nvarchar(30)
	foreign key (masachtra) references sach(masach),
	foreign key (madocgia) references docgia(madocgia)
)

create table muonsach 
(
	id int identity primary key,
	madocgia nvarchar(50),
	masach nvarchar(30),
	mota nvarchar(50),
	ngaymuon nvarchar(10),
	songaymuon nvarchar(10),
	trangthai int
	foreign key (masach) references sach(masach),
	foreign key (madocgia) references docgia(madocgia)
)

create table account 
(
	username nvarchar(40),
	password nvarchar(40)
)
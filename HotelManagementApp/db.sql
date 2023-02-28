USE master
CREATE DATABASE QLKhachSan
GO

USE QLKhachSan
CREATE TABLE Phong
(
	maPhong int Identity(1,1) primary key,
	soPhong varchar(250) not null unique,
	loaiPhong varchar(250) not null,
	giaPhong float not null,
	tinhTrangPhong bit default 0,
);
GO
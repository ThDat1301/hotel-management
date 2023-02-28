create database hotelManagement;
go

use hotelManagement;
go

create table Customer 
(
	id int identity(1,1) primary key, 
	name nvarchar(50), 
	gender Bit, 
	phone nvarchar(11), 
	address nvarchar(50), 
	personalId nvarchar(12),
);
go

create table Staff 
(
	id int identity(1,1) primary key, 
	name int, 
	gender Bit, 
	phone nvarchar(11), 
	email nvarchar(50),
	username nvarchar(50),
	passwords nvarchar(50), 
);
go

create table Orders
(
	id int identity(1,1) primary key, 
	numberCustomer int, 
	checkinDate Date,
	customerID int foreign key references Customer(id),
	staffID int foreign key references Staff(id),
);
go

create table Room 
(
	id int identity(1,1) primary key, 
	num int,
	status Bit, 
	type nvarchar(50), 
	price Float, 
	orderID int foreign key references Orders(id), 
);
go

create table Product 
(
	id int identity(1,1) primary key, 
	name nvarchar(50), 
	price Float,
);
go

create table Order_Product
(
	orderID int foreign key references Orders(id),
	productID int foreign key references Product(id), 
	constraint PK_OP primary key (orderID, productID)
);
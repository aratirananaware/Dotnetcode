create database sampledb;
use sampledb;
create table tblsample(id int identity(1,1),text varchar(50),primary key(id));
select * from tblsample;

create table Employee(id int identity(1,1),FirstName varchar(50),LastName varchar(50),gender varchar(50),primary key(id));
select * from Employee;
insert into Employee values('Arati','Rananaware','female');

create table student(id int,name varchar(50),cid int,primary key(id));
create table course(id int,cname varchar(50),primary key(id));
insert into student values(1,'arati',1);
insert into student values(2,'pooja',2);

insert into course values(1,'CS');
insert into course values(2,'Electrical');

select * from student;
select * from course;

create database customerdb1;
use customerdb1;
drop table customer;
drop table supplier;

create table customer(id int identity(1,1),CustomerCode nvarchar(50),CustomerName nvarchar(50),CustomerAmount int NOT NULL,primary key(id));
create table supplier(id int identity(1,1),SupplierCode nvarchar(50),SupplierName nvarchar(50),SupplierAmount int NOT NULL,primary key(id));
select * from customer;
insert into customer values('234','gita',5800);
select * from supplier;


create database ProductDB;

use ProductDB;

create table UserDetails(UserId int identity(1,1),UserName nvarchar(50) NOT NULL,Password varchar(50) NOT NULL,Address varchar(50),MobileNo varchar(10) check(MobileNo like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),Primary key(UserId));
create table ProductDetails(ProductId int identity(1,1) primary key,ProductName nvarchar(50) NOT NULL,CategoryId int,Price int,ImagePath varchar(50));
create table Category(CategoryId int identity(1,1) primary key,CategoryName varchar(50) NOT NULL);
create table AdminDetails(UserId int identity(1,1) primary key,AdminName nvarchar(50) NOT NULL,Password varchar(50) NOT NULL);

select * from UserDetails;
select * from ProductDetails;
select * from Category;
select * from AdminDetails;



create database EcommerceDB;
use EcommerceDB;
drop table TbILogin;
create table TblLogin(Id int identity(1,1) primary key,UserName varchar(50)NOT NULL,Password varchar(50)NOT NULL,IsAdmin int);
create table TblCategory(Id int identity(1,1) primary key,CatName varchar(100) NOT NULL);
create table TblProduct(Id int identity(1,1) primary key,ProductName varchar(100),ProductDescription varchar(50),CatId int,ProductImage varchar(100),ProductMrp decimal(18,2),ProductDiscount decimal(18,2),ProductFinal decimal(18,2),ProductQuantity int);
select * from TblCategory;
select * from TblProduct;
select * from TblLogin;
insert into TblLogin values('admin','admin',1);
insert into TblProduct values('mobile','one plus',NULL,'mobile.jfif',1000.00,10.00,100.00,20);
insert into TblProduct values('jwellery','choker',NULL,'choker.jpg',2000.00,20.00,200.00,10);
insert into TblProduct values('shirt','woman shirt',NULL,'shirt.webp',1000.00,20.00,200.00,10);
insert into TblProduct values('handbag','handbag',NULL,'handbag.jpg',1000.00,20.00,200.00,10);

delete from TblProduct where id=6;

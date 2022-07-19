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


create database StockDB;
use StockDB;
create table company(companyCode int identity(1,1) primary key,companyName varchar(100),companyCeo varchar(100),companyTurnover int,companyWebsite varchar(100),stockExchange varchar(100));
create table stockprice(stockprice decimal(18,2));
select * from company;
select * from stockprice;

create database FoodProject;
use FoodProject;
create table RegisterTbl(UserID int identity(1,1) primary key,UserName varchar(100),Address varchar(100),PhoneNo int,Email varchar(100),Password varchar(100),IsAdmin int);
create table FoodDetails(CatID int identity(100,1) primary key,FoodName varchar(100),FoodDescription varchar(100),FoodPrice int,FoodImage varchar(100));
create table OrderTbl(OrderID int identity(1,1) primary key,UserName varchar(100),PaymentMode varchar(100),Address varchar(100),UserID int foreign key references RegisterTbl(UserID));
create table Category(ID int identity(1,1) primary key,CatName varchar(100),CatID int foreign key references FoodDetails(CatID));

select * from RegisterTbl;
select * from FoodDetails;
select * from OrderTbl;
select * from Category;

insert into FoodDetails values('Vada Pav','The dish consists of a deep fried potato dumpling placed inside a bread bun',10,'vadapav.jfif');
insert into FoodDetails values('Pizza','vegan pizza',200,'pizza.webp');
insert into FoodDetails values('Snacks','Healthy snacks',200,'snack.png');
insert into FoodDetails values('Juice','Mango flavor',50,'juice.jpg');

insert into OrderTbl values('arati','cash on delivery','pune',1);
delete from OrderTbl where OrderID=1;

create database fooddb;
use fooddb;
create table RegisterTbl(UserID int identity(1,1) primary key,UserName varchar(100),Address varchar(100),PhoneNo int,Email varchar(100),Password varchar(100),IsAdmin int,IsRestaurant int);
create table FoodDetails(Id int identity(1,1) primary key,restaurantName varchar(100),foodName varchar(100),foodImage varchar(100),foodDescription varchar(100),place varchar(100),foodMrp decimal(18,2),foodDiscount decimal(18,2),foodFinal decimal(18,2),foodQuantity int);
select * from RegisterTbl;
select * from FoodDetails;
alter table FoodDetails add IsActive int;

insert into RegisterTbl values('arati','pune',77093,'arati@gmail.com','arati',1,0);
insert into FoodDetails values('Vedant','Vada Pav','vadapav.jfif','fast food','pune',10.00,0,10.00,10,1);
insert into FoodDetails values('Shri','Snacks','snack.png','Healthy snack','pune',200.00,10.00,180.00,20,0);
delete from FoodDetails where Id=7;

create table OrderTbl(Id int identity(100,1) primary key,firstName varchar(100),lastName varchar(100),Email varchar(100),PhoneNo varchar(10),paymentmode varchar(100),Address varchar(100));
select * from OrderTbl;
delete from OrderTbl where Id=100;
delete from RegisterTbl where UserID=4;
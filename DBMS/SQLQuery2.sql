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
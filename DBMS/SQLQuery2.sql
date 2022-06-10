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
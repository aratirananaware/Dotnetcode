create database sampledb;
use sampledb;
create table tblsample(id int identity(1,1),text varchar(50),primary key(id));
select * from tblsample;
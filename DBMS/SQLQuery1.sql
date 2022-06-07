create database dbms;

create table sample2(id1 int,name1 varchar(10));
select * from sample2;

insert into sample2 values(1,'arati');
insert into sample2 values(2,'diya');

delete from sample2 where id1=1;

update sample2 set name1='gita' where id1=2;

create table Employee(id int,name varchar(20),empid int);
alter table Employee add salary int;
select * from Employee;
insert into Employee values(1,'arati',123,1000);
insert into Employee values(2,'gita',345,7800);
insert into employee values(3,'hina',765,2000);

select max(salary) from Employee;
select min(salary) from employee;
select * from employee order by salary desc;
select count(empid)as count from Employee;

select name from employee where name like 'a%';


create table employee12 (id int,name varchar(200),departmentid int)
create table department(id int,department varchar(20))
insert into employee12 values(1,'Vikash',1);
insert into employee12 values(2,'Rohit',2);
insert into employee12 values(3,'Rahul',1);
insert into employee12 values(4,'Rahul',3);

insert into department values(1,'IT');
insert into department values(2,'Sales');
insert into department values(4,'Admin');

select * from employee12;
select * from department;

select emp.name,dep.department from employee12 as emp inner join department as dep on emp.departmentid=dep.id;

select emp.name,dep.department from employee12 as emp left join department as dep on emp.departmentid=dep.id;

select emp.name,dep.department from employee12 as emp right join department as dep on emp.departmentid=dep.id;

select * from employee12 as emp inner join department as dep on emp.departmentid=dep.id;

select * from employee12;

select * from department;

select * from employee12 emp FULL OUTER JOIN department dep on emp.departmentid=dep.id;

select * from employee12 emp LEFT OUTER JOIN department dep on emp.departmentid=dep.id;

select * from employee12 emp RIGHT OUTER JOIN department dep on emp.departmentid=dep.id;

create table student1(id int,rollno int,firstname varchar(200),lastname varchar(200),gender varchar(20),classid int);
create table studentclass(id int,classname varchar(200));
insert into student1 values(1,11,'arati','rananaware','female',12);
insert into studentclass values(12,'computer');
select rollno,firstname||' '||lastname as fullname,gender,classname from student1 s join studentclass sc on s.classid=sc.id;


create function GetFullName(@ID int)
returns varchar(200)  AS 
Begin
 return (select CONCAT(firstname,' ',lastname) as FullName from students where id=@ID);
End

select * from students
select dbo.GetFullName(2) ;


select * from employee
create proc AddEmployee(@Id int,@Name varchar(200),@DepartmentId int)
As 
Begin

insert into employee values(@Id,@Name,@DepartmentId);
END


exec dbo.AddEmployee 5,'xys',1
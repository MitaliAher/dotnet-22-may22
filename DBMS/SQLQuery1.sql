create database sampledata;
drop database sampledata;

create table sampleT(ID int, Name varchar(100));
select * from sampleT;

insert into sampleT values(1, 'Mitali');
insert into sampleT values(2, 'asmi');
insert into sampleT values(3, 'pooja');
insert into sampleT values(4, 'adi');

delete from sampleT where ID=4;

update sampleT set Name='Asmita' where Name='Asmi';

create table Employee(EmpID int, EmpName varchar(100));

insert into Employee values(101, 'Amruta');
insert into Employee values(102, 'Amar');
insert into Employee values(103, 'Abhilash');
insert into Employee values(104, 'Ruta');
insert into Employee values(105, 'Sam');

select * from Employee;
delete  from Employee;


create table Emp(EmpID int, EmpName varchar(100) , EmpGender varchar(20), Salary int);

insert into Emp values(101, 'Amruta' , 'Female' ,2000);
insert into Emp values(102, 'Amar' , 'Male' ,2200);
insert into Emp values(103, 'Abhilash' , 'Male' ,1200);
insert into Emp values(104, 'Ruta' , 'Female' , 1000);
insert into Emp values(105, 'Sam' , 'Male' ,2400);

select * from Emp;

update Emp set EmpName='Samir' where EmpID = 105;

alter table Emp Add Department varchar(30);
alter table Emp drop column Department;

alter table Emp Add Dept varchar(200);

delete from Emp;

insert into Emp values(101, 'Amruta' , 'Female' ,2000 , 'Marketing');
insert into Emp values(102, 'Amar' , 'Male' ,2200 , 'Marketing');
insert into Emp values(103, 'Abhilash' , 'Male' ,1200 , 'Sales');
insert into Emp values(104, 'Ruta' , 'Female' , 1000 , 'HR');
insert into Emp values(105, 'Sam' , 'Male' ,2400, 'Finance');

select * from Emp;

select max(Salary) from Emp;
select min(Salary) from Emp;
select avg(Salary) from Emp;

select count(*) from Emp;

select * from Emp where EmpName like 'a%';

select CONCAT (EmpName, '-->' , Salary) as SalaryDetails From Emp;







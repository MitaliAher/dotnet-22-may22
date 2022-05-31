create table employee (id int,name varchar(200),departmentid int)
create table department(id int,department varchar(20))
insert into employee values(101,'Mitali',1)
insert into employee values(102,'Amit',2)
insert into employee values(103,'Pooja',2)
insert into employee values(104,'neha',3)

insert into department values(1,'IT')
insert into department values(2,'Sales')
insert into department values(4,'HR')

select * from employee
select * from department

select emp.name,dep.department from employee as emp inner join department as dep on emp.departmentid=dep.id

select emp.name,dep.department from employee as emp left join department as dep on emp.departmentid=dep.id

select emp.name,dep.department from employee as emp right join department as dep on emp.departmentid=dep.id

select * from employee as emp inner join department as dep on emp.departmentid=dep.id;
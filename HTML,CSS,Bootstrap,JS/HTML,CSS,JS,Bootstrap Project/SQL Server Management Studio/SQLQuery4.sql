use sample;


CREATE TABLE department(deptno int,
dname nvarchar(20),
CONSTRAINT "PK_department" PRIMARY KEY(deptno));

CREATE TABLE Employee(eno int,
ename nvarchar(25) not null,
phone int not null,deptno int,
designation nvarchar(20),CONSTRAINT "PK_EMPLOYEE" PRIMARY KEY("eno"),
CONSTRAINT "FK_EMPLOYEE_DEPARTMENT" FOREIGN KEY("deptno")
REFERENCES "DBO"."DEPARTMENT" ("deptno"));

insert into department values(10,'CSE');
 insert into department values(20,'ECE');
 insert into department values(30,'EEE');
 insert into department values(40,'MECH');
 insert into department values(50,'BME');

 insert into Employee values(101,'AAA',3456,10,'MGR');
 insert into Employee values(102,'BBB',3456,20,'MGR');
 insert into Employee values(103,'CCC',3456,10,'CLERK');
insert into Employee values(104,'DDD',3456,30,'HOD');
insert into Employee values(105,'EEEE',3456,50,'MGR');

 select ename from employee inner join department on employee.deptno=department.deptno and department.dname not in('CSE');

 select e.ename 'EMP name',e.deptno 'DEPT NUM',d.dname'DEPT NAME' 
 from employee e right outer join department d on e.deptno = d.deptno;

  select e.ename 'EMP name',e.deptno 'DEPT NUM',d.dname'DEPT NAME' 
 from employee e left outer join department d on e.deptno = d.deptno;

  select e.ename 'EMP name',e.deptno 'DEPT NUM',d.dname'DEPT NAME' 
 from employee e full outer join department d on e.deptno = d.deptno;

 select e.ename 'EMP name',e.deptno 'DEPT NUM',d.dname'DEPT NAME' 
 from employee e cross join department d; /* ON is not needed in cross join*/


select * from employee;
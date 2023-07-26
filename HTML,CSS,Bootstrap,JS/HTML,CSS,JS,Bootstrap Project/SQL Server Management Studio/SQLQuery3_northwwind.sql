use assignment_1;

create table Customer(CustomerId bigint,Cust_Name nvarchar(20),Address1 nvarchar(30),Address2 nVarchar(30));

EXEC SP_RENAME 'customer.Cust_Name','CustomerName','COLUMN';
ALTER TABLE Customer
    ALTER COLUMN CustomerName VARCHAR(30) NOT NULL;

ALTER TABLE Customer ADD  Gender nvarchar(1),Age int,PhoneNo bigint;

insert customer values(1000, 'Allen', '#115 Chicago', '#115 Chicago', 'M', 25, 7878776);
insert customer values(1001, 'George', '#116 France', '#116 France', 'M', 25, 434524);
insert customer values(1002, 'Becker', '#114 New york', '#114 New york', 'M', 45, 431525);

ALTER TABLE customer alter column customerId bigint not null;
ALTER table customer add constraint custId_prim primary key(customerId);

ALTER TABLE customer drop constraint custId_prim;
insert customer values(1003,'Nanapatekar', '#115 India', '#115 India' , 'M', 45, 431525);

select * from customer;

CREATE TABLE EMP(EMPNO int not null,ENAME nvarchar(10),JOB nvarchar(50),MGR int,HIREDATE date,SAL NUMERIC(7,2),COMM NUMERIC(7,2),DEPTNO smallint);

insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7369,'SMITH',800,20);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7499,'ALLEN',1600,30);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7521,'WARD',1250,30);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7566,'JONES',2975,20);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7654,'MARTIN',1250,30);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7698,'BLAKE',2850,30);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7782,'CLARK',2450,10);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7788,'SCOTT',3000,20);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7839,'KING',5000,10);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7844,'TURNER',1500,30);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7876,'ADAMS',1100,20);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7900,'JAMES',950,30);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7902,'FORD',3000,20);
insert EMP(EMPNO,ENAME,SAL,DEPTNO)values(7934,'MILLER',1300,10);

insert emp values(1000,'ALLEN','CLERK',1001,'12-JAN-01',3000,2,10);
insert emp values(1001,'GEORGE','ANALYST',NULL,'08 SEP 92',5000,0,10);
insert emp values(1002,'BECKER','MANAGER',1000,'4 NOV 92',2800,4,20);
insert emp values(1003,'BILL','CLERK',1002,'4 NOV 92',3000,0,10);

select * from EMP;

CREATE TABLE Project(PROJID NVARCHAR(10)NOT NULL,PROJ_NAME NVARCHAR(25),"START_DATE" DATE,"END_DATE" DATE);

insert project values('A','aaa','10/3/2023','12/4/2023');
insert project values(2,'ccc','2023/04/25','2023/05/24');
insert project values(3,'bbb','2023/03/14','2023/04/15');

select * from project;

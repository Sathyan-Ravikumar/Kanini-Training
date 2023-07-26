use sample

CREATE TABLE EmpLog (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL	
)
                              --DML trigger
--trigger for insert
create or alter trigger dbo.EmpInsert 
on dbo.employee 
for insert 
AS
   INSERT INTO dbo.EmpLog(EmpID,Operation,UpdatedDate)select eno,'INSERT',getdate()from inserted;

select * from Employee
select * from emplog;
insert into employee values(106,'manisha',9983,10,'sup')

--trigger for update
create or alter trigger dbo.Empupdate
on dbo.employee 
after update
AS
   INSERT INTO dbo.EmpLog(EmpID,Operation,UpdatedDate)select eno,'UPDATE',getdate()from deleted;

update employee set deptno=30 where eno=106;

delete from emplog where logid=2;

--trigger for delete
--it prevent from delete the record
create or alter trigger dbo.EmpDelete 
on dbo.employee 
instead of delete
AS
   INSERT INTO dbo.EmpLog(EmpID,Operation,UpdatedDate)select eno,'DELETE',getdate()from deleted;


   delete from employee where eno=106;
     
	        --ddl trigger

create table tablelog(eventval sysname,eventdate date,changedby varchar(30))
drop table tablelog

create trigger trg_tablechange
on database
for
create_table,alter_table,drop_table
as begin
insert into tablelog(eventval,eventdate,changedby) values(eventdata(),getdate(),user);
end;

 create table dummy(testid int identity(1,1) primary key,testname sysname not null)

 drop table dummy;
                     
 create or alter trigger trgloginconnection
 on all server
 for logon
 as
 begin
 if ORIGINAL_LOGIN()=N'sa' and
		(select count(*) from sys.dm_exec_sessions where is_user_process=1 and original_login_name=N'sa')>2
		rollback;
end;

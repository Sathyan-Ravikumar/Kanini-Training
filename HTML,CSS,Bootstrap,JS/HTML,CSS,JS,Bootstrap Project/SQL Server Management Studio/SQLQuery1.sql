
insert into studpersdet values(2,'sathyan',63,'2002/06/03',635001,'rsathyan@gmail.com');


insert into studpersdet(rno,phone_number,sname) values(3,342.,'jeeva');

update studpersdet set dob = '2020/7/30' where rno=2;

delete from studpersdet;



insert into studpersdet values(2,'sathyan',63,'2002/06/03',635001,'rsathyan@gmail.com');

commit;
begin transaction;
 
insert into studpersdet(rno,phone_number,sname) values(3,342.,'jeeva');

insert into studpersdet values(1,'visvek',23,'2002/05/04',635001,'xyz@gmail.com');
rollback;
commit;
select * from studpersdet;


ALTER TABLE studpersdet add constraint pk_studpersdet primary key(rno);

select rno as 'Roll Number', sname as Student_name from studpersdet where rno=2 and sname='sathyan';

select rno as 'Roll Number', sname as Student_name from studpersdet where sname like 's%n';
insert into studpersdet values(4,'javakar',16,'2002/12/09',823627,'vbg@mail.com');

insert into studpersdet(rno,phone_number,sname) values(3,342.,'jeeva');

insert into studpersdet values(1,'visvek',23,'2002/05/04',635001,'xyz@gmail.com');
select * from studpersdet;

select rno as 'Roll Number', sname as Student_name, dob as 'date of birth' from studpersdet where sname in ('sathyan','jeeva') order by dob;



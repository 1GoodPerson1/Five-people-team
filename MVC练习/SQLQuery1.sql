use master
go
create database StudentManagement
go

use StudentManagement
go

create table Class
(
Id	int	primary key identity(101,1),--	�༶ID
ClassName	nvarchar(32)	not null,--	�༶����
)

create table Student
(
Id	int	primary key identity(1,1),--	�����
Name nvarchar(32)	not null,--	����
Age	int	not null,--	����
Mobile	varchar(16)	not null,--	�ֻ�����
Email	varchar(32)	not null,--	����
ClassId	int	references Class(Id),--	�༶Id
AddTime	datetime	not null,--	���ʱ��
)

insert into Class values('.net��')
insert into Class values('.java��')
insert into Class values('.IOS��')
select* from Class

insert into Student values ('��˽�',18,'12345678910','123456789@qq.com',101,'2019-01-01')
insert into Student values ('�����',18,'12345678910','123456789@qq.com',102,'2019-01-01')
insert into Student values ('ɳ����',18,'12345678910','123456789@qq.com',103,'2019-01-01')
insert into Student values ('��ɮ',18,'12345678910','123456789@qq.com',101,'2019-01-01')
insert into Student values ('С����',18,'12345678910','123456789@qq.com',103,'2019-01-01')

select * from Student



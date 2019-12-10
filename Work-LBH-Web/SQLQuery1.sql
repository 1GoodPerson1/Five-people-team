use master
go

if exists(select * from sys.databases where name='Work')
drop database Work
go

create database Work
go
use Work
go
--创建基本信息表
if exists(select * from sys.tables where name='personinfo')
drop table personinfo
go

create table personinfo
(
	Pid int primary key identity(1,1),
	Pname varchar(20)not null,
	Psex char(2)not null,
	Page int not null,
	birthday datetime not null,
	Phone varchar(20)not null,
	Email varchar(20)not null,
	Iswork bit not null
)
insert into personinfo values('李彬辉','男',18,'1998-10-20','15993629833','2533621490@qq.com',0)
select * from personinfo
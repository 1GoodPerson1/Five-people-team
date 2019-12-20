use master
go
create database StudentManagement
go

use StudentManagement
go

create table Class
(
Id	int	primary key identity(101,1),--	班级ID
ClassName	nvarchar(32)	not null,--	班级名称
)

create table Student
(
Id	int	primary key identity(1,1),--	类别编号
Name nvarchar(32)	not null,--	姓名
Age	int	not null,--	年龄
Mobile	varchar(16)	not null,--	手机号码
Email	varchar(32)	not null,--	邮箱
ClassId	int	references Class(Id),--	班级Id
AddTime	datetime	not null,--	添加时间
)

insert into Class values('.net班')
insert into Class values('.java班')
insert into Class values('.IOS班')
select* from Class

insert into Student values ('猪八戒',18,'12345678910','123456789@qq.com',101,'2019-01-01')
insert into Student values ('孙悟空',18,'12345678910','123456789@qq.com',102,'2019-01-01')
insert into Student values ('沙和尚',18,'12345678910','123456789@qq.com',103,'2019-01-01')
insert into Student values ('唐僧',18,'12345678910','123456789@qq.com',101,'2019-01-01')
insert into Student values ('小白龙',18,'12345678910','123456789@qq.com',103,'2019-01-01')

select * from Student



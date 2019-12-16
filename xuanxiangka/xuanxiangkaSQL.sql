use master
go
create database student
go
use student
go
--年级表
create table class
(
classid int primary key identity(1,1),--年级编号
classname varchar(20)not null,--年级
)
insert class values('一年级')
insert class values('二年级')
insert class values('三年级')
select * from class
--学生信息表
create table stuinfo
(
sid int primary key identity(1,1),--sid
sname varchar(20) not null,--姓名
sex char(2) not null,--性别
classid int references class(classid),--年级编号
age int not null--年龄
)
insert stuinfo values('张三','男',1,18)
insert stuinfo values('李四','女',2,19)
insert stuinfo values('王五','男',3,20)
select * from stuinfo
--理想工作表
create table word
(
wid int primary key identity(1,1),--wid
sid int references stuinfo(sid),--学生id
wname varchar(20) ,--岗位
wmoney money ,--薪资
)
insert word values(1,'.NET工程师',5000)
insert word values(2,'.java工程师',5000)
insert word values(3,'.web工程师',5000)
select * from word
--最后准备
create table zhunbei
(
zid int primary key identity(1,1),--zid
sid int references stuinfo(sid),--学生id
zstatic varchar(50),--状态
wtime date ,--入职时间
)
insert zhunbei values(1,'','2019-01-01')
insert zhunbei values(2,'','2020-01-01')
insert zhunbei values(3,'','2020-01-01')
use master
go
create database student
go
use student
go
--�꼶��
create table class
(
classid int primary key identity(1,1),--�꼶���
classname varchar(20)not null,--�꼶
)
insert class values('һ�꼶')
insert class values('���꼶')
insert class values('���꼶')
select * from class
--ѧ����Ϣ��
create table stuinfo
(
sid int primary key identity(1,1),--sid
sname varchar(20) not null,--����
sex char(2) not null,--�Ա�
classid int references class(classid),--�꼶���
age int not null--����
)
insert stuinfo values('����','��',1,18)
insert stuinfo values('����','Ů',2,19)
insert stuinfo values('����','��',3,20)
select * from stuinfo
--���빤����
create table word
(
wid int primary key identity(1,1),--wid
sid int references stuinfo(sid),--ѧ��id
wname varchar(20) ,--��λ
wmoney money ,--н��
)
insert word values(1,'.NET����ʦ',5000)
insert word values(2,'.java����ʦ',5000)
insert word values(3,'.web����ʦ',5000)
select * from word
--���׼��
create table zhunbei
(
zid int primary key identity(1,1),--zid
sid int references stuinfo(sid),--ѧ��id
zstatic varchar(50),--״̬
wtime date ,--��ְʱ��
)
insert zhunbei values(1,'','2019-01-01')
insert zhunbei values(2,'','2020-01-01')
insert zhunbei values(3,'','2020-01-01')
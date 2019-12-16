create  database  matchmaker
go
use matchmaker
go

--��¼��
if exists(select * from sys.tables where name='loginUser')
drop table loginUser
go
create table loginUser(
   Userid int identity(1,1) primary key,--id  ����
   userName varchar(50) not null,--�û���
   userPwd varchar(100) not null, --�û�����
   Userinfo bit check(Userinfo=0 or Userinfo=1),--�û���ɫ ��  Ů
)
insert into loginUser values('����','123456',1)
insert into loginUser values('������','123456',0)
insert into loginUser values('���಩','123456',1)
insert into loginUser values('��ӨӨ','123456',0)

--boyInfo
if exists(select * from sys.tables where name='BoyInfo')
drop table BoyInfo
go

create table BoyInfo(
 boyid int identity(1001,1) primary key,
 boyName varchar(20) not null,--����
 boySex varchar(2) not null,--�Ա�
 boyAge int not null,--����
 boyHeight int not null ,--���
 boyWeight float not null,--����
 boyjob varchar(100),--����
 boyjobMoney decimal(18,2) default(0) check(boyjobMoney>=0),--н��
 boyAddress varchar(50) not null,--��ַ
 boyHobbly  varchar(100) ,--����
 boymate varchar(500) not null,--��ż��׼
 boyimg varchar(max),--ͼƬ·��
 boyimg1 varchar(max),
 boyimg2 varchar(max),
)
insert into  BoyInfo values('����','��',32,183,65,'IT��ҵ�߹�','400000','�Ϻ�','����','�Ϻ����أ�����ѧ�������160���ϣ���ٶ���','','','')
insert into  BoyInfo values('��˹','��',24,177,60,'��Ӱʦ','300000','֣��','����','Ư��������һ��','','','')
insert into  BoyInfo values('����','��',28,180,60,'��������ʦ','350000','�Ϻ�','����','Ư���������࣬����������Т˳������','','','')
insert into  BoyInfo values('¬���','��',22,175,80,'���۾���','300000','֣��','��ʳ','Т˳��������˶ʿ����ѧ�������������170����','','','')


--girlInfo
if exists(select * from sys.tables where name='GirlInfo')
drop table GirlInfo
go

create table GirlInfo(
 girlid int identity(1001,1) primary key,
 girlName varchar(20) not null,
 girlSex varchar(2) not null,
 girlAge int not null,--����
 girlHeight int not null ,
 girlWeight float not null ,
 girljob varchar(100),
 girljobMoney decimal(18,2) default(0) check(girljobMoney>=0),
 girlAddress varchar(50) not null,
 girlHobbly  varchar(100) ,
 girlmate varchar(500) not null,
 girlimg varchar(max),
 girlimg1 varchar(max),
 girlimg2 varchar(max),
)
insert into  GirlInfo values('����','Ů',24,165,50,'�߻�ʦ','100000','֣��','���������飬����Ʒ','���175���ϣ�˧������Ĭ�����ᣬ����','','','')
insert into  GirlInfo values('С��','Ů',23,160,45,'���ʦ','100000','֣��','���������飬����Ʒ','֣�ݱ��أ� �з��г��д��','','','')
insert into  GirlInfo values('С̷','Ů',25,165,50,'�赸��ʦ','200000','�Ϻ�','���Σ�����','���175���ϣ����� ���ᣬ���Ķ���','','','')
insert into  GirlInfo values('���','Ů',26,168,50,'ҽ��','400000','֣��','����','���ᣬ���������⣬�з��г�','','','')

--groupInfo
if exists(select * from sys.tables where name='GroupInfo')
drop table GroupInfo
go

CREATE table GroupInfo(
  groupId int identity(101,1) primary key not null,
  boyName varchar(50) not null,--������
  GirlName varchar(50)not null,--Ů����
  lovetime datetime default(getdate()),--��һ��ʱ��
  hand bit default(0) check(hand=0 or hand=1) not null,--�Ƿ�ǣ�ֳɹ�
  SusseccTime datetime default(null),--ǣ�ֳɹ�ʱ��

)

insert into GroupInfo values('����','����',GETDATE(),default,null)
insert into GroupInfo values('���','���',GETDATE(),default,null)
insert into GroupInfo values('����','�˵�',GETDATE(),default,null)


select* from GroupInfo
select* from GirlInfo
select* from BoyInfo
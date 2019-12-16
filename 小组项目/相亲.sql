create  database  matchmaker
go
use matchmaker
go

--登录表
if exists(select * from sys.tables where name='loginUser')
drop table loginUser
go
create table loginUser(
   Userid int identity(1,1) primary key,--id  主键
   userName varchar(50) not null,--用户名
   userPwd varchar(100) not null, --用户密码
   Userinfo bit check(Userinfo=0 or Userinfo=1),--用户角色 男  女
)
insert into loginUser values('李彬辉','123456',1)
insert into loginUser values('代梦丽','123456',0)
insert into loginUser values('谷相博','123456',1)
insert into loginUser values('王莹莹','123456',0)

--boyInfo
if exists(select * from sys.tables where name='BoyInfo')
drop table BoyInfo
go

create table BoyInfo(
 boyid int identity(1001,1) primary key,
 boyName varchar(20) not null,--姓名
 boySex varchar(2) not null,--性别
 boyAge int not null,--年龄
 boyHeight int not null ,--身高
 boyWeight float not null,--体重
 boyjob varchar(100),--工作
 boyjobMoney decimal(18,2) default(0) check(boyjobMoney>=0),--薪资
 boyAddress varchar(50) not null,--地址
 boyHobbly  varchar(100) ,--爱好
 boymate varchar(500) not null,--择偶标准
 boyimg varchar(max),--图片路径
 boyimg1 varchar(max),
 boyimg2 varchar(max),
)
insert into  BoyInfo values('张三','男',32,183,65,'IT企业高管','400000','上海','唱歌','上海本地，本科学历，身高160以上，五官端正','','','')
insert into  BoyInfo values('里斯','男',24,177,60,'摄影师','300000','郑州','画画','漂亮，三观一致','','','')
insert into  BoyInfo values('杨申','男',28,180,60,'开发工程师','350000','上海','唱歌','漂亮，御姐类，声音好听，孝顺，善良','','','')
insert into  BoyInfo values('卢起家','男',22,175,80,'销售经理','300000','郑州','美食','孝顺，善良，硕士以上学历，美丽，身高170左右','','','')


--girlInfo
if exists(select * from sys.tables where name='GirlInfo')
drop table GirlInfo
go

create table GirlInfo(
 girlid int identity(1001,1) primary key,
 girlName varchar(20) not null,
 girlSex varchar(2) not null,
 girlAge int not null,--年龄
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
insert into  GirlInfo values('豆豆','女',24,165,50,'策划师','100000','郑州','画画，看书，做甜品','身高175以上，帅气，幽默，温柔，体贴','','','')
insert into  GirlInfo values('小白','女',23,160,45,'设计师','100000','郑州','画画，看书，做甜品','郑州本地， 有房有车有存款','','','')
insert into  GirlInfo values('小谭','女',25,165,50,'舞蹈老师','200000','上海','旅游，看书','身高175以上，阳光 温柔，温文尔雅','','','')
insert into  GirlInfo values('王婧','女',26,168,50,'医生','400000','郑州','旅游','温柔，体贴，阳光，有房有车','','','')

--groupInfo
if exists(select * from sys.tables where name='GroupInfo')
drop table GroupInfo
go

CREATE table GroupInfo(
  groupId int identity(101,1) primary key not null,
  boyName varchar(50) not null,--男名字
  GirlName varchar(50)not null,--女名字
  lovetime datetime default(getdate()),--在一起时间
  hand bit default(0) check(hand=0 or hand=1) not null,--是否牵手成功
  SusseccTime datetime default(null),--牵手成功时间

)

insert into GroupInfo values('李四','王红',GETDATE(),default,null)
insert into GroupInfo values('李费','婉瑜',GETDATE(),default,null)
insert into GroupInfo values('晨曦','邓丹',GETDATE(),default,null)


select* from GroupInfo
select* from GirlInfo
select* from BoyInfo
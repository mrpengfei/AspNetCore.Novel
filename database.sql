
CREATE SCHEMA  if not exists `novel`;

use novel;

create table if not exists novels(
	Id int primary key auto_increment comment'主键',
    Name nvarchar(50) comment'小说名称'    
) comment'小说';

create table if not exists novelExtend(
	Id int primary key auto_increment comment'主键',
    NovelId int comment'小说Id' ,
    Url nvarchar(512) comment'小说的Url地址',
    SiteName nvarchar(512) comment'小说网站的名称',
    CatalogRegex nvarchar(512) comment'小说目录正则表达式',
    ChapterRegex nvarchar(512) comment'小说章节正则表达式'
) comment'小说扩展';

create table if not exists chapter(
	Id int primary key auto_increment comment'主键',
    NovelId int comment'小说Id',
    Name nvarchar(50) comment'章节名称',
    SerialNumber int comment'章节号',
    content text comment'小说内容' 
) comment'小说章节';
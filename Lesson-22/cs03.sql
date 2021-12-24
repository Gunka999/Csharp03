--Constraints
--not null
--unique 
--not null + unique=primary key
--check
--default

use Csharp03

create table Groups(
Id int primary key identity ,
[Name] nvarchar(50) not null unique
)
drop table Groups

create table Students(
Id int primary key identity ,
Firstname nvarchar(30) not null check(len(Firstname)>2),
Email Nvarchar(50) not null unique,
Gender nvarchar(6) check(Gender in('male','female')),
Country nvarchar(200) Default 'Azerbaijan',
GroupId INT NOT null,
Foreign key (GroupId) REFERENCES Groups(Id)
)

alter table Students
add Grade int

--Aggregation func
--Select SUM(Grade) from Students where Grade>30

--Select max(Grade) from Students where Grade>10

--Select avg(Grade) 'Avg' from Students where Grade>10 

--3cur
--one to one(unique yaz)
--one to many   (X)

create table Author(
Id int primary key identity ,
[Name] nvarchar(30)
)

create table Book(
Id int primary key identity ,
[Name] nvarchar(30),
AuthorId int not null,
Foreign key (AuthorId) references Author(Id)
)


drop table Author

--many to many 

create table Author(
Id int primary key identity ,
[Name] nvarchar(30)
)

create table Book(
Id int primary key identity ,
[Name] nvarchar(30)
)


create table AuthorToBook
(
AuthorId int not null,
Foreign key (AuthorId) references Author(Id),
BookId int not null,
Foreign key (BookId) references Book(Id)
)

select * from AuthorToBook

select Author.Name, Book.Name
from AuthorToBook 
Join Author on AuthorToBook.AuthorId=Author.Id
Join Book on AuthorToBook.BookId=Book.Id

select a.Name 'Author', b.Name 'Book'
from AuthorToBook 
Join Author as a on AuthorToBook.AuthorId=a.Id
Join Book as b on AuthorToBook.BookId=b.Id


select Students.FirstName 'Telebe', Students.Email, Groups.Name 'Group'
from  Students
Left Join Groups on Students.GroupId=Groups.Id
--SQL-Structure Query Language
--3cur 
--DML-DATA Manipulation lang -select,insert,update,delete
--DDL- data definition lang    create , alter(edit), add,drop(silmek),rename
--DCL- data control lang

--create database Csharp03

--use Csharp03

--create table Employee(
--Id int identity(100,1),
--Firstname nvarchar(25),
--Email nvarchar(50),
--Birthdate date,
--Salary decimal
--)


---insert data in table Employee
--insert into dbo.Employee (Firstname,Email,Birthdate,Salary)
--values
--('Veli', 'veli@gmail.com','1900-02-02',1500),
--('Xeyal', 'xeyal@gmail.com','1800-02-02',1800)

--select Firstname,Salary from dbo.Employee
--select *from dbo.Employee where Email like '%gmail%'
--select *from dbo.Employee where not Salary=1500
--select  TOP(2)  *from dbo.Employee

--delete from dbo.Employee where Firstname='Emin'
--delete from dbo.Employee where Id between 107 and 113

--delete dbo.Employee where Id in (106,115)

--select *from dbo.Employee order by id offset 4 rows

--Update dbo.Employee set Firstname='Minaa2',Email='minaa@gmail.com' 
--where Id=103

--Alter table dbo.Employee add City nvarchar(50)
--alter table dbo.Employee drop column Birthdate

--select * from dbo.Employee where Country='Azerbaijan' Or city='Sumqayit'
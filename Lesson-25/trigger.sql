create table Employee(
Id int identity,
[Name] nvarchar(20),
Emp_Salary decimal(10,2)
)

create table HrContactData(
EmpID int,
[Name] nvarchar(20),
Emp_Salary decimal(10,2),
AddedDate datetime
)


create trigger trgAfterInsertEmployee on
dbo.[Employee]
for insert
as
declare @empID int;
declare @emp_name nvarchar(20);
declare @empSalary decimal(10,2);
declare @addedDate datetime;
select  @empID=y.Id from inserted y
select  @emp_name=y.[Name] from inserted y
select  @empSalary=y.Emp_Salary from inserted y 

insert into HrContactData(EmpID,[Name],Emp_Salary,AddedDate)
values (@empID,@emp_name,@empSalary, getdate())

Print 'After Insert trigger '
go

insert into Employee values('vygbhujbjn',1500)
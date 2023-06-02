   create database dbWineShop
use dbWineShop

--CREATE TABLE TBlmanager

create table tblManager(
ManagerId UNIQUEIDENTIFIER PRIMARY KEY default NEWID(),
ManagerName varchar(max), 
UserName varchar(max),
UserPassword varchar(max)
,PhoneNumber varchar(max)
,AddharNo varchar(max),NickName varchar(max),HireDate varchar(max),Firedate varchar(max),salary int)

select * from tblManager 



--Create Table tblAdmin
create table tblAdmin(
AdminId UNIQUEIDENTIFIER PRIMARY KEY default NEWID(),
Name varchar(max),PhoneNumber varchar(max),
UserName varchar(max),UserPassWord varchar(max),NickName varchar(max)
)
insert into tblAdmin values(default,'sudip123','sudip@123','palash') 

select * from tblAdmin
select * from tblSubBrand


--Create Table tblBrand 
create table tblBrand(BrandId int primary key identity(1,1),BrandName varchar(max))
select * from tblBrand

   
--Create table tblSubBrand
create table tblSubBrand(
BrandId int
foreign key(BrandId)references tblBrand(BrandId),
SubBrandId int primary key identity(1,1),SubBrandName varchar(max)
) 
 

--Start of the main Sub Brand Stock Details Table Creation
create table tblSubBrandStock(
Id UNIQUEIDENTIFIER primary key default newid(),
BrandName varchar(max),
LotNumber int,
SubBrandName varchar(max),
BatchNumber varchar(max),
SubBrandWeight varchar(max),
Unitprice float,
EntryDate varchar(max),
ExpiryDate varchar(max),
)
drop table tblSubBrandStock
select * from tblSubBrandStock
--End of the main Sub Brand Stock Details Table Creation

--Create Table TblElectric

create table tblElectric(PaymentStatus varchar(max),PaymentAmount float,Amount float,MonthName varchar(max)
,Due Amount-PaymentAmount)


--Create Table tblShopRent

create table tblShopRent(PaymentStatus varchar(max),PaymentAmount float,Amount float,MonthName varchar(max))

--Create table tblTransport
create table tblTransport(PaymentStatus varchar(max),PaymentAmount float,Amount float,TransportDate date)

--Create table tblOtherExpense









--SpAdminLogin Procedure contains the value userId and Password
 
alter procedure spAdminLogin 
@UserName varchar(max),
@password varchar(max)
 as 
 begin
 select * from tblAdmin where UserName=@UserName and UserPassword=@Password 
 end
 
 --Get Admin UserName
 
 create proc spAdminUserName
 @NickName varchar(max)
 as
 begin
 select * from tblAdmin where NickName=@NickName
 end
---Procedure for check Admin nickname after Forgot Manager Password
create procedure spAdminForgotPassword
@NickName varchar(max)
as
begin 
select * from tblAdmin where NickName=@NickName
end

select * from tblAdmin

--Procedure for set Admin's new password
alter proc spSetNewAdminPassword
@AdminPassWord varchar(max),
@NickName varchar(max)

as
begin
update tblAdmin set UserPassword=@AdminPassWord where NickName=@NickName
end 
 
--spRegister for Register Manager

alter procedure spRegisterManager
@Name varchar(max),
 @UserName varchar(max),
 @UserPassword varchar(max),
 @PhoneNumber varchar(max),@AddharNo varchar(max),
 @NickName varchar(max),@HireDate varchar(max),@Salary int
 as
 begin
 insert into tblManager(ManagerName,UserName ,UserPassword,AddharNo,PhoneNumber,NickName,HireDate,salary)   
 values (@Name,@UserName,@UserPassword,@AddharNo,@PhoneNumber,@NickName,@HireDate,@Salary)
end

--Create Procedure For Manager Login

alter proc spManagerLogin
@UserName varchar(max),
@UserPassword varchar(max)
as
begin
select * from tblManager where UserName=@UserName and UserPassword=@UserPassword
end


---Procedure for check nickname after Forgot Manager Password
alter procedure spManagerForgotPassword
@NickName varchar(max)
as
begin 
select * from tblManager where NickName=@NickName
end

--Procedure For Getting Manager UserName
create proc spGetManagerUserName
@NickName varchar(max)
as
begin
select * from tblManager Where NickName=@NickName
end


select * from tblManager

--Procedure for set new password
alter proc spSetNewManagerPassword
@ManagerPassWord varchar(max),
@NickName varchar(max)
as
begin
update tblManager set UserPassword=@ManagerPassWord where NickName=@NickName
end 
select * from tblAdmin

--Procedure For Get Manager Details

alter proc spGetManagerDetails 
as
begin
select ManagerId,ManagerName,PhoneNumber,AddharNo,HireDate,FireDate,Salary from tblManager
end

select * from tblManager

---Procedure for Fire Manager
 
alter procedure spDeleteManager
@ManagerId varchar(max)
as 
begin
delete  from tblManager where ManagerId=@ManagerId
end

create proc spUpdateManager
@ManagerId varchar(max),
@ManagerName varchar(max),
@PhoneNumber varchar(max),
@AddharNo varchar(max),
@HireDate varchar(max),
@FireDate varchar(max),
@salary int
as
begin
update tblManager set ManagerName=@ManagerName,PhoneNumber=@PhoneNumber,AddharNo=@AddharNo,HireDate=@HireDate,
FireDate=@FireDate,Salary=@Salary where ManagerId=@ManagerId
end

drop procedure spDeleteManagerForm

select * from tblManager


--For Geting SubBrand From Brand

alter procedure spGetSubBrand
@BrandId int
as 
begin
select * from tblSubBrand where BrandId=@BrandId
end

execute spGetSubBrand @BrandId = 1


--Procedure to Get BrandId by BrandName 

alter procedure spGetBrandId
@BrandName varchar(max)
as 
begin
select BrandId from tblBrand where BrandName=@BrandName
end


--Start of the Stored Procedure to Insert data to main Table
use dbWineShop
select * from tblBrand
select * from tblSubBrand

alter procedure spGetSubBrandStock  
@BrandName varchar(max),
@LotNumber int,
@SubBrandName varchar(max),
@BatchNo varchar(max),		
@SubBrandWeight varchar(max),
@Unitprice float,
@EntryDate varchar(max),
@ExpiryDate varchar(max),
@Quantity int,              
@AmountStatus varchar(max),
@DueAmount float,
@DealerName varchar(max)
as
begin
declare @B varchar(max)
declare @inc int
set @inc = 1                  
declare @count int    
set @count = 0                 
while(@count < @Quantity)
begin
set @B = @BatchNo + CAST(@inc as varchar(10))
insert into tblSubBrandStock values(
default,
@BrandName,
@LotNumber,
@SubBrandName,
@B,
@SubBrandWeight,		
@Unitprice,
@EntryDate,
@ExpiryDate,
@DealerName
)
set @count = @count + 1    
set @inc = @inc + 1
end
insert into tblTransaction values (DEFAULT,
@BrandName,
@SubBrandName,
@Quantity,
@SubBrandWeight,
@UnitPrice,
@AmountStatus,
@DueAmount,
@DealerName,
@EntryDate
)
end



select * from tblSubBrandStock
select * from tblTransaction 
delete from tblSubBrandStock



alter proc spGetLastLotNoOfSelectedBrand 
@SubBrandName varchar(max),
@Weight varchar(max)
as
begin 
select MAX(LotNumber) from tblSubBrandStock where SubBrandName = @SubBrandName and SubBrandWeight = @Weight
end


alter proc spGetSubBrandDataInSortedOrder
as
begin
select * from tblSubBrandStock order by BatchNumber;
end

select * from tblTransaction

--End of the Stored Procedure to Insert data to main Table
 
 select * from tblSubBrandStock

--Procedure for delete columns
 
alter proc spdeleteSubBrandStock 
 @BatchNo varchar(max)
 as
 begin
 delete from tblSubBrandStock where BatchNumber = @BatchNo
 end
 
 
 --Procedure For Update Table Details in Sualter proc spupdateSubBrandStock
 alter proc spUpdateSubBrandStock
 @BrandName varchar(max),
@LotNumber varchar(max),
@SubBrandName varchar(max),
@BatchNo varchar(max),
@SubBrandWeight varchar(max),
@Unitprice float,
@EntryDate varchar(max),
@ExpiryDate varchar(max)
as
begin

update tblSubBrandStock set 
BrandName=@BrandName,
LotNumber=@LotNumber,

SubBrandName=@SubBrandName,
SubBrandWeight=@SubBrandWeight,
Unitprice=@Unitprice,
EntryDate=@EntryDate,
ExpiryDate=@ExpiryDate
  where BatchNumber=@BatchNO
 end
select * from tblSubBrandStock
 

 select * from tblSubBrandStock
 
 --Procedure for Searching Stock By BrandName
 
 alter procedure spSearchByBrand  
 @BrandName varchar(max)
 as
 begin
 select * from tblSubBrandStock where BrandName=@BrandName order by BatchNumber;
 end
 
 --Procedure for search by SubBrand
 
 alter procedure spSearchBySubBrand 
 @SubBrandName varchar(max)
 as
 begin
 select * from tblSubBrandStock where SubBrandName=@SubBrandName order by BatchNumber;
 end
 
 select * from tblSubBrandStock
 
--Searching By Weight 
 alter proc spSearchByBrandAndWeight
 @BrandName varchar(max),
 @Weight varchar(max)
 as 
 begin
	select * from tblSubBrandStock where BrandName = @BrandName and SubBrandWeight = @Weight 
	order by BatchNumber;
 end
 
 --Searching By SubBrand Name And Weight
 
 alter proc spSearchBySubBrandAndWeight
 @SubBrandName varchar(max),
 @Weight varchar(max)
 as 
 begin
	select * from tblSubBrandStock where SubBrandName = @SubBrandName and SubBrandWeight = @Weight
	order by BatchNumber;
 end
 

 --Searching Stock By Price
 
 alter proc spSearchByPrice 
 @LowestUnitPrice float,
 @HighestUnitPrice float
 as
 begin
	select * from tblSubBrandStock where Unitprice between @LowestUnitPrice and @HighestUnitPrice
	order by BatchNumber;
 end
 
 --Searching Stock By Weight
 
 alter proc spSearchByWeight
 @Weight varchar(max)
 as
 begin
	select * from tblSubBrandStock where SubBrandWeight = @Weight
	order by BatchNumber;
 end
--Search Stock By Brand And Price
 
alter proc spSearchByBrandAndPrice 
 @BrandName varchar(max),
 @LowestUnitPrice float,
 @HighestUnitPrice float
 as
 begin
	select * from tblSubBrandStock where BrandName = @BrandName and Unitprice between
	 @LowestUnitPrice and @HighestUnitPrice
	 order by BatchNumber;
 end
 
 --Search By SubBrand And Price
 
  alter proc spSearchBySubBrandAndPrice 
 @SubBrandName varchar(max),
 @LowestUnitPrice float,
 @HighestUnitPrice float
 as
 begin
	select * from tblSubBrandStock where SubBrandName = @SubBrandName and Unitprice 
	between @LowestUnitPrice and @HighestUnitPrice
	order by BatchNumber;
 end

 
alter procedure spAdminLogin
 @UserId varchar(50),
 @Password varchar(50)
 
 as 
 begin
 select * from tblLogin where UserId=@UserId and User_Password=@Password and Ph_Number=7318986219
 end
 
alter procedure spSearchBySubBrand 
 @SubBrandName varchar(max)
 as
 begin
 select * from tblSubBrandStock where SubBrandName=@SubBrandName
 end
 
 use dbWineShop
  
  
  --GUID
  
 create table tblGuidTest
 (
 Eid GUID primary key, 
 name varchar(max)
 )
create table AspNetUsers
(
Id UNIQUEIDENTIFIER PRIMARY KEY default NEWID(),
Name n varchar(200)
)
 
 INSERT INTO AspNetUsers VALUES (default,'Shane')
INSERT INTO AspNetUsers VALUES (default,'Jonny')
 
 select * from AspNetUsers
 
 select * from tblBrand
  select * from tblBrandStock
   select * from tblImportandExport
   select * from tblSubBrand
   select * from tblSubBrandOfStock 
  select * from tblSubBrandStock  
  select * from tblWeight
 
 select * from tblManager
 
 
 ALTER TABLE tblBrand ALTER COLUMN BrandId uniqueidentifier default NEWID(); 
 
 delete from tblManager where ManagerName='sdhgdfs' 
 

<-- Creating The Table For Store All The Transaction Day by Day
create table tblTransaction(TransectionId UNIQUEIDENTIFIER PRIMARY KEY default newid(),
BrandName varchar(max), SubBrandName varchar(max),Quantity int, 
SubBrandWeight varchar(max), UnitPrice float,
TransactionAmount as UnitPrice * Quantity, PaymentStatus varchar(max),
DueAmount float,
DealerName varchar(max), TransactionDate varchar(max))
drop table tblTransaction
select * from tblTransaction



insert into tblTransaction (BrandName,SubBrandName,SubBrandWeight,UnitPrice,
DealerName,TransactionDate)
select BrandName,SubBrandName,SubBrandWeight,UnitPrice,
Dealer,EntryDate from tblSubBrandStock

<-- Ending of Transaction Table  
<--------------------------------------------------------------------------------------------------------------->


<--------------------------------------------------------------------------------------------------------------->
<-- Creating The Table For Storing Electric Expenses Month by Month
 
create table tblElectric(ElecticId UNIQUEIDENTIFIER PRIMARY KEY default newid(),
ExpensePaidMonth varchar(max), Amount float,
PaidAmount float, PaymentDate varchar(max),
PaymentStatus varchar(max), DueAmount float,PaidTo varchar(max))

<-- Creating The Stored Procedure of Inserting Data of Eletric Expenses
alter proc spInsertTotblElectric
@ExpensePaidMonth varchar(max),
@Amount float,
@PaidAmount float,
@PaymentDate varchar(max),
@PaymentStatus varchar(max),
@DueAmount float,
@PaidTo varchar(max)
as
begin
	insert into tblElectric values(default, @ExpensePaidMonth, @Amount, @PaidAmount,
									@PaymentDate, @PaymentStatus,@DueAmount,@PaidTo)
end

<-- Creating The Stored Procedure of Getting Data of Eletric Expenses
create proc spGetDetailsOfElectricExpenses
as
begin
	select * from tblElectric
end

--Procedure For Clear Due Amount
alter proc spUpdateDueAmount
@DueAmount float,
@ElectricId varchar(max)
as
begin
Update tblElectric set DueAmount=@DueAmount Where ElecticId=@ElectricId
end


select * from tblElectric
<-- Ending of Electric Table
<--------------------------------------------------------------------------------------------------------------->

use dbWineShop
<--------------------------------------------------------------------------------------------------------------->
<-- Creating The Table For Storing Shop Rent Expenses Month by Month

create table tblShopRent(ShopRentId UNIQUEIDENTIFIER PRIMARY KEY default newid(),
RentPaidMonth varchar(max), Amount float,
PaidAmount float, PaymentDate varchar(max), 
PaymentStatus varchar(max), DueAmount float,PaidTo varchar(max))

<-- Creating The Stored Procedure of Inserting Data of Shop Rent Expenses
alter proc spInsertTotblShopRent
@RentPaidMonth varchar(max),
@Amount float,
@PaidAmount float,
@PaymentDate varchar(max), 
@PaymentStatus varchar(max),
@DueAmount float,
@PaymentTo varchar(max)
as
begin
	insert into tblShopRent values(default, @RentPaidMonth, @Amount, @PaidAmount,
									@PaymentDate, @PaymentStatus,@DueAmount,@PaymentTo)
end

<-- Creating The Stored Procedure of Getting Data of Shop Rent Expenses
create proc spGetDetailsOfShopRentExpenses
as
begin
	select * from tblShopRent
end

--Creating the StoreProcedure For Update Table Details
alter proc spUpdateDetailsOfShopRentExpenses

@PaidAmount float,
@PaymentDate varchar(max), 
@PaymentStatus varchar(max),
@DueAmount float,
@Id varchar(max)
as
begin
update tblShopRent set PaidAmount=@PaidAmount,
PaymentDate=@PaymentDate,PaymentStatus=@PaymentStatus,DueAmount=@DueAmount where ShopRentId=@Id
end


<-- Ending of Shop Rent Expenses Table
<--------------------------------------------------------------------------------------------------------------->


<--------------------------------------------------------------------------------------------------------------->
<-- Creating The Table For Storing Transport Expenses Day by Day

create table tblTransport(TransportId UNIQUEIDENTIFIER PRIMARY KEY default newid(),
TransportDate varchar(max), Amount float,
PaidAmount float, PaymentDate varchar(max),
PaymentStatus varchar(max), DueAmount float,PaidTo varchar(max))

select * from tblTransport

-- Creating The Stored Procedure To Insert Data To tblTransport
alter proc spInsertDetailsOfTransport
@TransportDate varchar(max),
@Amount float,
@PaymentAmount float,
@PaymentDate varchar(max),
@PaymentStatus varchar(max),
@DueAmount float,
@PaymentTo varchar(max)
as
begin
	insert into tblTransport values(default, @TransportDate, @Amount, @PaymentAmount,
	 @PaymentDate,@PaymentStatus,@DueAmount,@PaymentTo)
end	
 

<-- Creating The Stored Procedure To Give The All Details From tblTransport
alter proc spGetDetailsOfTransport
as
begin
	select * from tblTransport
end

--Create The Store Procedure To Update Transport Table Details
alter proc spUpdateDetailsOfTransport
@PaymentAmount float,
@PaymentDate varchar(max),
@PaymentStatus varchar(max),
@DueAmount float,
@Id varchar(max)
as
begin
update tblTransport set 
PaidAmount=@PaymentAmount,
PaymentDate=@PaymentDate,
PaymentStatus=@PaymentStatus,
DueAmount=@DueAmount where TransportId=@Id
end

<-- Ending of Tranport Expenses Table
<--------------------------------------------------------------------------------------------------------------->
select * from tblTransaction

<--------------------------------------------------------------------------------------------------------------->
<-- Creating The Table of Total Extra Expense
create table tblOtherExpenses (TotalElectric float, TotalShopRent float,
								TotalTransport  float,
								TotalExpense as (TotalElectric + TotalShopRent + TotalTransport),
								NameOfMonth varchar(max))
drop table tblOtherExpenses						
<--Creating The Sored Procedure to Insert To Total Other Expenses
alter proc spInsertIntoTotalOtherExpenses 
as

begin
	declare @electricAmt float
	select @electricAmt = SUM(Amount) from tblElectric 
    print(@electricAmt)
	declare @shopAmt float
	select @shopAmt = SUM(Amount) from tblShopRent 
	print(@shopAmt)
	
	
	declare @transportAmt float
	select @transportAmt = SUM(Amount) from tblTransport
	print(@transportAmt)
    
	insert into tblOtherExpenses(TotalElectric,TotalShopRent,TotalTransport,NameOfMonth) 
	values(400,400,400,'December') 
	

end
if(@electricAmt is not NULL and @shopAmt is not NULL and @transportAmt is not NULL )
    begin
    end
select * from tblWeight
declare @Taka int
select @Taka=SUM(Amount)  from tblTransport
print(@Taka)
--------------------------------------------------------------------------------------------------------------->
--use dbWineShop
select * from tblOtherExpenses

select * from tblShopRent

select * from tblElectric
select * from tblTransport

select SUM(Amount) from tblTransport
declare @count int
set @count = 0
while @count < 10
begin
	print @count
	set @count = @count + 1
end


alter proc spCheck 
@c int
as
begin
	declare @count int
	set @count = 1
	while @count < @c
	begin
		print @count
		set @count = @count + 1
	end
end



--Other Expenses

create table tblOtherExpenses(ExpenseSubject varchar(max),
ExpenseDate varchar(max),Amount float)


--Create Procedure For Getting Expense Transition
create proc spGetOtherExpenses 
@StartingDate varchar(max),
@EndingDate varchar(max)
as
begin
select * from tblOtherExpenses Where ExpenseDate between @StartingDate and @EndingDate
end

select * from tblAdmin

select * from tblManager

sp_helptext spGetNameBySearchEngine

CREATE proc spGetNameBySearchEngine   
@Insert varchar(max)  
as  
begin  
 select * from tblBrandTable where Name like @Insert + '%';  
end

--Procedure For Set New Brand
alter proc spInsertNewBrand 
@BrandName varchar(max)
 as 
 begin 
 insert into tblBrand (BrandName) values (@BrandName) 
 end
 
 --Insert SubBrand By BrandId
 create proc spInsertSubBrand
 @Id int,
 @SubBrand varchar(max)
 as
 begin
 insert into tblSubBrand (BrandId,SubBrandName)values(@Id,@SubBrand)
 end
 
 --Insert New Weight
 create proc spInsertWeight
 @Weight varchar(max)
 as
 begin
 insert into tblWeight (Weight) values (@Weight)
 end
 
 
 
 
 ------------------Search For  Brand ------------
create proc spSearchData
@item varchar(max)
as
begin 
   select BrandName from tblBrand where BrandName like @item+'%'
end


sp_helptext spInsertNewBrand

select * from tblWeight
select * from tblSubBrandStock
select * from tblAdmin
delete from tblSubBrand where BrandId=7

update tblAdmin set UserName=1 , UserPassWord=1



--create table Other Expense
create table tblOtherExpense(ExpenseId UNIQUEIDENTIFIER PRIMARY KEY default newid(),
Expense_Name varchar(max),Expense_Amount float,Expense_Date varchar(max),Due_Amount float
,Payment_Status varchar(max),Payment_Date varchar(max))


sp_helptext spGetSubBrandDataInSortedOrder

alter proc spGetSubBrandDataInSortedOrder  
as  
begin  
select * from tblSubBrandStock order by BatchNumber;  
end  

select * from tblWeight

--Procedure for search ShopRent Payment Data to Date
create proc spSearchShopRentDateToDate '2021/11/6','2021/12/10'
@From varchar(max),
@To varchar(max)
as
begin
select * from tblShopRent where PaymentDate between @From and @To
end

------------ Procedure For Get Available Brand----------------------
alter proc spGetAvailibityOfBrand 
@BrandName varchar(max)
as
begin
	if(Exists(select BrandId from tblBrand where BrandName = @BrandName))
	begin
	    select 1 as DataFound
	end
	else  
	begin
		select 0 as DataFound
	end
	
end
--Get All Transaction from Transaction Table
alter proc spGetAllTransition
as
begin
select TransectionId,BrandName,SubBrandName,TransactionAmount,PaymentStatus,DueAmount,DealerName,TransactionDate from tblTransaction
end

--Update TransactionStatus
alter proc spUpdateAllTransition
@PaymentStatus varchar(max),
@DueAmount varchar(max),
@TransactionId varchar(max),
@PaymentDate varchar(max)
as
begin
update tblTransaction set PaymentStatus=@PaymentStatus,DueAmount=@DueAmount,TransactionDate=@PaymentDate where TransectionId=@TransactionId
end

select * from tblTransaction

--Procedure For Search Shoprent Details By Date

create proc spSearchShopRentByMonth 
@From varchar(max),
@To varchar(max)
as
begin
select * from tblShopRent where RentPaidMonth between @From and @To
end


select * from dbo.tblOtherExpense
--Procedure For Insert Other Expenses In OtherExpenses Table
alter proc spInsertOtherExpenses
@ExpenseName varchar(max),
@ExpenseAmount varchar(max),
@DueAmount varchar(max),
@PaymentStatus varchar(max),
@PaymentDate varchar(max),
@ExpenseDate varchar(max)
as
begin
insert into tblOtherExpense(Expense_Name,Expense_Amount,Expense_Date,Due_Amount,Payment_Status,Payment_Date)values
(@ExpenseName,@ExpenseAmount,@ExpenseDate,@DueAmount,@PaymentStatus,@PaymentDate)
end

--Procedure for Get OtherExpenses Data
alter proc spGetDataFromOtherExpenses
as
begin
select * from tblOtherExpense
end

--Procedure For Pay Other Expenses Due Amount
alter proc spUpdateOtherExpenseDetails
@ExpenseId varchar(max),
@DueAmount float,
@Status varchar(max),
@PaymentDate date
as
begin
update tblOtherExpense set Due_Amount=@DueAmount,
Payment_Status=@Status,Payment_Date=@PaymentDate where ExpenseId=@ExpenseId
end

--create proc to Search Transport Date By Date
alter proc spSearchTransport 
@From varchar(max),
@To varchar(max)
as
begin
select * from tblTransport where TransportDate between @From and @To
end

--create proc to Search Transaction Date By Date
alter proc spSearchTransaction
@From varchar(max),
@To varchar(max)
as
begin
select TransectionId,BrandName,SubBrandName,TransactionAmount,PaymentStatus,DueAmount,DealerName,TransactionDate from tblTransaction where TransactionDate between @From and @To
end

select * from tblElectric
select * from tblShopRent

--Procedure For Search Electric Expense

create proc spSearchElectric
@From varchar(max),
@To varchar(max)
as
begin
select * from tblElectric where ExpensePaidMonth between @From and @To
end

--Procdure For Search Other Expenses Details
alter proc spSearchOtherExpenses 
@From varchar(max),
@To varchar(max)
as
begin
select * from tblOtherExpense where Expense_Date between @From and @To
end



--Proc for Update Admin Details
alter proc spUpdateAdminDetails
@Name varchar(max),
@PhoneNumber varchar(max),
@UserName varchar(max),
@UserPassword varchar(max),
@NickName varchar(max),
@AdminId varchar(max)
as
begin
update  tblAdmin set Name=@Name,PhoneNumber=@PhoneNumber,UserName=@UserName,
UserPassWord=@UserPassword,NickName=@NickName where AdminId=@AdminId
end

select * from tblShopRent






CREATE PROCEDURE Updatemember 
@MId int,
@MName nvarchar(50),
@MPhone varchar(50),
@MGender nvarchar(50),
@MAge int,
@MPlan nvarchar(50),
@TId int
AS
BEGIN
UPDATE member
SET MName=@MName,
MPhone=@MPhone,
MGender=@MGender,
MAge=@MAge,
MPlan=@MPlan,
TId=@TId
WHERE MId=@MId
 End
 
 
 
CREATE PROCEDURE Insertmember 

@MName nvarchar(50),
@MPhone varchar(50),
@MGender nvarchar(50),
@MAge int,
@MPlan nvarchar(50),
@TId int
AS

insert into member(MName,MPhone,MGender,MAge,MPlan,TId)
VALUES (@MName,@MPhone, @MGender,@MAge, @MPlan, @TId)
 
 Create Procedure Deletememebr
 @MID int 
 as  
 Delete From member where MId = @MID



 Create Procedure Deletetrainer
 @TID int 
 as  
 Delete From trainers where TId = @TID
 



 Create Procedure Updatetrainer 
 @TId int,
@TName nvarchar(50),
@TPhone varchar(50),
@TAge int,
@TSalary money
AS
BEGIN
UPDATE trainers
SET TName=@TName,
TPhone=@TPhone,
TAge=@TAge,
TSalary=@TSalary
WHERE TId=@TId
 End



 CREATE PROCEDURE Inserttrainer
@TName nvarchar(50),
@TPhone varchar(50),
@TAge int,
@TSalary money
AS

insert into trainers (TName,TPhone,TAge,TSalary)
Values (@TName,@TPhone,@TAge,@TSalary)






CREATE PROCEDURE Insertpayment
@PAmount money,
@PDate date,
@MId int 
AS

insert into payment(PAmount ,PDate,MId)
Values (@PAmount ,@PDate,@MId)



create procedure SearchByName
@MName nvarchar(50)
as 
begin 
select* from member
where MName=@MName
END

create procedure GetAllMembers
AS
SELECT* FROM member

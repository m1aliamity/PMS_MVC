USE [IBCM]
GO
/****** Object:  StoredProcedure [dbo].[SP_LabStaff]    Script Date: 23-10-2020 15:22:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_LabStaff] (
	@Id BIGINT =0,
	@Title bigint=0,
	@FirstName VARCHAR(50)='', 
	@LastName VARCHAR(50)='', 
	@MobileNo int='', 
	@EmailId VARCHAR(50)='', 
	@Gander int, 
	@Religion int, 
	@MritalStatus int, 
	@SpauseName VARCHAR(50)='', 
	@DateOfBirth DateTime, 
	@AnniversaryDate DateTime, 
	@StaffType int, 
	@Address VARCHAR(500)='', 
	@CID int, 
	@UserId bigint,
	@Action VARCHAR(3)=''
	)
AS
BEGIN
	IF (@Action = 'I')
	BEGIN
		INSERT INTO tbl_LabStaff (
		Title,
			FirstName, 
	LastName, 
	MobileNo, 
	EmailId, 
	Gander, 
	Religion, 
	MritalStatus, 
	SpauseName, 
	DateOfBirth, 
	AnniversaryDate, 
	StaffType, 
	Address,
	CreatedDate,
	CreatedBy, 
	CID, 
	UserId
			)
		VALUES (
		@Title,
			@FirstName, 
	@LastName , 
	@MobileNo , 
	@EmailId , 
	@Gander, 
	@Religion, 
	@MritalStatus, 
	@SpauseName, 
	@DateOfBirth, 
	@AnniversaryDate, 
	@StaffType , 
	@Address,
	GETDATE(),
	@UserId,
	@CID , 
	@UserId
			)
	END
	ELSE IF (@Action = 'U')
	BEGIN
		UPDATE tbl_LabStaff
		SET Title=@Title,FirstName=@FirstName, 
	LastName=@LastName, 
	MobileNo=@MobileNo, 
	EmailId=@EmailId, 
	Gander=@Gander, 
	Religion=@Religion, 
	MritalStatus=@MritalStatus, 
	SpauseName=@SpauseName, 
	DateOfBirth=@DateOfBirth, 
	AnniversaryDate=@AnniversaryDate, 
	StaffType=@StaffType, 
	Address=@Address,
	LastModifiedDate=GETDATE(),
	ModifiedBy=@UserId, 
	CID=@CID, 
	UserId=@UserId
		WHERE Id = @Id
	END
	ELSE IF (@Action = 'E')
	BEGIN
		SELECT *
		FROM tbl_LabStaff
		WHERE Id = @Id
	END
	
	ELSE IF (@Action = 'D')
	BEGIN
		DELETE
		FROM tbl_LabStaff
		WHERE Id = @Id
	END
	SELECT *
		FROM tbl_LabStaff order by Id desc
END

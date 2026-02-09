USE [DVLD2]
GO

INSERT INTO [dbo].[Users]
           ([PersonID],[UserName],[Password],[IsActive])
     VALUES 
	       (1,admin,admin,1)

INSERT INTO [dbo].[People]
           ([NationalNo],[FirstName],[SecondName],[LastName],[DateOfBirth],[Gendor],[Address],[Phone],[Email],[NationalityCountryID])
     VALUES
           ('n1','Ahmad','Mohammad','Ali','1990-01-02',0,'Syria','99283872389','ahmad2@gmail.com',169)
GO



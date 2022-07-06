USE [EcommerceDB]
GO

INSERT INTO [dbo].[TblLogin]
           ([UserName]
           ,[Password]
           ,[IsAdmin])
     VALUES
           (<UserName, varchar(50),>
           ,<Password, varchar(50),>
           ,<IsAdmin, int,>)
GO

insert into TblLogin values('sita','sita',null);
select * from TblLogin;
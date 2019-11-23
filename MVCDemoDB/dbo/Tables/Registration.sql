CREATE TABLE [dbo].[Registration]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    
    [Subject] NVARCHAR(50) NOT NULL, 
    [PhoneNum] INT NOT NULL, 
  
)

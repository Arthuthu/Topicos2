﻿CREATE TABLE [dbo].[Alunos]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [FirstName] NVARCHAR(100) NOT NULL, 
    [LastName] NVARCHAR(100) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [PhoneNumber] NVARCHAR(100) NOT NULL
)

﻿CREATE TABLE [dbo].[Footwear]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[Stock] INT NOT NULL,
	[Price] FLOAT,
	[Size] NVARCHAR(20),
	[Brand] NVARCHAR(50),
)

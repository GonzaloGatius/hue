CREATE TABLE [dbo].[Accesories]
	(
		[Id] INT NOT NULL PRIMARY KEY IDENTITY,
		[Name] NVARCHAR(50) NOT NULL,
		[Stock] INT NOT NULL,
		[Price] FLOAT,
	)

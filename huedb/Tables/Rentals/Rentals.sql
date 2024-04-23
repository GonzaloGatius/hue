CREATE TABLE [dbo].[Rentals]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[UserId] INT NOT NULL,
	[InitialDate] DATE,
	[EndDate] DATE,
)

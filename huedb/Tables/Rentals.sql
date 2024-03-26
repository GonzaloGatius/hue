CREATE TABLE [dbo].[Rentals]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[UserId] INT NOT NULL,
	[Date] DATETIME2 ,
	[AccId] INT,
	[BodyId] INT,
	[FootwearId] INT,
	[Quantity] INT,
	FOREIGN KEY (UserId) references Users(Id) on delete set null,
)

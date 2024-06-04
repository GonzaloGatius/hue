CREATE TABLE [dbo].[RentalCarts]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[RentalId] INT NOT NULL FOREIGN KEY REFERENCES Rentals(Id),
	[ProductTypeId] INT NOT NULL FOREIGN KEY REFERENCES ProductTypes(Id),
	[ProductId] INT,
	[Quantity] INT NOT NULL
)

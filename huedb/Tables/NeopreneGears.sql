CREATE TABLE [dbo].[NeopreneGears]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[InternNumber] INT NOT NULL,
    [Name] NVARCHAR(50)  NOT NULL,
    [Stock] INT  NOT NULL,
    [Price] INT NOT NULL,
    [SizeId] INT NOT NULL FOREIGN KEY REFERENCES Sizes(Id),
    [BrandId] INT NOT NULL FOREIGN KEY REFERENCES Brands(Id),
    [ColorId] INT FOREIGN KEY REFERENCES Colors(Id),
    [ConditionId] INT,
    [StateId] INT NOT NULL FOREIGN KEY REFERENCES States(Id),
    [Acquired] DATETIME2,
    [Notes] NVARCHAR(2000)
)

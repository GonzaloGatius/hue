CREATE TABLE [dbo].[Masks]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [InternNumber] INT NOT NULL,
    [BrandId] INT NOT NULL FOREIGN KEY REFERENCES Brands(Id),
    [Model] NVARCHAR(100),
    [SizeId] INT NOT NULL FOREIGN KEY REFERENCES Sizes(Id),
    [Acquired] DATE,
    [Condition] INT NOT NULL,
    [StateId] INT NOT NULL FOREIGN KEY REFERENCES States(Id),
    [ColorId] INT NOT NULL FOREIGN KEY REFERENCES Colors(Id),
    [Price] INT NOT NULL,
    [Notes] NVARCHAR(2000)
);
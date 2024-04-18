CREATE TABLE [dbo].[Hoods]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [InternNumber] INT NOT NULL ,
    [Name] NVARCHAR(50) NOT NULL,
    [Stock] INT NOT NULL,
    [SizeId] INT NOT NULL FOREIGN KEY REFERENCES Sizes(Id),
    [BrandId] INT  NOT NULL FOREIGN KEY REFERENCES Brands(Id),
    [Color] INT  NOT NULL FOREIGN KEY REFERENCES Colors(Id),
    [Acquired] DATE,
    [Condition] INT NOT NULL ,
    [StateId] INT NOT NULL FOREIGN KEY REFERENCES States(Id),
    [Price] INT NOT NULL,
    [Notes] NVARCHAR(2000),
    )
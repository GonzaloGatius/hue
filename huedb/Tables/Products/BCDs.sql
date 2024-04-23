CREATE TABLE [dbo].[BCDs]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [InternNumber] INT NOT NULL,
    [BrandId] INT NOT NULL FOREIGN KEY REFERENCES Brands(Id),
    [Model] NVARCHAR(50),
    [SizeId] INT FOREIGN KEY REFERENCES Sizes(Id),
    [Valves] NVARCHAR(50),
    [Power] NVARCHAR(50),
    [Acquired] DATE,
    [Condition] Int,
    [State] INT  NOT NULL FOREIGN KEY REFERENCES States(Id),
    [Price] INT NOT NULL,
    [Notes] NVARCHAR(2000)
    )
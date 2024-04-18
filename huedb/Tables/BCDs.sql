CREATE TABLE [dbo].[BCDs]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [InternNumber] INT NOT NULL,
    [BrandId] INT NOT NULL FOREIGN KEY REFERENCES Brands(Id),
    [Model] NVARCHAR(100),
    [SizeId] INT FOREIGN KEY REFERENCES Sizes(Id),
    [Valves] NVARCHAR(100),
    [Power] NVARCHAR(100),
    [Acquired] DATE,
    [Condition] Int,
    [State] INT  NOT NULL FOREIGN KEY REFERENCES States(Id),
    [Price] INT NOT NULL,
    [Notes] NVARCHAR(2000)
    )
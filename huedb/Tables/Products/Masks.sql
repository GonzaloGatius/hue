CREATE TABLE [dbo].[Masks]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [InternNumber] INT NOT NULL,
    [Brand] NVARCHAR(50),
    [Model] NVARCHAR(100),
    [SizeId] INT  NOT NULL FOREIGN KEY REFERENCES Sizes(Id),
    [Acquired] DATE,
    [Condition] NVARCHAR(100),
    [StateId] INT NOT NULL FOREIGN KEY REFERENCES States(Id),
    [Color] NVARCHAR(50),
    [Price] INT NOT NULL,
    [Notes] NVARCHAR(2000)
);
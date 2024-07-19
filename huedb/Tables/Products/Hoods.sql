CREATE TABLE [dbo].[Hoods]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [InternNumber] INT NOT NULL ,
    [Stock] INT NOT NULL,
    [Size] NVARCHAR(50),
    [Brand] NVARCHAR(50),
    [Color] NVARCHAR(50),
    [Acquired] DATE,
    [Condition] NVARCHAR(100),
    [StateId] INT NOT NULL FOREIGN KEY REFERENCES States(Id),
    [Price] INT NOT NULL,
    [Notes] NVARCHAR(2000),
    )
CREATE TABLE [dbo].[BCDs]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [InternNumber] INT NOT NULL,
    [Brand] NVARCHAR(50),
    [Model] NVARCHAR(100),
    [Size] NVARCHAR(50),
    [Valves] NVARCHAR(50),
    [Power] NVARCHAR(50),
    [Acquired] DATE,
    [Condition] NVARCHAR(100),
    [StateId] INT  NOT NULL FOREIGN KEY REFERENCES States(Id),
    [Price] INT NOT NULL,
    [Notes] NVARCHAR(2000)
    )
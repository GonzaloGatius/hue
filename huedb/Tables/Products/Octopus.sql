CREATE TABLE [dbo].[Octopus]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [InternNumber] INT NOT NULL ,
    [Brand] NVARCHAR(50),
    [Model] NVARCHAR(100),
    [Acquired] DATE,
    [SerialNumber] INT,
    [Condition] NVARCHAR(100),
    [StateId] INT NOT NULL FOREIGN KEY REFERENCES States(Id),
    [Price] INT NOT NULL,
    [Composition] NVARCHAR(2000),
    [Notes] NVARCHAR(2000),
    )
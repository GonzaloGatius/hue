CREATE TABLE [dbo].[Weights]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL,
    [TypeId] INT NOT NULL FOREIGN KEY REFERENCES WeightTypes(Id),
    [Stock] INT NOT NULL,
    [Weight] INT NOT NULL,
    [Price] INT NOT NULL,
    )
CREATE TABLE [dbo].[Octopus]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [InternNumber] INT NOT NULL ,
    [BrandId] INT  NOT NULL FOREIGN KEY REFERENCES Brands(Id),
    [Model] NVARCHAR(50),
    [Acquired] DATE,
    [System] NVARCHAR(50),
    [SerialNumber] INT,
    [Condition] INT NOT NULL ,
    [PartId] INT NOT NULL  FOREIGN KEY REFERENCES OctopusParts(Id),
    [StateId] INT NOT NULL FOREIGN KEY REFERENCES States(Id),
    [Price] INT NOT NULL,
    [Notes] NVARCHAR(2000),
    )
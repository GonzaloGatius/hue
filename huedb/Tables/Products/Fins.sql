﻿CREATE TABLE [dbo].[Fins]
(
    [Id] INT NOT NULL PRIMARY KEY,
    [InternNumber] INT NOT NULL,
    [Brand] NVARCHAR(50),
    [Model] NVARCHAR(100),
    [Color] NVARCHAR(50),
    [SizeId] INT  NOT NULL FOREIGN KEY REFERENCES Sizes(Id),
    [Acquired] DATE,
    [Condition] NVARCHAR(100),
    [StateId] INT NOT NULL FOREIGN KEY REFERENCES States(Id),
    [Price] INT NOT NULL,
    [Notes] NVARCHAR(2000)
);
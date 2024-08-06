CREATE TABLE [dbo].[NeopreneGears]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[InternNumber] INT NOT NULL,
    [Piece] NVARCHAR(100)  NOT NULL,
    [SizeId] INT  NOT NULL FOREIGN KEY REFERENCES Sizes(Id),
    [Brand] NVARCHAR(50),
    [Color] NVARCHAR(50),
    [Condition] NVARCHAR(100),
    [StateId] INT NOT NULL FOREIGN KEY REFERENCES States(Id),
    [Acquired] DATE,
    [Price] INT NOT NULL,
    [Notes] NVARCHAR(2000)
)

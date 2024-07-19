CREATE TABLE [dbo].[Tanks]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [InternNumber] INT NOT NULL,
    [Name] NVARCHAR(50)  NOT NULL,
    [Stock] INT  NOT NULL,
    [IsAluminium] BIT NOT NULL,
    [SerialNumber] INT NOT NULL,
    [TankValves] NVARCHAR(50),
    [ColorId] INT FOREIGN KEY REFERENCES Colors(Id),
    [Capacity] INT,
    [Pressure] INT,
    [HT] DATE NOT NULL, --hydraulic test
    [HTCertificate] BIT,
    [Condition] INT,
    [StateId] INT FOREIGN KEY REFERENCES States(Id) NOT NULL,
    [Acquired] DATE,
    [Price] INT NOT NULL,
    [Notes] NVARCHAR(2000)
)


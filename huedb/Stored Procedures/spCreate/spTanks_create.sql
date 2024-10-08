﻿CREATE PROCEDURE [dbo].[spTanks_create]
    @InternNumber INT,
    @Name NVARCHAR(50),
    @Stock INT,
    @IsAluminium BIT,
    @SerialNumber INT,
    @TankValves NVARCHAR(50),
    @Color NVARCHAR(50),
    @Capacity INT,
    @Pressure INT,
    @HT DATE,
    @HTCertificate BIT,
    @Condition INT,
    @StateId INT,
    @Acquired DATE,
    @Price INT,
    @Notes NVARCHAR(2000),
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Tanks] 
    (
        [InternNumber], [Name], [IsAluminium], 
        [SerialNumber], [TankValves], Color, [Capacity], 
        [Pressure], [HT], [HTCertificate], [Condition], 
        [StateId], [Acquired], [Price], [Notes]
    )
    VALUES 
    (
        @InternNumber, @Name, @IsAluminium, 
        @SerialNumber, @TankValves, @Color, @Capacity, 
        @Pressure, @HT, @HTCertificate, @Condition, 
        @StateId, @Acquired, @Price, @Notes
    );

    SET @Id = SCOPE_IDENTITY();
END;

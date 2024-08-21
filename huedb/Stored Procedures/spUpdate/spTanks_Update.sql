CREATE PROCEDURE [dbo].[spTanks_update]
	@Id int,
	@InternNumber int,
    @Acquired Date,
    @Price int,
    @IsAluminium bit, 
    @SerialNumber INT,
    @TankValves NVARCHAR(50),
    @Capacity INT,
    @Pressure INT,
    @HT DATE,
    @HTCertificate BIT,
    @Name NVARCHAR(50),
    @Condition NVARCHAR(50),
    @StateId int,
    @Notes NVARCHAR(2000),
    @Color NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Tanks
    SET InternNumber = @InternNumber,
        SerialNumber = @SerialNumber,
        IsAluminium = @IsAluminium,
        TankValves = @TankValves,
        Acquired = @Acquired,
        Name = @Name,
        Color = @Color,
        Capacity = @Capacity,
        HT = @HT,
        Pressure = @Pressure,
        HTCertificate = @HTCertificate,
        Price = @Price,
        Condition = @Condition,
        StateId = @StateId,
        Notes = @Notes
    WHERE Id = @Id; 
END


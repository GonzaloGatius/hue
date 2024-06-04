CREATE PROCEDURE [dbo].[spOctopus_create]
    @InternNumber INT,
    @BrandId INT,
    @Model NVARCHAR(100),
    @Acquired DATE,
    @System NVARCHAR(50),
    @SerialNumber INT,
    @Condition INT,
    @PartId INT,
    @StateId INT,
    @Price INT,
    @Notes NVARCHAR(2000),
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Octopus] 
    (
        [InternNumber], [BrandId], [Model], [Acquired], 
        [System], [SerialNumber], [Condition], [PartId], 
        [StateId], [Price], [Notes]
    )
    VALUES 
    (
        @InternNumber, @BrandId, @Model, @Acquired, 
        @System, @SerialNumber, @Condition, @PartId, 
        @StateId, @Price, @Notes
    );

    SET @Id = SCOPE_IDENTITY();
END;

CREATE PROCEDURE [dbo].[spFins_create]
    @InternNumber INT,
    @BrandId INT,
    @Model NVARCHAR(100),
    @SizeId INT,
    @Acquired DATE,
    @Condition INT,
    @ColorId INT,
    @StateId INT,
    @Price INT,
    @Notes NVARCHAR(2000),
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Fins] 
    (
        [InternNumber], [BrandId], [Model], [SizeId], 
        [Acquired], [Condition], [ColorId], [StateId], 
        [Price], [Notes]
    )
    VALUES 
    (
        @InternNumber, @BrandId, @Model, @SizeId, 
        @Acquired, @Condition, @ColorId, @StateId, 
        @Price, @Notes
    );

    SET @Id = SCOPE_IDENTITY();
END;

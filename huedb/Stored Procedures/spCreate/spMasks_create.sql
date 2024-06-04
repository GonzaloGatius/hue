CREATE PROCEDURE [dbo].[spMasks_create]
    @InternNumber INT,
    @BrandId INT,
    @Model NVARCHAR(100),
    @SizeId INT,
    @Acquired DATE,
    @Condition INT,
    @StateId INT,
    @ColorId INT,
    @Price INT,
    @Notes NVARCHAR(2000),
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Masks] 
    (
        [InternNumber], [BrandId], [Model], [SizeId], 
        [Acquired], [Condition], [StateId], [ColorId], 
        [Price], [Notes]
    )
    VALUES 
    (
        @InternNumber, @BrandId, @Model, @SizeId, 
        @Acquired, @Condition, @StateId, @ColorId, 
        @Price, @Notes
    );

    SET @Id = SCOPE_IDENTITY();
END;

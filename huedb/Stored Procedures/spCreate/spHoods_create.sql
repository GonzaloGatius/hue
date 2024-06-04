CREATE PROCEDURE [dbo].[spHoods_create]
    @InternNumber INT,
    @Name NVARCHAR(50),
    @Stock INT,
    @SizeId INT,
    @BrandId INT,
    @ColorId INT,
    @Acquired DATE,
    @Condition INT,
    @StateId INT,
    @Price INT,
    @Notes NVARCHAR(2000),
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Hoods] 
    (
        [InternNumber], [Name], [Stock], [SizeId], 
        [BrandId], [ColorId], [Acquired], [Condition], 
        [StateId], [Price], [Notes]
    )
    VALUES 
    (
        @InternNumber, @Name, @Stock, @SizeId, 
        @BrandId, @ColorId, @Acquired, @Condition, 
        @StateId, @Price, @Notes
    );

    SET @Id = SCOPE_IDENTITY();
END;

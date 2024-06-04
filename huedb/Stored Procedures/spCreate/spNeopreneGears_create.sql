CREATE PROCEDURE [dbo].[spNeopreneGears_create]
    @InternNumber INT,
    @Name NVARCHAR(50),
    @Stock INT,
    @SizeId INT,
    @BrandId INT,
    @ColorId INT,
    @ConditionId INT,
    @StateId INT,
    @Acquired DATE,
    @Price INT,
    @Notes NVARCHAR(2000),
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[NeopreneGears] 
    (
        [InternNumber], [Name], [Stock], [SizeId], 
        [BrandId], [ColorId], [ConditionId], [StateId], 
        [Acquired], [Price], [Notes]
    )
    VALUES 
    (
        @InternNumber, @Name, @Stock, @SizeId, 
        @BrandId, @ColorId, @ConditionId, @StateId, 
        @Acquired, @Price, @Notes
    );

    SET @Id = SCOPE_IDENTITY();
END;

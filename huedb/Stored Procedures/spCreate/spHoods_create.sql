CREATE PROCEDURE [dbo].[spHoods_create]
    @InternNumber INT,
    @Stock INT,
    @SizeId INT,
    @Brand NVARCHAR(50),
    @Color NVARCHAR(50),
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
        [InternNumber], [SizeId], 
        [Brand], [Color], [Acquired], [Condition], 
        [StateId], [Price], [Notes]
    )
    VALUES 
    (
        @InternNumber, @SizeId, 
        @Brand, @Color, @Acquired, @Condition, 
        @StateId, @Price, @Notes
    );

    SET @Id = SCOPE_IDENTITY();
END;

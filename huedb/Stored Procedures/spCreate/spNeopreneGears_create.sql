CREATE PROCEDURE [dbo].[spNeopreneGears_create]
    @TableName NVARCHAR(50),
    @InternNumber INT,
    @Model NVARCHAR(50),
    @Stock INT,
    @SizeId INT,
    @Brand NVARCHAR(50),
    @Color NVARCHAR(50),
    @Condition NVARCHAR(50),
    @StateId INT,
    @Acquired DATE,
    @Price INT,
    @Notes NVARCHAR(2000),
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[NeopreneGears] 
    (
        [InternNumber], [Model], [SizeId], 
        [Brand], [Color], [Condition], [StateId], 
        [Acquired], [Price], [Notes]
    )
    VALUES 
    (
        @InternNumber, @Model, @SizeId, 
        @Brand, @Color, @Condition, @StateId, 
        @Acquired, @Price, @Notes
    );

    SET @Id = SCOPE_IDENTITY();
END;

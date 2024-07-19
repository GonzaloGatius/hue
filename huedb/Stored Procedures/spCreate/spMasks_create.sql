CREATE PROCEDURE [dbo].[spMasks_create]
    @InternNumber INT,
    @Brand NVARCHAR(50),
    @Model NVARCHAR(100),
    @Size NVARCHAR(50),
    @Acquired DATE,
    @Condition INT,
    @StateId INT,
    @Color NVARCHAR(50),
    @Price INT,
    @Notes NVARCHAR(2000),
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Masks] 
    (
        [InternNumber], [Brand], [Model], [Size], 
        [Acquired], [Condition], [StateId], [Color], 
        [Price], [Notes]
    )
    VALUES 
    (
        @InternNumber, @Brand, @Model, @Size, 
        @Acquired, @Condition, @StateId, @Color, 
        @Price, @Notes
    );

    SET @Id = SCOPE_IDENTITY();
END;

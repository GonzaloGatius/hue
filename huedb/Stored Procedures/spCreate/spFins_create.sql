CREATE PROCEDURE [dbo].[spFins_create]
    @InternNumber INT,
    @Brand NVARCHAR(50),
    @Model NVARCHAR(100),
    @Size NVARCHAR(50),
    @Acquired DATE,
    @Condition INT,
    @Color NVARCHAR(50),
    @StateId INT,
    @Price INT,
    @Notes NVARCHAR(2000),
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Fins] 
    (
        [InternNumber], [Brand], [Model], [Size], 
        [Acquired], [Condition], [Color], [StateId], 
        [Price], [Notes]
    )
    VALUES 
    (
        @InternNumber, @Brand, @Model, @Size, 
        @Acquired, @Condition, @Color, @StateId, 
        @Price, @Notes
    );

    SET @Id = SCOPE_IDENTITY();
END;

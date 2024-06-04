CREATE PROCEDURE [dbo].[spWeights_create]
    @Name NVARCHAR(50),
    @TypeId INT,
    @Stock INT,
    @Weight INT,
    @Price INT,
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Weights] 
    (
        [Name], [TypeId], [Stock], [Weight], 
        [Price]
    )
    VALUES 
    (
        @Name, @TypeId, @Stock, @Weight, 
        @Price
    );

    SET @Id = SCOPE_IDENTITY();
END;

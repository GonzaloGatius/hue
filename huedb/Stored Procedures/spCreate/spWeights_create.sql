CREATE PROCEDURE [dbo].[spWeights_create]
    @Name NVARCHAR(50),
    @Stock INT,
    @Weight INT,
    @Price INT,
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Weights] 
    (
        [Name], [Stock], [Weight], 
        [Price]
    )
    VALUES 
    (
        @Name, @Stock, @Weight, 
        @Price
    );

    SET @Id = SCOPE_IDENTITY();
END;

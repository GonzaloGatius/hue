CREATE PROCEDURE [dbo].[spOctopus_create] --Revisar el quilombo de las partes, la rpmqlrmvp. 
    @InternNumber INT,
    @Brand NVARCHAR(50),
    @Model NVARCHAR(100),
    @Piece NVARCHAR(100),
    @Acquired DATE,
    @SerialNumber INT,
    @Condition NVARCHAR(50),
    @StateId INT,
    @Price INT,
    @Notes NVARCHAR(2000),
    @Composition NVARCHAR(2000),
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Octopus] 
    (
        [InternNumber], [Brand], [Model], [Acquired],  
         [SerialNumber], [Condition],  
        [StateId], [Price], [Notes], [Composition]
    )
    VALUES 
    (
        @InternNumber, @Brand, @Model, @Acquired, 
        @SerialNumber, @Condition,
        @StateId, @Price, @Notes, @Composition
    );

    SET @Id = SCOPE_IDENTITY();
END;

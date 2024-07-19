CREATE PROCEDURE [dbo].[spBCDs_create]
    @InternNumber INT,
    @Brand NVARCHAR(50),
    @Model NVARCHAR(100),
    @Size NVARCHAR(50),
    @Valves NVARCHAR(50),
    @Power NVARCHAR(50),
    @Acquired DATE,
    @Condition INT,
    @StateId INT,
    @Price INT,
    @Notes NVARCHAR(2000),
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[BCDs] 
    (
        [InternNumber], [Brand], [Model], [Size], 
        [Valves], [Power], [Acquired], [Condition], 
        [StateId], [Price], [Notes]
    )
    VALUES 
    (
        @InternNumber, @Brand, @Model, @Size, 
        @Valves, @Power, @Acquired, @Condition, 
        @StateId, @Price, @Notes
    );

    SET @Id = SCOPE_IDENTITY();
END;

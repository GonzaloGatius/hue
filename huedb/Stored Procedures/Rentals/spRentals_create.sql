CREATE PROCEDURE [dbo].[spRentals_create]
	@UserId INT, 
	@Date DATETIME2,
	@AccId INT,
	@BodyId INT,
	@FootwearId INT,
	@Quantity INT,
	@Id INT OUTPUT
	/*
	Chat gpt para manejar si no existe el userId FK
	BEGIN
    -- Verificar si UserId existe en Users
    IF NOT EXISTS (SELECT 1 FROM [dbo].[Users] WHERE Id = @UserId)
    BEGIN
        -- Manejar la situación de UserId no existente
        -- Por ejemplo, asignar un valor específico a @Id o lanzar una excepción
        SET @Id = -1; -- Asignar un valor específico
        -- O bien, lanzar una excepción personalizada
        -- THROW 51000, 'El UserId proporcionado no existe.', 1;
        RETURN; -- O salir del procedimiento almacenado
    END
	*/

AS
BEGIN
	INSERT INTO [dbo].[Rentals](UserId, Date, AccId, BodyId, FootwearId, Quantity)
	values(@UserId, @Date, @AccId, @BodyId, @FootwearId, @Quantity)
	set @Id = SCOPE_IDENTITY
END
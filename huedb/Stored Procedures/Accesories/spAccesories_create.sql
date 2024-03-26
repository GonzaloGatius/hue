CREATE PROCEDURE [dbo].[spAccesories_create]
	@Name NVARCHAR(50),
	@Stock INT,
	@Price INT,
	@Id INT OUTPUT
AS
BEGIN
	insert INTO [dbo].[Accesories](Name, Stock, Price)
	values(@Name, @Stock, @Price)
	SET @Id = SCOPE_IDENTITY
END

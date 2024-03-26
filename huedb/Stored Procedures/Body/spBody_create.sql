CREATE PROCEDURE [dbo].[spBody_create]
	@Name NVARCHAR(50),
	@Stock INT,
	@Price INT,
	@Size NVARCHAR(20),
	@Mm INT,
	@Brand NVARCHAR(50),
	@Id INT OUTPUT
AS
BEGIN
	insert INTO [dbo].[Body](Name, Stock, Price, Size, Mm, Brand)
	values(@Name, @Stock, @Price, @Size, @Mm, @Brand)
	SET @Id = SCOPE_IDENTITY
END

CREATE PROCEDURE [dbo].[spFootwear_create]
	@Name NVARCHAR(50),
	@Stock INT,
	@Price INT,
	@Size NVARCHAR(20),
	@Brand NVARCHAR(50),
	@Id INT OUTPUT
AS
BEGIN
	insert INTO [dbo].[Footwear](Name, Stock, Price, Size, Brand)
	values(@Name, @Stock, @Price, @Size, @Brand)
	SET @Id = SCOPE_IDENTITY
END

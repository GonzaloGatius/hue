CREATE PROCEDURE [dbo].[spAccesories_create]
	@Name NVARCHAR(50),
	@Table NVARCHAR(50),
	@Stock INT,
	@Price INT,
	@Id INT OUTPUT
AS
BEGIN
	insert INTO @Table(Name, Stock, Price)
	values(@Name, @Stock, @Price)
	SET @Id = SCOPE_IDENTITY
END

CREATE PROCEDURE [dbo].[spGenerics_updateStock]
	@Id int,
	@tableName NVARCHAR(50),
	@newStock int
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET Stock = @newStock WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newStock INT, @Id INT', @Id = @Id, @newStock = @newStock;
END
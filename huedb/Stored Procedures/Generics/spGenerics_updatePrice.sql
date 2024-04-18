CREATE PROCEDURE [dbo].[spGenerics_updatePrice]
	@Id int,
	@tableName NVARCHAR(50),
	@newPrice int
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET Price = @newPrice WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newPrice INT, @Id INT', @Id = @Id, @newPrice = @newPrice;
END

CREATE PROCEDURE [dbo].[spGenerics_updateName]
	@Id int,
	@tableName NVARCHAR(50),
	@newName NVARCHAR(50)
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET Name = @newName WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newName NVARCHAR(50), @Id INT', @Id = @Id, @newName = @newName;
END

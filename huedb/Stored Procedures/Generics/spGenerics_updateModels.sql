CREATE PROCEDURE [dbo].[spGenerics_updateModels]
	@Id int,
	@tableName NVARCHAR(50),
	@newModel NVARCHAR(100)
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET Model = @newModel WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newModel NVARCHAR(100), @Id INT', @Id = @Id, @newModel = @newModel;
END
--Vulnerable.
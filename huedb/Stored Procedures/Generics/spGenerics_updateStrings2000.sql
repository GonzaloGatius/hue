CREATE PROCEDURE [dbo].[spGenerics_updateStrings2000]
	@Id int,
	@tableName NVARCHAR(50),
	@tableColumn NVARCHAR(50),
	@newString NVARCHAR(2000)
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET '+ QUOTENAME(@tableColumn) + ' = @newString WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newString NVARCHAR(2000), @Id INT', @Id = @Id, @newString = @newString;
END
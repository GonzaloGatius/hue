CREATE PROCEDURE [dbo].[spGenerics_updateStrings100]
@Id int,
	@tableName NVARCHAR(50),
	@tableColumn NVARCHAR(50),
	@newString NVARCHAR(100)
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET '+ QUOTENAME(@tableColumn) + ' = @newString WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newString NVARCHAR(100), @Id INT', @Id = @Id, @newString = @newString;
END
--Vulnerable.
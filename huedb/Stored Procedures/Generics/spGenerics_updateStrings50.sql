CREATE PROCEDURE [dbo].[spGenerics_updateStrings50]
	@Id int,
	@tableName NVARCHAR(50),
	@tableColumn NVARCHAR(50),
	@newString NVARCHAR(50)
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET '+ QUOTENAME(@tableColumn) + ' = @newString WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newString NVARCHAR(50), @Id INT', @Id = @Id, @newString = @newString;
END
--Vulnerable.
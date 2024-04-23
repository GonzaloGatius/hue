CREATE PROCEDURE [dbo].[spGenerics_updateIntegers]
	@Id int,
	@tableName NVARCHAR(50),
	@tableColumn NVARCHAR(50),
	@newInt int
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET '+ QUOTENAME(@tableColumn) + ' = @newInt WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newInt INT, @Id INT', @Id = @Id, @newInt = @newInt;
END
--Vulnerable.
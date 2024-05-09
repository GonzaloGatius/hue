CREATE PROCEDURE [dbo].[spGenerics_updateDates]
	@Id int,
	@tableName NVARCHAR(50),
	@tableColumn NVARCHAR(50),
	@newDate date
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET '+ QUOTENAME(@tableColumn) + ' = @newDate WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newDate DATE, @Id INT', @Id = @Id, @newDate = @newDate;
END
--Vulnerable.
CREATE PROCEDURE [dbo].[spGenerics_updateState]
	@Id int,
	@tableName NVARCHAR(50),
	@newState int
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET State = @newState WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newState INT, @Id INT', @Id = @Id, @newState = @newState;
END

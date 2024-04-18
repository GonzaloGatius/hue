CREATE PROCEDURE [dbo].[spGenerics_updateCondition]
	@Id int,
	@tableName NVARCHAR(50),
	@newCondition int
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET Condition = @newCondition WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newCondition INT, @Id INT', @Id = @Id, @newCondition = @newCondition;
END

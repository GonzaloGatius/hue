CREATE PROCEDURE [dbo].[spGenerics_updateInternNumber]
	@Id int,
	@tableName NVARCHAR(50),
	@newInternNumber int
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET InternNumber = @newInternNumber WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newInternNumber INT, @Id INT', @Id = @Id, @newInternNumber = @newInternNumber;
END
CREATE PROCEDURE [dbo].[spGenerics_updateNotes]
	@Id int,
	@tableName NVARCHAR(50),
	@newNote NVARCHAR(2000)
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'UPDATE ' + QUOTENAME(@tableName) + ' SET Notes = @newNote WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@newNote NVARCHAR(2000), @Id INT', @Id = @Id, @newNote = @newNote;
END
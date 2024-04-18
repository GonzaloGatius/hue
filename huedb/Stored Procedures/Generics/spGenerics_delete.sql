CREATE PROCEDURE [dbo].[spGenerics_delete]
	 @Id int,
	 @tableName NVARCHAR(50)
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
        SET @sql = 'DELETE FROM ' + QUOTENAME(@tableName) + ' WHERE Id = @Id'
        EXEC sp_executesql @sql, N'@Id int', @Id = @Id;
END
	
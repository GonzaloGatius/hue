CREATE PROCEDURE [dbo].[spGenerics_createWithName50]

	@tableName NVARCHAR(50),
	@name NVARCHAR(50)
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'INSERT INTO' + QUOTENAME(@tableName) + ' ( Name ) VALUES ( @name);' 
        EXEC sp_executesql @sql, N'@name NVARCHAR(50)', @name = @name;
END
--Vulnerable.
CREATE PROCEDURE [dbo].[spGenerics_createWithName50]

	@tableName NVARCHAR(50),
	@newString NVARCHAR(50)
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'INSERT INTO' + QUOTENAME(@tableName) + ' ( Name ) VALUES ( @newString);' 
        EXEC sp_executesql @sql, N'@newString NVARCHAR(50)', @newString = @newString;
END
--Vulnerable.
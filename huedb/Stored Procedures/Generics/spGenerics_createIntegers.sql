CREATE PROCEDURE [dbo].[spGenerics_createInteger]

	@tableName INT,
	@newint INT
AS
BEGIN
		DECLARE @sql NVARCHAR(MAX)
		SET @sql = 'INSERT INTO' + QUOTENAME(@tableName) + ' (' + QUOTENAME(tableName) + ') VALUES (@newInt);';
        EXEC sp_executesql @sql, N'@newInt INT', @newInt = @newInt;
END
--Vulnerable.
CREATE PROCEDURE [dbo].[spGenerics_getById]
     @Id int,
	 @tableName NVARCHAR(50)
AS
BEGIN
  --  IF @tableName IN ('BCDs', 'Brands', 'Colors', 'Fins', 'Hoods', 'Masks', 'NeopreneGears', 'Octopus', 'OctopusParts', 'Rentals', 'Sizes', 'States', 'Tanks', 'Users', 'Weights', 'WeightTypes')
    --BEGIN
        DECLARE @sql NVARCHAR(MAX)
        SET @sql = 'SELECT * FROM ' + QUOTENAME(@tableName) + ' WHERE Id =  '+ @Id
        EXEC sp_executesql @sql, N'@Id int', @Id = @Id
END
   /* --------------FUNCA EN MSSQL --------------------------------
   CREATE PROCEDURE [dbo].[spGenerics_getById4]
     @Id int,
	 @tableName NVARCHAR(50)
AS
BEGIN
  --  IF @tableName IN ('BCDs', 'Brands', 'Colors', 'Fins', 'Hoods', 'Masks', 'NeopreneGears', 'Octopus', 'OctopusParts', 'Rentals', 'Sizes', 'States', 'Tanks', 'Users', 'Weights', 'WeightTypes')
    --BEGIN
        DECLARE @sql NVARCHAR(MAX)
        SET @sql = 'SELECT * FROM ' + QUOTENAME(@tableName) + ' WHERE @Id = Id' 
        EXEC sp_executesql @sql, N'@Id int', @Id = @Id
END
    --END

	exec spGenerics_getById4 @Id = 1, @tableName = 'Body'*/


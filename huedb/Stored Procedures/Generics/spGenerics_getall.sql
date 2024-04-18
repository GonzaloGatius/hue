CREATE PROCEDURE [dbo].[spGenerics_getAll]
    @tableName NVARCHAR(50)
AS
BEGIN
  --  IF @tableName IN ('BCDs', 'Brands', 'Colors', 'Fins', 'Hoods', 'Masks', 'NeopreneGears', 'Octopus', 'OctopusParts', 'Rentals', 'Sizes', 'States', 'Tanks', 'Users', 'Weights', 'WeightTypes')
    --BEGIN
        DECLARE @sql NVARCHAR(MAX)
        SET @sql = 'SELECT * FROM ' + QUOTENAME(@tableName)
        EXEC sp_executesql @sql
    --END
    --ELSE
    --BEGIN
        -- Manejo de error: tabla no encontrada
      --  RAISERROR('Tabla especificada no encontrada.', 16, 1)
  --  END
END

















    /*
AS
BEGIN
  IF @tableName = 'BCDs'
    BEGIN
        SELECT * FROM BCDs
    END
    ELSE IF @TableName = 'Brands'
    BEGIN
        SELECT * FROM Brands
    END
    ELSE IF @TableName = 'Colors'
    BEGIN
        SELECT * FROM Colors
    END
    ELSE IF @TableName = 'Fins'
    BEGIN
        SELECT * FROM Fins
    END
    ELSE IF @TableName = 'Hoods'
    BEGIN
        SELECT * FROM Hoods
    END
        ELSE IF @TableName = 'Masks'
    BEGIN
        SELECT * FROM Masks
    END
        ELSE IF @TableName = 'NeopreneGears'
    BEGIN
        SELECT * FROM NeopreneGears
    END
        ELSE IF @TableName = 'Octopus'
    BEGIN
        SELECT * FROM Octopus
    END
        ELSE IF @TableName = 'OctopusParts'
    BEGIN
        SELECT * FROM OctopusParts
    END
        ELSE IF @TableName = 'Brands'
    BEGIN
        SELECT * FROM Brands
    END
        ELSE IF @TableName = 'Brands'
    BEGIN
        SELECT * FROM Brands
    END
        ELSE IF @TableName = 'Brands'
    BEGIN
        SELECT * FROM Brands
    END
        ELSE IF @TableName = 'Brands'
    BEGIN
        SELECT * FROM Brands
    END
        ELSE IF @TableName = 'Brands'
    BEGIN
        SELECT * FROM Brands
    END
        ELSE IF @TableName = 'Brands'
    BEGIN
        SELECT * FROM Brands
    END
        ELSE IF @TableName = 'Brands'
    BEGIN
        SELECT * FROM Brands
    END


END
	SELECT @
RETURN 0
*/
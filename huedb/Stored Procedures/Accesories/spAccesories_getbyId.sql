CREATE PROCEDURE [dbo].[spAccesories_getbyId]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT * 
    FROM [dbo].[Accesories]
    WHERE Id = @Id;
END

CREATE PROCEDURE [dbo].[spAccesories_delete]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DELETE
    FROM [dbo].[Accesories]
    WHERE Id = @Id;
END

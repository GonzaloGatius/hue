CREATE PROCEDURE [dbo].[spFootwear_delete]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DELETE
    FROM [dbo].[Footwear]
    WHERE Id = @Id;
END

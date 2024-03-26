CREATE PROCEDURE [dbo].[spFootwear_getbyId]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT * 
    FROM [dbo].[Footwear]
    WHERE Id = @Id;
END

CREATE PROCEDURE [dbo].[spBody_getbyId]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT * 
    FROM [dbo].[Body]
    WHERE Id = @Id;
END

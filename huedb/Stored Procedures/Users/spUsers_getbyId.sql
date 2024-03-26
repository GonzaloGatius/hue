CREATE PROCEDURE [dbo].[spUsers_getbyId]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT * 
    FROM [dbo].[Users]
    WHERE Id = @Id;
END

CREATE PROCEDURE [dbo].[spUsers_delete]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DELETE
    FROM [dbo].[Users]
    WHERE Id = @Id;
END

CREATE PROCEDURE [dbo].[spBody_delete]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DELETE
    FROM [dbo].[Body]
    WHERE Id = @Id;
END

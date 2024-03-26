CREATE PROCEDURE [dbo].[spUsers_updateAdmin]
	@Id INT,
	@Admin BIT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[Users] 
    SET Admin = @Admin
    WHERE Id = @Id;
END
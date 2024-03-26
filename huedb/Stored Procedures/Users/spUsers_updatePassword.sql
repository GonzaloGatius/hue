CREATE PROCEDURE [dbo].[spUsers_updatePassword]
	@Id INT,
	@Password INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[Users] 
    SET Password = @Password
    WHERE Id = @Id;
END
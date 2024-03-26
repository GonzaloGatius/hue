CREATE PROCEDURE [dbo].[spUsers_create]
	@Admin BIT,
	@Email NVARCHAR(50),
	@Password NVARCHAR(50),
	@Id INT OUTPUT

AS
BEGIN
	INSERT INTO [dbo].[Users](Admin, Email, Password)
	values(@Admin, @Email, @Password)
	set @Id = SCOPE_IDENTITY
END
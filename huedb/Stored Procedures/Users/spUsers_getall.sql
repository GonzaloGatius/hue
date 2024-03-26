CREATE PROCEDURE [dbo].[spUsers_getall]
	


AS
BEGIN
	set nocount on;
	SELECT * FROM [dbo].[Users]
END

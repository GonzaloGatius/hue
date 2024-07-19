CREATE PROCEDURE [dbo].[spProductTypes_GetNameById]
	@Id int
AS
	SELECT Name From [dbo].[ProductTypes] 
	Where @Id = Id  
RETURN 0

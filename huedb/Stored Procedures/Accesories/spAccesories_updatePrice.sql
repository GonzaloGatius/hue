CREATE PROCEDURE [dbo].[spAccesories_updatePrice]
	@Id INT,
	@Price INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[Accesories] 
    SET Price = @Price
    WHERE Id = @Id;
END
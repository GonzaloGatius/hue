CREATE PROCEDURE [dbo].[spFootwear_updatePrice]
	@Id INT,
	@Price INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[Footwear] 
    SET Price = @Price
    WHERE Id = @Id;
END
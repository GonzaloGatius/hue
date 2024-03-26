CREATE PROCEDURE [dbo].[spBody_updatePrice]
	@Id INT,
	@Price INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[Body] 
    SET Price = @Price
    WHERE Id = @Id;
END
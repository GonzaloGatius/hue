CREATE PROCEDURE [dbo].[spFootwear_updateStock]
	@Id INT,
	@Stock INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[Footwear] 
    SET Stock = @Stock
    WHERE Id = @Id;
END
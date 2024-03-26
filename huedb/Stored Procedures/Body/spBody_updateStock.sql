CREATE PROCEDURE [dbo].[spBody_updateStock]
	@Id INT,
	@Stock INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[Body] 
    SET Stock = @Stock
    WHERE Id = @Id;
END
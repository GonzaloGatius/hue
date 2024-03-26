CREATE PROCEDURE [dbo].[spAccesories_updateStock]
	@Id INT,
	@Stock INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[Accesories] 
    SET Stock = @Stock
    WHERE Id = @Id;
END
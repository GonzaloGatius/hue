CREATE PROCEDURE [dbo].[spRentals_getbyId]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT * 
    FROM [dbo].[Rentals]
    WHERE Id = @Id;
END

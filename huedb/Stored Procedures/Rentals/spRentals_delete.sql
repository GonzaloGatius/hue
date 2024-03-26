CREATE PROCEDURE [dbo].[spRentals_delete]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DELETE
    FROM [dbo].[Rentals]
    WHERE Id = @Id;
END

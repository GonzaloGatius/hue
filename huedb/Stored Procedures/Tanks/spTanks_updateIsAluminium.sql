CREATE PROCEDURE [dbo].[spTanks_updateIsAluminium]
	@Id INT,
	@Aluminium BIT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[Tanks] 
    SET IsAluminium = @Aluminium
    WHERE Id = @Id;
END
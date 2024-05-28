CREATE PROCEDURE [dbo].[spTanks_HTCertificate]
	@Id INT,
	@HTC BIT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE [dbo].[Tanks] 
    SET HTCertificate = @HTC
    WHERE Id = @Id;
END
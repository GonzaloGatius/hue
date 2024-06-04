CREATE PROCEDURE [dbo].[spRentals_create]
    @UserId INT,
    @InitialDate DATE,
    @EndDate DATE,
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Rentals] 
    (
        [UserId], [InitialDate], [EndDate]
    )
    VALUES 
    (
        @UserId, @InitialDate, @EndDate
    );

    SET @Id = SCOPE_IDENTITY();
END;

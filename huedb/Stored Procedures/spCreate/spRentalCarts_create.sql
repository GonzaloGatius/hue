CREATE PROCEDURE [dbo].[spRentalCarts_create]
    @RentalId INT,
    @ProductTypeId INT,
    @ProductId INT,
    @Quantity INT,
    @Id INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[RentalCarts] 
    (
        [RentalId], [ProductTypeId], [ProductId], [Quantity]
    )
    VALUES 
    (
        @RentalId, @ProductTypeId, @ProductId, @Quantity
    );

    SET @Id = SCOPE_IDENTITY();
END;

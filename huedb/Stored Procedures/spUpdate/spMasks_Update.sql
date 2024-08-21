CREATE PROCEDURE [dbo].[spMasks_update]
	@Id int,
	@InternNumber int,
    @Acquired Date,
    @Price int,
    @Condition NVARCHAR(50),
    @StateId int,
    @Notes NVARCHAR(2000),
    @Piece NVARCHAR(50),
    @Color NVARCHAR(50),
    @SizeId int,
    @Model NVARCHAR(100),
    @Brand NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Masks
    SET InternNumber = @InternNumber,
        Acquired = @Acquired,
        Price = @Price,
        Condition = @Condition,
        StateId = @StateId,
        Notes = @Notes,
        Color = @Color,
        SizeId = @SizeId,
        Brand = @Brand,
        Model = @Model
    WHERE Id = @Id; 
END


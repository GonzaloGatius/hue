CREATE PROCEDURE [dbo].[spNeopreneGears_update]
    @Id int,
	@InternNumber int,
    @Acquired Date,
    @Price int,
    @Condition NVARCHAR(50),
    @StateId int,
    @Notes NVARCHAR(2000),
    @Model NVARCHAR(50),
    @Color NVARCHAR(50),
    @SizeId int,
    @Brand NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE NeopreneGears
    SET InternNumber = @InternNumber,
        Acquired = @Acquired,
        Price = @Price,
        Condition = @Condition,
        StateId = @StateId,
        Notes = @Notes,
        Model = @Model,
        Color = @Color,
        SizeId = @SizeId,
        Brand = @Brand
    WHERE Id = @Id; 
END
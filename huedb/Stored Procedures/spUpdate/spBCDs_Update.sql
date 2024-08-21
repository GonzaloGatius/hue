CREATE PROCEDURE [dbo].[spBCDs_update]
	@Id int,
	@InternNumber int,
    @Acquired Date,
    @Price int,
    @Condition NVARCHAR(50),
    @StateId int,
    @Notes NVARCHAR(2000),
    @Valves NVARCHAR(50),
    @Power NVARCHAR(50),
    @SizeId int,
    @Model NVARCHAR(100),
    @Brand NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE BCDs
    SET InternNumber = @InternNumber,
        Acquired = @Acquired,
        Price = @Price,
        Condition = @Condition,
        StateId = @StateId,
        Notes = @Notes,
        SizeId = @SizeId,
        Brand = @Brand,
        Model = @Model,
        Valves = @Valves,
        Power = @Power
    WHERE Id = @Id; 
END

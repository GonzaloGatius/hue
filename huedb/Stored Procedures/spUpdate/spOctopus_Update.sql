﻿CREATE PROCEDURE [dbo].[spOctopus_update]
	@Id int,
	@InternNumber int,
    @Acquired Date,
	@SerialNumber int,
    @Price int,
    @Condition NVARCHAR(50),
    @Notes NVARCHAR(2000),
    @Composition NVARCHAR(2000),
    @Model NVARCHAR(100),
    @StateId int,
    @Brand NVARCHAR(50)
	    

AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE Octopus
    SET InternNumber = @InternNumber,
        Acquired = @Acquired,
        Price = @Price,
		SerialNumber = @SerialNumber,
        Condition = @Condition,
        Composition = @Composition,
        StateId = @StateId,
        Notes = @Notes,
        Brand = @Brand,
        Model = @Model
    WHERE Id = @Id; 
END
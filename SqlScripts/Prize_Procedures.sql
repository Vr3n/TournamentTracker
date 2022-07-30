CREATE PROCEDURE dbo.spPrizes_Insert
	-- Add the parameters for the stored procedure here
	@PlaceNumber int,
	@PlaceName nvarchar(250),
	@PrizeAmount money,
	@PrizePercentage decimal(5,4),
	@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Prize (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage)

	select @id = SCOPE_IDENTITY();
END
GO

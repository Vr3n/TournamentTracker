CREATE PROCEDURE [dbo].[spPersons_Insert]
	-- Add the parameters for the stored procedure here
	@FirstName nvarchar(250),
	@LastName nvarchar(250),
	@EmailAddress nvarchar(250),
	@CellPhoneNumber nvarchar(250),
	@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Person(FirstName, LastName, EmailAddress, CellPhoneNumber)
	VALUES (@FirstName, @LastName, @EmailAddress, @CellPhoneNumber)

	select @id = SCOPE_IDENTITY();
END

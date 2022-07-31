
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	For Creating Team.
-- =============================================
CREATE PROCEDURE dbo.spTeams_Insert
	-- Add the parameters for the stored procedure here
	@TeamName nvarchar(100),
	@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Team (TeamName)
	VALUES (@TeamName)

	SELECT @id = SCOPE_IDENTITY();
END
GO

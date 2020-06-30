CREATE PROCEDURE [dbo].[spJobcard_Delete]
	@JobcardId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM [dbo].[Jobcard]
	WHERE JobcardId = @JobcardId;

END;

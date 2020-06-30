CREATE PROCEDURE [dbo].[spJobtype_Delete]
	@JobtypeId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM [dbo].[Jobtype]
	WHERE JobtypeId = @JobtypeId;

END;

CREATE PROCEDURE [dbo].[spJobtype_GetById]
	@JobtypeId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		JobtypeId,
		JobtypeName,
		JobtypeDescription,
		CreatedAt,
		ModifiedDate
	FROM
		[dbo].[Jobtype]
	WHERE
		JobtypeId = @JobtypeId;
END;

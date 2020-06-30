CREATE PROCEDURE [dbo].[spJobtype_GetAll]

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
END;

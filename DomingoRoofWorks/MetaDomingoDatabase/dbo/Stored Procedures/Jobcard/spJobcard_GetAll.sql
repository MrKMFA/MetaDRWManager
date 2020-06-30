CREATE PROCEDURE [dbo].[spJobcard_GetAll]

WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		JobcardId,
		CreatedBy,
		CustomerId,
		JobtypeId,
		JobStartDate,
		JobEndDate,
		CreatedAt,
		ModifiedDate
	FROM
		[dbo].[Jobcard]

END;
